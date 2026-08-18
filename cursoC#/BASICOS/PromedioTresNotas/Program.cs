using System;

namespace PromedioTresNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE LA PRIMER NOTA: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("INGRESE LA SEGUNDA NOTA: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("INGRESE LA TERCER NOTA: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"EL PROMEDIO DE LAS TRES NOTAS ES: {promedio}");
        }
    }
}