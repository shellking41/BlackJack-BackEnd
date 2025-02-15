using BlackJack.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackJack.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<GameState> GameStates { get; set; }

        public DbSet<Statistic> Statistics { get; set; }
    }
}
