﻿using Fiap.Api.Donation1.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation1.Data
{
    public class DataContext : DbContext
    {

        public DbSet<TipoProdutoModel> TipoProdutos { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<ProdutoModel> Produtos { get; set; }




        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TipoProdutoModel>().HasData(
                new TipoProdutoModel(1,"Celular","Descrição para celular"),
                new TipoProdutoModel(2,"TVs","Descrição para TV"),
                new TipoProdutoModel(3,"Ar-condicionado","Descrição para ar-condicionado")
            );


            modelBuilder.Entity<UsuarioModel>().HasData(
                new UsuarioModel(1,"sa@fiap.com.br","Super Admin","123456", "admin"),
                new UsuarioModel(2, "fmoreni@fiap.com.br", "Flavio Moreni", "123456", "admin"),
                new UsuarioModel(3, "emoreni@fiap.com.br", "Eduardo Moreni", "123456", "admin")
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}