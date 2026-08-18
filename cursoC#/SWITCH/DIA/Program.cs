using System;

class Programa
{
    static void Main()
    {
        Console.Write("DIA [1-7]: ");
        int dia = int.Parse(Console.ReadLine());

        string categoria = dia switch
        {
            1 or 3 or 5 => "DIA IMPAR - REUNION DE EQUIPO",
            2 or 4 => "DIA PAR - TRABAJO INDIVIDUAL",
            6 or 7 => "FIN DE SEMANA - DESCANSO",
            _ => "DIA INVALIDO"
        };

        Console.WriteLine(categoria);
    }
}