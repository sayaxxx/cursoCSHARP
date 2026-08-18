using System;

namespace ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONVERSOR DE MONEDA ===");
            Console.Write("INGRESE LA CANTIDAD EN DÓLARES: ");
            double cantidadDolares = Convert.ToDouble(Console.ReadLine());
            double tmr = 4000;
            Console.WriteLine($"LA CANTIDAD EN PESOS COLOMBIANOS ES: {cantidadDolares * tmr}");
        }
    }
}