using Microsoft.EntityFrameworkCore;
using BibliotecaApp.Models;

namespace BibliotecaApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets para cada una de las tablas del modelo normalizado
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<LibroAutor> LibroAutores { get; set; }
        public DbSet<Ejemplar> Ejemplares { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Configuración de la tabla intermedia LibroAutor (Relación M:N)
            modelBuilder.Entity<LibroAutor>()
                .HasKey(la => new { la.LibroId, la.AutorId }); // Clave primaria compuesta

            modelBuilder.Entity<LibroAutor>()
                .HasOne(la => la.Libro)
                .WithMany(l => l.LibroAutores)
                .HasForeignKey(la => la.LibroId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LibroAutor>()
                .HasOne(la => la.Autor)
                .WithMany(a => a.LibroAutores)
                .HasForeignKey(la => la.AutorId)
                .OnDelete(DeleteBehavior.Cascade);

            // 2. Relación Pais - Autores (1:N)
            modelBuilder.Entity<Autor>()
                .HasOne(a => a.Pais)
                .WithMany(p => p.Autores)
                .HasForeignKey(a => a.PaisId)
                .OnDelete(DeleteBehavior.Restrict); // Evita eliminar un país si tiene autores asociados

            // 3. Relación Libro - Ejemplares (1:N)
            modelBuilder.Entity<Ejemplar>()
                .HasOne(e => e.Libro)
                .WithMany(l => l.Ejemplares)
                .HasForeignKey(e => e.LibroId)
                .OnDelete(DeleteBehavior.Cascade);

            // 4. Relación Ejemplar - Prestamos (1:N)
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Ejemplar)
                .WithMany(e => e.Prestamos)
                .HasForeignKey(p => p.EjemplarId)
                .OnDelete(DeleteBehavior.Restrict); // Evita eliminar un ejemplar con historial de préstamos

            // 5. Relación Usuario - Prestamos (1:N)
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Prestamos)
                .HasForeignKey(p => p.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict); // Evita eliminar un usuario con préstamos registrados
        }
    }
}