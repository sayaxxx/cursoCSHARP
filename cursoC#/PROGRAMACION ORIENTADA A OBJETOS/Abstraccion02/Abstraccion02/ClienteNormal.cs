using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion02
{
    internal class ClienteNormal : Cliente
    {
        public override double CalcularDescuento(double totalCompra)
        {
            return 0;
        }

        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"{Nombre} RECIBIRÁ SU COMPRA EN TIENDA");
        }
    }
}
