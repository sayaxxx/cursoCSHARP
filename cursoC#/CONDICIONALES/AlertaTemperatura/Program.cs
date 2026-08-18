using System;

namespace AlertaTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE LA TEMPERATURA ACTUAL: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("¡ALERTA! LA TEMPERATURA ESTA POR DEBAJO DE 0");
            }
            else if (temperatura >= 0 && temperatura <= 20)
            {
                Console.WriteLine("LA TEMPERATURA ES BAJA");
            }
            else if (temperatura > 20 && temperatura <= 35)
            {
                Console.WriteLine("LA TEMPERATURA ES MODERADA");
            }
            else
            {
                Console.WriteLine("¡ALERTA! LA TEMPERATURA ES ALTA");
            }
        }
    }
}