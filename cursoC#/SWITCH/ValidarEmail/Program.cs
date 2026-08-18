using System;
class Programa
{
    static void Main()
    {
        Console.Write("INGRESE EMAIL: ");
        string email = Console.ReadLine();

        switch (email)
        {
            case string e when !e.Contains("@"):
                Console.WriteLine("EMAIL DEBE CONTENER @");
                break;

            case string e when e.Length < 5:
                Console.WriteLine("EMAIL MUY CORTO");
                break;

            case string e when e.Contains("@") && e.Length >= 5:
                Console.WriteLine("EMAIL VÁLIDO");
                break;
        }
    }
}