namespace BibliotecaApp.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;
        public DateTime? FechaDevolucion { get; set; } // Nulable si aún no se ha devuelto

        // Clave Foránea y Propiedad de Navegación hacia Ejemplar
        public int EjemplarId { get; set; }
        public virtual Ejemplar Ejemplar { get; set; } = null!;

        // Clave Foránea y Propiedad de Navegación hacia Usuario
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; } = null!;
    }
}
