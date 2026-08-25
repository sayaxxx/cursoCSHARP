using System;

namespace CRUD
{
    abstract class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");

                if (value.Trim().Length < 2)
                    throw new ArgumentException("El nombre debe tener al menos 2 caracteres.");

                nombre = value.Trim();
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 18 || value > 100)
                    throw new ArgumentException("La edad debe estar entre 18 y 100 años.");

                edad = value;
            }
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public abstract void MostrarInformacion();

        public virtual string ObtenerDescripcion()
        {
            return $"{Nombre}, {Edad} años";
        }
    }
}