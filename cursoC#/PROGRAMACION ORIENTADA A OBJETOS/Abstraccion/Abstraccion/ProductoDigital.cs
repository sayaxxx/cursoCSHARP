using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion
{
    internal class ProductoDigital : Producto
    {
        public double PrecioBase { get; set; }
        public int DiasLicencia { get; set; }

        public override double CalcularPrecioFinal()
        {
            double descuento = DiasLicencia >= 365 ? 0.20 : 0;
            double iva = PrecioBase * 0.19;
            return (PrecioBase + iva) * (1 - descuento);
        }
    }
}
