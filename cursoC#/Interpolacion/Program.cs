using System;

namespace Interpolacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto = "Laptop";
            double precio = 25000000;
            int cantidad = 3;
            double total = precio * cantidad;

            // FORMA ANTIGUA (usando +)
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("Precio: $" + precio);

            // FORMA MODERNA (usando interpolación de cadenas)
            Console.WriteLine($"Producto: {producto}");
            Console.WriteLine($"Precio: ${precio}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"TOTAL A PAGAR: ${total}");

            // FORMATO DE MONEDA F0 = SIN DECIMALES
            Console.WriteLine($"TOTAL FORMATEADO: ${total:F0}");
        }
    }
}