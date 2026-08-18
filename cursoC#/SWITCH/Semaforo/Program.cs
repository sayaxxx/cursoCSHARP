using System;

class Programa
{
    static void Main()
    {
        Console.Write("INGRESE COLOR DEL SEMAFORO: ");
        string color = Console.ReadLine().ToLower();

        switch (color)
        {
            case "rojo":
                Console.WriteLine("PARAR");
                break;
            case "amarillo":
                Console.WriteLine("PRECAUCION");
                break;
            case "verde":
                Console.WriteLine("AVANZAR");
                break;
            default:
                Console.WriteLine("COLOR INVALIDO");
                break;
        }
    }
}