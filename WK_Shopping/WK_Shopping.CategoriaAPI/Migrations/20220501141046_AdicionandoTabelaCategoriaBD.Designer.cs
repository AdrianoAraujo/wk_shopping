﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WK_Shopping.CategoriaAPI.Model.Context;

#nullable disable

namespace WK_Shopping.CategoriaAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20220501141046_AdicionandoTabelaCategoriaBD")]
    partial class AdicionandoTabelaCategoriaBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                });
#pragma warning restore 612, 618
        }
    }
}