using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion
{
    abstract class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public abstract double CalcularPrecioFinal();

        public void MostrarInfo()
        {
            Console.WriteLine($"{Codigo} - {Nombre}");
        }
    }
}
