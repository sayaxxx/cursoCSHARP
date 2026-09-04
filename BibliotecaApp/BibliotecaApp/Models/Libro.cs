namespace BibliotecaApp.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }

        // Relación M:N con Autores
        public virtual ICollection<LibroAutor> LibroAutores { get; set; } = new List<LibroAutor>();

        // Un libro (obra) puede tener varios ejemplares físicos en la biblioteca
        public virtual ICollection<Ejemplar> Ejemplares { get; set; } = new List<Ejemplar>();
    }
}

