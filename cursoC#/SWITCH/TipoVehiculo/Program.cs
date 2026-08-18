using System;

class Programa
{
    static void Main()
    {
        Console.Write("TIPO DE PLACA (M/C/B): ");
        string placa = Console.ReadLine().ToUpper();

        string tipo = placa switch
        {
            "M" => "MOTO",
            "C" => "CARRO",
            "B" => "BUS",
            _ => "TIPO NO REGISTRADO"
        };

        Console.WriteLine($"VEHICULO: {tipo}");
    }
}