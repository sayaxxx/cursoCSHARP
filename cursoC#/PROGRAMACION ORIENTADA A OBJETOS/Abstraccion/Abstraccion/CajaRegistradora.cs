using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion
{
    internal class CajaRegistradora
    {
        public void Cobrar(List<Producto> carrito)
        {
            Console.WriteLine("=== TICKET DE COMPRA ===");

            double total = 0;

            foreach (Producto p in carrito)
            {
                p.MostrarInfo();
                double precio = p.CalcularPrecioFinal();
                Console.WriteLine($"PRECIO FINAL: ${precio:F0}");
                total += precio;
                Console.WriteLine();
            }

            Console.WriteLine($"EL TOTAL A PAGAR ES: {total}");
        }
    }
}
