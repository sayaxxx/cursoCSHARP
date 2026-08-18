using System;

namespace PresentacionPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INFORMACION PERSONAL ===");

            Console.Write("INGRESE SU NOMBRE: ");
            string nombre = Console.ReadLine();

            Console.Write("INGRESE SU EDAD: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("INGRESE SU PROGRAMA DE FORMACION: ");
            string programa = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("=== INFORMACION PERSONAL ===");
            Console.WriteLine($"NOMBRE: {nombre}");
            Console.WriteLine($"EDAD: {edad}");
            Console.WriteLine($"PROGRAMA DE FORMACION: {programa}");
        
        }
    }
}