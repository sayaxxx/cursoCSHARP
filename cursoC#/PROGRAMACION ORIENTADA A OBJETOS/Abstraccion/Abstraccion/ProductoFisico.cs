using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion
{
    internal class ProductoFisico : Producto
    {
        public double PrecioBase { get; set; }
        public double Peso { get; set; }

        public override double CalcularPrecioFinal()
        {
            double envio = Peso * 1000;
            double iva = PrecioBase * 0.19;
            return PrecioBase + envio + iva;
        }
    }
}
