using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WK_Shopping.ProdutoAPI.Migrations
{
    public partial class SeedProdutoDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "categoria_nome",
                table: "produto",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "produto",
                columns: new[] { "id", "categoria_nome", "descricao", "imagem_url", "nome", "preco" },
                values: new object[,]
                {
                    { 1L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/2_no_internet.jpg?raw=true", "Camiseta No Internet", 69.9m },
                    { 2L, "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m },
                    { 3L, "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/4_storm_tropper.jpg?raw=true", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", 189.99m },
                    { 4L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m },
                    { 5L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m },
                    { 6L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee Benefits", 69.9m },
                    { 7L, "Sweatshirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz Cobra Kai", 159.9m },
                    { 8L, "Book", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/9_neil.jpg?raw=true", "Livro Star Talk – Neil DeGrasse Tyson", 49.9m },
                    { 9L, "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 359.99m },
                    { 10L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/11_mars.jpg?raw=true", "Camiseta Elon Musk Spacex Marte Occupy Mars", 59.99m },
                    { 11L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux Programador Masculina", 59.99m },
                    { 12L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/13_dragon_ball.jpg", "Camiseta Goku Fases", 59.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.AlterColumn<int>(
                name: "categoria_nome",
                table: "produto",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
