﻿// <auto-generated />
using Fiap.Api.Donation1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Api.Donation1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231003223937_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Api.Donation1.Models.TipoProdutoModel", b =>
                {
                    b.Property<int>("TipoProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoProdutoId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("TipoProdutoId");

                    b.ToTable("TipoProduto");

                    b.HasData(
                        new
                        {
                            TipoProdutoId = 1,
                            Descricao = "Descrição para celular",
                            Nome = "Celular"
                        },
                        new
                        {
                            TipoProdutoId = 2,
                            Descricao = "Descrição para TV",
                            Nome = "TVs"
                        },
                        new
                        {
                            TipoProdutoId = 3,
                            Descricao = "Descrição para ar-condicionado",
                            Nome = "Ar-condicionado"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}