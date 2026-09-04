namespace BibliotecaApp.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        // Propiedad de navegación - Un país puede tener muchos autores
        public virtual ICollection<Autor> Autores { get; set; } = new List<Autor>();
    }
}
