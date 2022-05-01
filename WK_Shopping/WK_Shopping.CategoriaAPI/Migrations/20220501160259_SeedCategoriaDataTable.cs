using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WK_Shopping.CategoriaAPI.Migrations
{
    public partial class SeedCategoriaDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categoria",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1L, "T-shirt" },
                    { 2L, "Action Figure" },
                    { 3L, "Action Figure" },
                    { 4L, "T-shirt" },
                    { 5L, "T-shirt" },
                    { 6L, "T-shirt" },
                    { 7L, "Sweatshirt" },
                    { 8L, "Book" },
                    { 9L, "Action Figure" },
                    { 10L, "T-shirt" },
                    { 11L, "T-shirt" },
                    { 12L, "T-shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 12L);
        }
    }
}
