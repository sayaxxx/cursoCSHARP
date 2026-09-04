namespace BibliotecaApp.Models
{
    public class Ejemplar
    {
        public int Id { get; set; }
        public string Estado { get; set; } = "Disponible"; // ej: Disponible, Prestado, En Reparación

        // Clave Foránea y Propiedad de Navegación hacia Libro
        public int LibroId { get; set; }
        public virtual Libro Libro { get; set; } = null!;

        // Propiedad de navegación - Un ejemplar puede tener historial de préstamos
        public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}
