using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion
{
    internal class Servicio : Producto
    {
        public double ValorHora { get; set; }
        public int Horas { get; set; }
        public override double CalcularPrecioFinal()
        {
            double subtotal = ValorHora * Horas;
            double iva = subtotal * 0.19;
            return subtotal + iva;
        }
    }
}
