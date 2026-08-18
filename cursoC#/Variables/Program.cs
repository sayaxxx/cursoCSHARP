using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION DE VARIABLES
            string nombre = "Carlos";
            int edad = 25;
            double estatura = 1.75;
            bool esEstudiante = true;
            char inicial = 'C';

            // MOSTRAR VARIABLES EN PANTALLA
            Console.WriteLine("=== INFORMACION PERSONAL ===");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Estatura: " + estatura + " m");
            Console.WriteLine("Es estudiante: " + esEstudiante);
            Console.WriteLine("Inicial: " + inicial);
        }
    }
}