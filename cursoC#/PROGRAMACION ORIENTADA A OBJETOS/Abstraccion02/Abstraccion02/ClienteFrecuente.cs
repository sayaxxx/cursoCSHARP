using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion02
{
    internal class ClienteFrecuente : Cliente
    {
        public int PuntosAcumulados {  get; set; }
        public override double CalcularDescuento(double totalCompra)
        {
            return totalCompra * 0.10;
        }

        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"{Nombre} RECIBIRA SU COMPRA EN SU DOMICILIO GRATIS!!");
            PuntosAcumulados += 100;
            Console.WriteLine($"PUNTOS ACUMULADOS: {PuntosAcumulados}");
        }
    }
}
    