using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NaturVida.App.Models;

namespace NaturVida.App.Data
{
    // El Contexto debe heredar de la clase base DbContext de EF Core
    public class NaturVidaContext : DbContext
    {
        // DbSet representa una tabla completa en la base de datos.
        // 'Categorias' será el nombre de la tabla en SQL Server.
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }

        // Aquí configuramos la conexión a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Indicamos que usaremos SQL Server y le damos la cadena de conexión
            // (localdb)\mssqllocaldb es la base de datos ligera que viene con Visual Studio
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NaturVidaDB;Trusted_Connection=true;");
        }


    }
}
