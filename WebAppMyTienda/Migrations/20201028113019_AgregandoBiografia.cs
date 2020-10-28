using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMyTienda.Migrations
{
    public partial class AgregandoBiografia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fotografia",
                table: "Jugadores");

            migrationBuilder.AddColumn<string>(
                name: "Biografia",
                table: "Jugadores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biografia",
                table: "Jugadores");

            migrationBuilder.AddColumn<string>(
                name: "Fotografia",
                table: "Jugadores",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
