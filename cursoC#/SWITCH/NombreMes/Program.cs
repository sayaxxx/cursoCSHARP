using System;

namespace NombreMes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE NUMERO DEL MES [1-12]: ");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1: Console.WriteLine("ENERO"); break;
                case 2: Console.WriteLine("FEBRERO"); break;
                case 3: Console.WriteLine("MARZO"); break;
                case 4: Console.WriteLine("ABRIL"); break;
                case 5: Console.WriteLine("MAYO"); break;
                case 6: Console.WriteLine("JUNIO"); break;
                case 7: Console.WriteLine("JULIO"); break;
                case 8: Console.WriteLine("AGOSTO"); break;
                case 9: Console.WriteLine("SEPTIEMBRE"); break;
                case 10: Console.WriteLine("OCTUBRE"); break;
                case 11: Console.WriteLine("NOVIEMBRE"); break;
                case 12: Console.WriteLine("DICIEMBRE"); break;
                default: Console.WriteLine("MES INVALIDO"); break;
            }
        }
    }
}