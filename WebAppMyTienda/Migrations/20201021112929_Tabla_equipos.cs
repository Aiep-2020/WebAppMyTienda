using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMyTienda.Migrations
{
    public partial class Tabla_equipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NombreLigas",
                table: "Tbl_Ligas",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Equipos",
                columns: table => new
                {
                    idEquipo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEquipo = table.Column<string>(maxLength: 20, nullable: false),
                    FechaFundc = table.Column<DateTime>(nullable: false),
                    Fotografia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Equipos", x => x.idEquipo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Equipos");

            migrationBuilder.AlterColumn<string>(
                name: "NombreLigas",
                table: "Tbl_Ligas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }
    }
}
