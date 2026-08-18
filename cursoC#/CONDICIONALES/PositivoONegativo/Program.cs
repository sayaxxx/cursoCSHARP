using System;

namespace PositioONegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE UN NUMERO: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine($"EL NUMERO {numero} ES POSITIVO");
            }
            else
            {
                Console.WriteLine($"EL NUMERO {numero} ES NEGATIVO");
            }
        }
    }
}