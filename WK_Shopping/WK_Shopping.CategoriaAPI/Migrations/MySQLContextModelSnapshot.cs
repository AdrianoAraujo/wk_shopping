// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WK_Shopping.CategoriaAPI.Model.Context;

#nullable disable

namespace WK_Shopping.CategoriaAPI.Migrations
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

            modelBuilder.Entity("WK_Shopping.CategoriaAPI.Model.Categoria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("categoria");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Nome = "T-shirt"
                        },
                        new
                        {
                            Id = 2L,
                            Nome = "Action Figure"
                        },
                        new
                        {
                            Id = 3L,
                            Nome = "Action Figure"
                        },
                        new
                        {
                            Id = 4L,
                            Nome = "T-shirt"
                        },
                        new
                        {
                            Id = 5L,
                            Nome = "T-shirt"
                        },
                        new
                        {
                            Id = 6L,
                            Nome = "T-shirt"
                        },
                        new
                        {
                            Id = 7L,
                            Nome = "Sweatshirt"
                        },
                        new
                        {
                            Id = 8L,
                            Nome = "Book"
                        },
                        new
                        {
                            Id = 9L,
                            Nome = "Action Figure"
                        },
                        new
                        {
                            Id = 10L,
                            Nome = "T-shirt"
                        },
                        new
                        {
                            Id = 11L,
                            Nome = "T-shirt"
                        },
                        new
                        {
                            Id = 12L,
                            Nome = "T-shirt"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
