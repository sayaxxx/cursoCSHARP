using System;

namespace AnoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE UN AÑO: ");
            int ano = Convert.ToInt16(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine("ES BISIESTO");
            }
            else
            {
                Console.WriteLine("NO ES BISIESTO");
            }
        }
    }
}