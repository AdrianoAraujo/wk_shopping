using Microsoft.EntityFrameworkCore;

namespace WK_Shopping.ProdutoAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "Camiseta No Internet",
                Preco = new decimal(69.9),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/2_no_internet.jpg?raw=true",
                CategoriaNome = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 2,
                Nome = "Capacete Darth Vader Star Wars Black Series",
                Preco = new decimal(999.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/3_vader.jpg?raw=true",
                CategoriaNome = "Action Figure"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 3,
                Nome = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                Preco = new decimal(189.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/4_storm_tropper.jpg?raw=true",
                CategoriaNome = "Action Figure"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 4,
                Nome = "Camiseta Gamer",
                Preco = new decimal(69.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/5_100_gamer.jpg?raw=true",
                CategoriaNome = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 5,
                Nome = "Camiseta SpaceX",
                Preco = new decimal(49.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/6_spacex.jpg?raw=true",
                CategoriaNome = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 6,
                Nome = "Camiseta Feminina Coffee Benefits",
                Preco = new decimal(69.9),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/7_coffee.jpg?raw=true",
                CategoriaNome = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 7,
                Nome = "Moletom Com Capuz Cobra Kai",
                Preco = new decimal(159.9),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/8_moletom_cobra_kay.jpg?raw=true",
                CategoriaNome = "Sweatshirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 8,
                Nome = "Livro Star Talk – Neil DeGrasse Tyson",
                Preco = new decimal(49.9),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/9_neil.jpg?raw=true",
                CategoriaNome = "Book"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 9,
                Nome = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                Preco = new decimal(359.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/10_milennium_falcon.jpg?raw=true",
                CategoriaNome = "Action Figure"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 10,
                Nome = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                Preco = new decimal(59.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/11_mars.jpg?raw=true",
                CategoriaNome = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 11,
                Nome = "Camiseta GNU Linux Programador Masculina",
                Preco = new decimal(59.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/12_gnu_linux.jpg?raw=true",
                CategoriaNome = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 12,
                Nome = "Camiseta Goku Fases",
                Preco = new decimal(59.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/13_dragon_ball.jpg",
                CategoriaNome = "T-shirt"
            });
        }
    }
}
