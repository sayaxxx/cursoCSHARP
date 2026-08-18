using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE EL RADIO DEL CIRCULO: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"EL AREA DEL CIRCULO CON RADIO {radio} ES: {area}");
        }
    }
}