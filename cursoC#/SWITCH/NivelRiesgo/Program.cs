using System;

class Programa
{
    static void Main()
    {
        Console.Write("PUNTUACION DE RIESGO [1-10]: ");
        int riesgo = int.Parse(Console.ReadLine());

        string nivel = riesgo switch
        {
            >= 1 and <= 3 => "RIESGO BAJO",
            >= 4 and <= 7 => "RIESGO MEDIO",
            >= 8 and <= 10 => "RIESGO ALTO",
            _ => "PUNTUACION INVALIDA"
        };

        Console.WriteLine($"NIVEL: {nivel}");
    }
}