using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Desarrollador : Empleado
    {
        private string lenguajePrincipal;
        private int proyectosCompletados;

        public Desarrollador(string nom, string id, double salario, string lenguaje, int proyectos) : base(nom, id, salario)
        {
            lenguajePrincipal = lenguaje;
            proyectosCompletados = proyectos;
        }

        public override double CalcularSalario()
        {
            double bono = proyectosCompletados * 100000;
            return salarioBase + bono;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo(); // LLAMA AL METODO DE LA CLASE BASE (EMPLEADO)
            Console.WriteLine($"TIPO: DESARROLLADOR");
            Console.WriteLine($"LENGUAJE: {lenguajePrincipal}");
            Console.WriteLine($"PROYECTOS: {proyectosCompletados}");
        }
    }
}
