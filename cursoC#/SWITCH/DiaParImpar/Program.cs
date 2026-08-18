using System;
class Programa
{
    static void Main()
    {
        Console.Write("INGRESE UN NUMERO: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case int n when n % 2 == 0:
                Console.WriteLine("EL NUMERO ES PAR");
                break;

            case int n when n % 2 != 0:
                Console.WriteLine("EL NUMERO ES IMPAR");
                break;
        }
    }
}