﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WK_Shopping.ProdutoAPI.Model.Context;

#nullable disable

namespace WK_Shopping.ProdutoAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WK_Shopping.ProdutoAPI.Model.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("categoria_nome");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("descricao");

                    b.Property<string>("ImagemURL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("imagem_url");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.ToTable("produto");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoriaNome = "T-shirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/2_no_internet.jpg?raw=true",
                            Nome = "Camiseta No Internet",
                            Preco = 69.9m
                        },
                        new
                        {
                            Id = 2L,
                            CategoriaNome = "Action Figure",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/3_vader.jpg?raw=true",
                            Nome = "Capacete Darth Vader Star Wars Black Series",
                            Preco = 999.99m
                        },
                        new
                        {
                            Id = 3L,
                            CategoriaNome = "Action Figure",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/4_storm_tropper.jpg?raw=true",
                            Nome = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                            Preco = 189.99m
                        },
                        new
                        {
                            Id = 4L,
                            CategoriaNome = "T-shirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/5_100_gamer.jpg?raw=true",
                            Nome = "Camiseta Gamer",
                            Preco = 69.99m
                        },
                        new
                        {
                            Id = 5L,
                            CategoriaNome = "T-shirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/6_spacex.jpg?raw=true",
                            Nome = "Camiseta SpaceX",
                            Preco = 49.99m
                        },
                        new
                        {
                            Id = 6L,
                            CategoriaNome = "T-shirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/7_coffee.jpg?raw=true",
                            Nome = "Camiseta Feminina Coffee Benefits",
                            Preco = 69.9m
                        },
                        new
                        {
                            Id = 7L,
                            CategoriaNome = "Sweatshirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/8_moletom_cobra_kay.jpg?raw=true",
                            Nome = "Moletom Com Capuz Cobra Kai",
                            Preco = 159.9m
                        },
                        new
                        {
                            Id = 8L,
                            CategoriaNome = "Book",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/9_neil.jpg?raw=true",
                            Nome = "Livro Star Talk – Neil DeGrasse Tyson",
                            Preco = 49.9m
                        },
                        new
                        {
                            Id = 9L,
                            CategoriaNome = "Action Figure",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/10_milennium_falcon.jpg?raw=true",
                            Nome = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                            Preco = 359.99m
                        },
                        new
                        {
                            Id = 10L,
                            CategoriaNome = "T-shirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/11_mars.jpg?raw=true",
                            Nome = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                            Preco = 59.99m
                        },
                        new
                        {
                            Id = 11L,
                            CategoriaNome = "T-shirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/12_gnu_linux.jpg?raw=true",
                            Nome = "Camiseta GNU Linux Programador Masculina",
                            Preco = 59.99m
                        },
                        new
                        {
                            Id = 12L,
                            CategoriaNome = "T-shirt",
                            Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImagemURL = "https://github.com/AdrianoAraujo/wk_shopping/blob/main/WK_Shopping_Imagens/13_dragon_ball.jpg",
                            Nome = "Camiseta Goku Fases",
                            Preco = 59.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
