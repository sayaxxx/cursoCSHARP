using System;

class Programa
{
    static void Main()
    {
        Console.Write("INGRESE TAMAÑO (P/M/G): ");
        string tamano = Console.ReadLine().ToUpper();

        switch (tamano)
        {
            case "P":
                Console.WriteLine("PEQUEÑA-5000");
                break;
            case "M":
                Console.WriteLine("MEDIANA-8000");
                break;
            case "G":
                Console.WriteLine("GRANDE-12000");
                break;
            default:
                Console.WriteLine("TAMAÑO NO DISPONIBLE");
                break;
        }
    }
}