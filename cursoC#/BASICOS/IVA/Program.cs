using System;

namespace IVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE EL VALOR DE LA COMPRA: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            double iva = valor * 0.19;
            Console.WriteLine($"EL IVA DE LA COMPRA ES: {iva}");
            Console.WriteLine($"EL VALOR TOTAL DE LA COMPRA ES: {valor + iva}");
        }
    }
}