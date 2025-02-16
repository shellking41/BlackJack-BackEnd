using BlackJack.Data;
using BlackJack.Repository;
using BlackJack.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BJ_DB_CONNETCION_STRING"));
});

builder.Services.AddScoped<ICardRepository, CardRepository>();//dependency injection
builder.Services.AddScoped<ICardService, CardService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();//dependency injection
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IGameStateRepository, GameStateRepository>();//dependency injection
builder.Services.AddScoped<IGameStateService, GameStateService>();

builder.Services.AddScoped<IStatisticRepository, StatisticRepository>();//dependency injection
builder.Services.AddScoped<IStatisticService, StatisticService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
