using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraccion02
{
    abstract class Cliente
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public abstract double CalcularDescuento(double totalCompra);
        public abstract void RecibirCompra(string detalle);
        public void MostrarDatos()
        {
            Console.WriteLine($"CLIENTE: {Nombre}");
            Console.WriteLine($"EMAIL: {Email}");
            Console.WriteLine($"TELEFONO: {Telefono}");
        }
    }
}
