using System;

namespace FichaAprendiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REGISTRO DE APRENDIZ SENA ===\n");

            Console.Write("NOMBRE COMPLETO: ");
            string nombre = Console.ReadLine();

            Console.Write("EDAD: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("NUMERO DE FICHA: ");
            string ficha = Console.ReadLine();

            Console.Write("PROGRAMA: ");
            string programa = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("=== FICHA REGISTRADA ===");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Ficha: {ficha}");
            Console.WriteLine($"Programa: {programa}");
            Console.WriteLine("========================");
        }
    }
}