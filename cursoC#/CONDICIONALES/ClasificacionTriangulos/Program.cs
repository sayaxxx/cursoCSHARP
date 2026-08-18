using System;

namespace ClasificacionTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE VALOR DEL LADO 1: ");
            int lado1 = int.Parse(Console.ReadLine());

            Console.Write("INGRESE EL VALOR DEL LADO 2: ");
            int lado2 = int.Parse(Console.ReadLine());

            Console.Write("INGRESE EL VALOR DEL LADO 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("EL TRIANGULO ES EQUILATERO");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("EL TRIANGULO ES ISOCELES");
            }
            else
            {
                Console.WriteLine("EL TRIANGULO ES ESCALENO");
            }
        }
    }
}