using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WK_Shopping.ProdutoAPI.Migrations
{
    public partial class AdicionandoTabelaProdutoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
