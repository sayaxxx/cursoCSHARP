namespace BibliotecaApp.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }

        // Clave Foránea y Propiedad de Navegación hacia Pais
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; } = null!;

        // Propiedad de navegación para la relación M:N con Libros
        public virtual ICollection<LibroAutor> LibroAutores { get; set; } = new List<LibroAutor>();
    }
}
