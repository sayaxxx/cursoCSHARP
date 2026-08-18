using System;

namespace MayorEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE SU NOMBRE: ");
            string nombre = Console.ReadLine();

            Console.Write("INGRESE SU EDAD: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine($"HOLA, {nombre}. USTED ES MAYOR DE EDAD");
            }
            else
            {
                Console.WriteLine($"HOLA, {nombre}. USTED ES MENOR DE EDAD");
            }
        }
    }
}