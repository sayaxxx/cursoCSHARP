using System;

namespace SaludoPersonalizado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE SU NOMBRE: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("===============");
            Console.WriteLine($"HOLA {nombre} BIENVENIDO A C#");
            Console.WriteLine("SENA - CENTRO CSET");
            Console.WriteLine("===============");
        }
    }
}
