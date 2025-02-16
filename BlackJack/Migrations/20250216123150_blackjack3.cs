using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackJack.Migrations
{
    /// <inheritdoc />
    public partial class blackjack3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "GameStates",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "GameStates",
                newName: "State");
        }
    }
}
