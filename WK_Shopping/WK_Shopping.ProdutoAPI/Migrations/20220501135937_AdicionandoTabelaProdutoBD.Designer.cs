﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WK_Shopping.ProdutoAPI.Model.Context;

#nullable disable

namespace WK_Shopping.ProdutoAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20220501135937_AdicionandoTabelaProdutoBD")]
    partial class AdicionandoTabelaProdutoBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);
#pragma warning restore 612, 618
        }
    }
}
