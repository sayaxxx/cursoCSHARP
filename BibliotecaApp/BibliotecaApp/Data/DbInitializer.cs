using BibliotecaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Asegurarse de que la base de datos esté creada
            context.Database.EnsureCreated();

            // 1. Si ya hay países, no volvemos a insertar (la BD ya tiene datos)
            if (context.Paises.Any())
            {
                return;
            }

            // 2. Insertar Países
            var paises = new Pais[]
            {
                new Pais { Nombre = "Colombia" },
                new Pais { Nombre = "Colombia / Argentina" },
                new Pais { Nombre = "España" },
                new Pais { Nombre = "México" }
            };
            context.Paises.AddRange(paises);
            context.SaveChanges();

            // 3. Insertar Autores
            var autores = new Autor[]
            {
                new Autor { Nombre = "Gabriel García Márquez", FechaNacimiento = new DateTime(1927, 3, 6), PaisId = paises[0].Id },
                new Autor { Nombre = "Jorge Luis Borges", FechaNacimiento = new DateTime(1899, 8, 24), PaisId = paises[1].Id },
                new Autor { Nombre = "Miguel de Cervantes", FechaNacimiento = new DateTime(1547, 9, 29), PaisId = paises[2].Id },
                new Autor { Nombre = "Juan Rulfo", FechaNacimiento = new DateTime(1917, 5, 16), PaisId = paises[3].Id }
            };
            context.Autores.AddRange(autores);
            context.SaveChanges();

            // 4. Insertar Libros
            var libros = new Libro[]
            {
                new Libro { Titulo = "Cien Años de Soledad", ISBN = "978-0307474728", AnioPublicacion = 1967 },
                new Libro { Titulo = "El Aleph", ISBN = "978-8420633114", AnioPublicacion = 1949 },
                new Libro { Titulo = "Don Quijote de la Mancha", ISBN = "978-8420412146", AnioPublicacion = 1605 },
                new Libro { Titulo = "Pedro Páramo", ISBN = "978-8437604183", AnioPublicacion = 1955 }
            };
            context.Libros.AddRange(libros);
            context.SaveChanges();

            // 5. Insertar Relación M:N (LibroAutores)
            var libroAutores = new LibroAutor[]
            {
                new LibroAutor { LibroId = libros[0].Id, AutorId = autores[0].Id },
                new LibroAutor { LibroId = libros[1].Id, AutorId = autores[1].Id },
                new LibroAutor { LibroId = libros[2].Id, AutorId = autores[2].Id },
                new LibroAutor { LibroId = libros[3].Id, AutorId = autores[3].Id }
            };
            context.LibroAutores.AddRange(libroAutores);
            context.SaveChanges();

            // 6. Insertar Ejemplares Físicos
            var ejemplares = new Ejemplar[]
            {
                new Ejemplar { LibroId = libros[0].Id, Estado = "Disponible" },
                new Ejemplar { LibroId = libros[0].Id, Estado = "Prestado" },
                new Ejemplar { LibroId = libros[1].Id, Estado = "Disponible" },
                new Ejemplar { LibroId = libros[2].Id, Estado = "Disponible" },
                new Ejemplar { LibroId = libros[3].Id, Estado = "Prestado" }
            };
            context.Ejemplares.AddRange(ejemplares);
            context.SaveChanges();

            // 7. Insertar Usuarios
            var usuarios = new Usuario[]
            {
                new Usuario { Nombre = "Carlos Mendoza", Email = "carlos.mendoza@email.com" },
                new Usuario { Nombre = "Ana María Torres", Email = "ana.torres@email.com" },
                new Usuario { Nombre = "David Gómez", Email = "david.gomez@email.com" }
            };
            context.Usuarios.AddRange(usuarios);
            context.SaveChanges();

            // 8. Insertar Préstamos
            var prestamos = new Prestamo[]
            {
                new Prestamo
                {
                    UsuarioId = usuarios[0].Id,
                    EjemplarId = ejemplares[1].Id,
                    FechaPrestamo = DateTime.Now.AddDays(-10),
                    FechaDevolucion = null
                },
                new Prestamo
                {
                    UsuarioId = usuarios[1].Id,
                    EjemplarId = ejemplares[4].Id,
                    FechaPrestamo = DateTime.Now.AddDays(-5),
                    FechaDevolucion = null
                },
                new Prestamo
                {
                    UsuarioId = usuarios[2].Id,
                    EjemplarId = ejemplares[0].Id,
                    FechaPrestamo = DateTime.Now.AddDays(-20),
                    FechaDevolucion = DateTime.Now.AddDays(-2)
                }
            };
            context.Prestamos.AddRange(prestamos);
            context.SaveChanges();
        }
    }
}