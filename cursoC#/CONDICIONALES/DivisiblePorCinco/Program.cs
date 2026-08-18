using System;

namespace DivisiblePorCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE UN NUMERO: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 5 == 0)
            {
                Console.WriteLine("EL NUMERO ES DIVISIBLE POR 5");
            }
            else
            {
                Console.WriteLine("EL NUMERO NO ES DIVISIBLE POR 5");
            }
        }
    }

}