using System;

namespace EdadFutura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE SU AÑO DE NACIMIENTO: ");
            int edadActual = Convert.ToInt32(Console.ReadLine());

            int edadFutura = 2050 - edadActual;
            Console.WriteLine($"EN EL AÑO {2050}, TENDRAS {edadFutura} AÑOS.");
        }
    }
}