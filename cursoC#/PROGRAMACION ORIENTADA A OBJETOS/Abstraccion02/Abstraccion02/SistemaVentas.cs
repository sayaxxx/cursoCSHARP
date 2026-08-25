using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion02
{
    internal class SistemaVentas
    {
        public void ProcesarVentas(Cliente cliente, double totalCompra, string productos)
        {
            Console.WriteLine("\n=== PROCESANDO VENTA ===");
            cliente.MostrarDatos();

            double descuento = cliente.CalcularDescuento(totalCompra);
            double totalPagar = totalCompra - descuento;

            Console.WriteLine($"SUBTOTAL: ${totalCompra:F0}");
            Console.WriteLine($"DESCUENTO: ${descuento:F0}");
            Console.WriteLine($"TOTAL A PAGAR: ${totalPagar:F0}");

            cliente.RecibirCompra(productos);
        }
    }
}
