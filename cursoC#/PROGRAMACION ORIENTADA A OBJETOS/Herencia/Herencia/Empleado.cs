using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Empleado
    {
        // ATRIBUTOS
        protected string nombre;
        protected string identificacion;
        protected double salarioBase;

        // CONSTRUCTOR
        public Empleado(string nom, string id, double salario)
        {
            nombre = nom;
            identificacion = id;
            salarioBase = salario;
        }

        // METODO QUE CALCULA SALARIO BASE
        public virtual double CalcularSalario()
        {
            return salarioBase;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"NOMBRE: {nombre}");
            Console.WriteLine($"ID: {identificacion}");
            Console.WriteLine($"SALARIO: ${CalcularSalario():F0}");
        }
    }
}
