using System;
namespace Herencia
{
    class Program
    {
        public static void Main(string[] args)
        {
            Desarrollador dev = new Desarrollador("Ana", "D001", 3000000, "C#", 5);

            Gerente gerente = new Gerente("Carlos", "G001", 5000000, 10);

            Console.WriteLine("=== DESARROLLADOR ===");
            dev.MostrarInfo();

            Console.WriteLine("\n=== GERENTE ===");
            gerente.MostrarInfo();
        }
    }
}
