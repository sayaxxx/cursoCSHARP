using System;

namespace CRUD
{
    internal class Empleado : Persona
    {
        public int Id { get; }
        public string Cargo { get; set; }

        private decimal salario;

        public DateTime FechaContratacion { get; }

        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El salario no puede ser negativo.");

                if (value > 10000000)
                    throw new ArgumentException("El salario excede el límite permitido.");

                salario = value;
            }
        }

        public Empleado(
            int id,
            string nombre,
            int edad,
            string cargo,
            decimal salario)
            : base(nombre, edad)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor que cero.");

            Id = id;

            Cargo = string.IsNullOrWhiteSpace(cargo)
                ? "Sin especificar"
                : cargo.Trim();

            Salario = salario;

            FechaContratacion = DateTime.Now;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("\n" + new string('=', 50));

            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: ${Salario:N2}");
            Console.WriteLine($"Fecha de contratación: {FechaContratacion:dd/MM/yyyy}");
            Console.WriteLine($"Antigüedad: {CalcularAntiguedad()} años");

            Console.WriteLine(new string('=', 50));
        }

        public int CalcularAntiguedad()
        {
            DateTime hoy = DateTime.Now;

            int antiguedad = hoy.Year - FechaContratacion.Year;

            if (hoy < FechaContratacion.AddYears(antiguedad))
            {
                antiguedad--;
            }

            return antiguedad;
        }

        public void AplicarAumento(decimal porcentaje)
        {
            if (porcentaje < 0 || porcentaje > 100)
                throw new ArgumentException(
                    "El porcentaje debe estar entre 0 y 100.");

            decimal aumento = Salario * (porcentaje / 100);

            Salario += aumento;

            Console.WriteLine(
                $"\nAumento aplicado: ${aumento:N2} ({porcentaje}%)");

            Console.WriteLine(
                $"Nuevo salario: ${Salario:N2}");
        }

        public override string ToString()
        {
            return $"[ID: {Id}] {Nombre} - {Cargo} - ${Salario:N2}";
        }
    }
}