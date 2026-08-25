using System;

namespace Abstraccion02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new ClienteNormal
            {
                Nombre = "Juan Perez",
                Email = "juan@email.com",
                Telefono = "300-1234567"
            };

            Cliente c2 = new ClienteFrecuente
            {
                Nombre = "María Gómez",
                Email = "maria@email.com",
                Telefono = "301-2345678",
                PuntosAcumulados = 500
            };

            Cliente c3 = new ClienteVIP
            {
                Nombre = "Carlos Rodríguez",
                Email = "carlos@email.com",
                Telefono = "310-3456789",
                AsesorPersonal = "Ana López"
            };

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(c1);
            clientes.Add(c2);
            clientes.Add(c3);

            SistemaVentas ventas = new SistemaVentas();

            foreach (Cliente cliente in clientes)
            {
                ventas.ProcesarVentas(cliente, 500000, "3 PRODUCTOS");
            }

        }
    }
}