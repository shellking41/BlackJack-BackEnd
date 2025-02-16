using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackJack.Migrations
{
    /// <inheritdoc />
    public partial class blackjack4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_GameStates_GameStateId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GameStateId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_GameStates_UserId",
                table: "GameStates");

            migrationBuilder.DropColumn(
                name: "GameStateId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_GameStates_UserId",
                table: "GameStates",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GameStates_UserId",
                table: "GameStates");

            migrationBuilder.AddColumn<int>(
                name: "GameStateId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_GameStateId",
                table: "Users",
                column: "GameStateId");

            migrationBuilder.CreateIndex(
                name: "IX_GameStates_UserId",
                table: "GameStates",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_GameStates_GameStateId",
                table: "Users",
                column: "GameStateId",
                principalTable: "GameStates",
                principalColumn: "Id");
        }
    }
}
