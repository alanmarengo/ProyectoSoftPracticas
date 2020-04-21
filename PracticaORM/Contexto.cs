using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PracticaORM
{
    public class Contexto : DbContext
    {
        DbSet<Producto> producto;
        DbSet<Cliente> cliente;
        DbSet<Venta> venta;


        public DbSet<Cliente> Cliente { get => cliente; set => cliente = value; }
        public DbSet<Producto> Producto { get => producto; set => producto = value; }
        internal DbSet<Venta> Venta { get => venta; set => venta = value; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7H9VS1J;Database=PROYECTO;Trusted_Connection=True;");
        }


    }
}
