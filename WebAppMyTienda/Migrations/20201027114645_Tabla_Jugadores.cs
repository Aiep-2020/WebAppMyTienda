using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMyTienda.Migrations
{
    public partial class Tabla_Jugadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    Anio = table.Column<int>(nullable: false),
                    Sinopsis = table.Column<string>(maxLength: 500, nullable: true),
                    Trailer = table.Column<string>(nullable: true),
                    PostUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugadores");
        }
    }
}
