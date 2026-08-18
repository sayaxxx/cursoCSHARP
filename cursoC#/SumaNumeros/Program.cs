using System;

namespace SumaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE EL PRIMER NUMERO: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("INGRESE EL SEGUNDO NUMERO: ");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;

            Console.WriteLine("==================");
            Console.WriteLine($"LA SUMA DE {numero1} + {numero2} = {suma}");
            Console.WriteLine("==================");
        }
    }
}