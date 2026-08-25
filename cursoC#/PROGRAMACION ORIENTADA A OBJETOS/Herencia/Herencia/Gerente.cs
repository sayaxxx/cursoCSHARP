using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Gerente : Empleado
    {
        private int empleadosACargo;
        public Gerente(string nom, string id, double salario, int empleados) : base (nom, id, salario)
        {
            empleadosACargo = empleados;
        }

        public override double CalcularSalario()
        {
            double bono = empleadosACargo * 50000;
            return salarioBase + bono;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"TIPO: GERENTE");
            Console.WriteLine($"EMPLEADOS A CARGO: {empleadosACargo}");
        }
    }
}
