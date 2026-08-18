using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE SU PESO (KG): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("INGRESE SU ESTATURA (M): ");
            double estatura = double.Parse(Console.ReadLine());

            double imc = peso / (estatura * estatura);

            string estado = (imc > 25) ? "RIESGO" : "SALUDABLE";

            Console.WriteLine($"IMC: {imc} == ESTADO: {estado}");
        }
    }
}