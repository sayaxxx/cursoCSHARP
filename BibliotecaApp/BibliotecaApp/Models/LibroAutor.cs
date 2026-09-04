namespace BibliotecaApp.Models
{
    public class LibroAutor
    {
        // Claves Foráneas
        public int LibroId { get; set; }
        public virtual Libro Libro { get; set; } = null!;

        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; } = null!;
    }
}
