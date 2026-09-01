using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.App.Models
{
    public class Categoria
    {
        // EF Core reconoce automáticamente propiedades llamadas 'Id'
        // como la llave primaria (Primary Key) de la tabla.
        public int Id { get; set; }

        // Esta propiedad se convertirá en una columna NVARCHAR
        public string Nombre { get; set; } = string.Empty;

        // Esta propiedad será una columna BIT (true/false)
        public bool Activo { get; set; } = true;
    }
}

