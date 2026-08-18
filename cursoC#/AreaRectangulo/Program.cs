using System;

namespace AreaRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULO DE RECTANGULO ===");
            Console.Write("INGRESE LA BASE: ");
            double baseRectangulo = double.Parse(Console.ReadLine());

            Console.Write("INGRESE LA ALTURA: ");
            double alturaRectangulo = double.Parse(Console.ReadLine());

            double area = baseRectangulo * alturaRectangulo;
            double perimetro = 2 * (baseRectangulo + alturaRectangulo);

            Console.WriteLine();
            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine($"BASE: {baseRectangulo}");
            Console.WriteLine($"ALTURA: {alturaRectangulo}");
            Console.WriteLine($"ÁREA: {area}");
            Console.WriteLine($"PERÍMETRO: {perimetro:F2} CM");
        }
    }
}