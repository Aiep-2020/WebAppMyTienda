using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMyTienda.Migrations
{
    public partial class Ligastabla_01_update_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NombreLigas",
                table: "Tbl_Ligas",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NombreLigas",
                table: "Tbl_Ligas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
