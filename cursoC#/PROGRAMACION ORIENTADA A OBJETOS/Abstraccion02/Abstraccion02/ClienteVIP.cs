using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion02
{
    internal class ClienteVIP : Cliente
    {
        public string AsesorPersonal { get ; set; }

        public override double CalcularDescuento(double totalCompra)
        {
            return totalCompra * 0.20;
        }
        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"{Nombre} RECIBIRÁ SU COMPRA CON ENTREGA PRIORITARIA");
            Console.WriteLine($"ASESOR: {AsesorPersonal}");
            Console.WriteLine($"DETALLE: {detalle}");
        }
    }
}
