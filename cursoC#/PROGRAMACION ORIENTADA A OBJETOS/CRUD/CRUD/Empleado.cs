using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    internal class Empleado : Persona
    {
        public int Id { get; }
        public string Cargo { get; set; }
        private decimal salario;
        public DateTime FechaContratacion { get;  }

        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El salario no puede ser negativo");
                if (value > 10000000)
                    throw new ArgumentException("El salario excede el límite permitido");
                salario = value;
            }
        }

        // CONSTRUCTOR: Inicializa todas las propiedades
        // Usa 'base' para llamar al constructor de la clase base (Persona)
        public Empleado(int id, string nombre, int edad, string cargo, decimal salario)
            : base(nombre, edad) // Llama al constructor de Persona
        {
            Id = id;
            Cargo = cargo ?? "Sin especificar";
            Salario = salario; // Usa la propiedad para aplicar validación
            FechaContratacion = DateTime.Now;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: ${Salario:N2}");
            Console.WriteLine($"Fecha de contratación: {FechaContratacion:dd/MM/yyyy}");
            Console.WriteLine($"Antigüedad: {CalcularAntiguedad()} años");
            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");
        }

        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year - FechaContratacion.Year;
        }

        public void AplicarAumento(decimal porcentaje)
        {
            if (porcentaje < 0 || porcentaje > 100)
                throw new ArgumentException("El porcentaje debe estar entre 0 y 100");

            decimal aumento = Salario * (porcentaje / 100);
            Salario += aumento;
            Console.WriteLine($"\n✅ Aumento aplicado: ${aumento:N2} ({porcentaje}%)");
            Console.WriteLine($"Nuevo salario: ${Salario:N2}\n");
        }

        public override string ToString()
        {
            return $"[ID: {Id}] {Nombre} - {Cargo} - ${Salario:N2}";
        }


    }
}
