using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA BASICA ===");
            Console.Write("PRIMER NUMERO: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("SEGUNDO NUMERO: ");
            double num2 = double.Parse(Console.ReadLine());

            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine();
            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
            Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
            Console.WriteLine($"Multiplicación: {num1} × {num2} = {multiplicacion}");
            Console.WriteLine($"División: {num1} ÷ {num2} = {division:F2}");
        }
    }

}
