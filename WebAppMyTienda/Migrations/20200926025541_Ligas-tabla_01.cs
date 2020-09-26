using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMyTienda.Migrations
{
    public partial class Ligastabla_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Ligas",
                columns: table => new
                {
                    idliga = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreLigas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Ligas", x => x.idliga);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Ligas");
        }
    }
}
