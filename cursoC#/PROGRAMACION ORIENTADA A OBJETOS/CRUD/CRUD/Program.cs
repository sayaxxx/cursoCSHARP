using System;
using System.Collections.Generic;

namespace CRUD
{
    internal class Program
    {
        static SistemaEmpleados sistema = new SistemaEmpleados();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                MostrarMenu();

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        AgregarEmpleado();
                        break;

                    case "2":
                        sistema.MostrarTodosLosEmpleados();
                        break;

                    case "3":
                        BuscarEmpleado();
                        break;

                    case "4":
                        BuscarPorCargo();
                        break;

                    case "5":
                        ActualizarEmpleado();
                        break;

                    case "6":
                        ActualizarSalario();
                        break;

                    case "7":
                        EliminarEmpleado();
                        break;

                    case "8":
                        AplicarAumento();
                        break;

                    case "9":
                        sistema.MostrarEstadisticas();
                        break;

                    case "0":
                        salir = true;
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine(
                            "Opción inválida. Intente nuevamente.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine(
                        "\nPresione ENTER para continuar...");

                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        // ==========================================
        // MENÚ
        // ==========================================

        static void MostrarMenu()
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine("      SISTEMA DE EMPLEADOS");
            Console.WriteLine("==================================");

            Console.WriteLine("1. Agregar empleado");
            Console.WriteLine("2. Mostrar empleados");
            Console.WriteLine("3. Buscar empleado por ID");
            Console.WriteLine("4. Buscar empleados por cargo");
            Console.WriteLine("5. Actualizar empleado");
            Console.WriteLine("6. Actualizar salario");
            Console.WriteLine("7. Eliminar empleado");
            Console.WriteLine("8. Aplicar aumento");
            Console.WriteLine("9. Mostrar estadísticas");
            Console.WriteLine("0. Salir");

            Console.WriteLine("==================================");
        }

        // ==========================================
        // CREATE
        // ==========================================

        static void AgregarEmpleado()
        {
            Console.WriteLine("===== AGREGAR EMPLEADO =====\n");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            int edad = LeerEntero("Edad: ");

            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();

            decimal salario = LeerDecimal("Salario: ");

            sistema.AgregarEmpleado(
                nombre,
                edad,
                cargo,
                salario);
        }

        // ==========================================
        // READ - BUSCAR POR ID
        // ==========================================

        static void BuscarEmpleado()
        {
            Console.WriteLine("===== BUSCAR EMPLEADO =====\n");

            int id = LeerEntero("Ingrese el ID: ");

            Empleado empleado = sistema.BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    "\nNo se encontró ningún empleado.");
                return;
            }

            empleado.MostrarInformacion();
        }

        // ==========================================
        // READ - BUSCAR POR CARGO
        // ==========================================

        static void BuscarPorCargo()
        {
            Console.WriteLine("===== BUSCAR POR CARGO =====\n");

            Console.Write("Ingrese el cargo: ");
            string cargo = Console.ReadLine();

            sistema.MostrarEmpleadosPorCargo(cargo);
        }

        // ==========================================
        // UPDATE
        // ==========================================

        static void ActualizarEmpleado()
        {
            Console.WriteLine("===== ACTUALIZAR EMPLEADO =====\n");

            int id = LeerEntero("ID del empleado: ");

            Empleado empleado = sistema.BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    "\nNo se encontró el empleado.");

                return;
            }

            Console.WriteLine("\nDatos actuales:");
            empleado.MostrarInformacion();

            Console.WriteLine("\nIngrese los nuevos datos:\n");

            Console.Write("Nuevo nombre: ");
            string nombre = Console.ReadLine();

            int edad = LeerEntero("Nueva edad: ");

            Console.Write("Nuevo cargo: ");
            string cargo = Console.ReadLine();

            decimal salario = LeerDecimal("Nuevo salario: ");

            sistema.ActualizarEmpleado(
                id,
                nombre,
                edad,
                cargo,
                salario);
        }

        // ==========================================
        // UPDATE - SALARIO
        // ==========================================

        static void ActualizarSalario()
        {
            Console.WriteLine("===== ACTUALIZAR SALARIO =====\n");

            int id = LeerEntero("ID del empleado: ");

            Empleado empleado = sistema.BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    "\nNo se encontró el empleado.");

                return;
            }

            Console.WriteLine(
                $"Empleado: {empleado.Nombre}");

            Console.WriteLine(
                $"Salario actual: ${empleado.Salario:N2}");

            decimal nuevoSalario =
                LeerDecimal("Nuevo salario: ");

            sistema.ActualizarSalario(
                id,
                nuevoSalario);
        }

        // ==========================================
        // DELETE
        // ==========================================

        static void EliminarEmpleado()
        {
            Console.WriteLine("===== ELIMINAR EMPLEADO =====\n");

            int id = LeerEntero("ID del empleado: ");

            Empleado empleado = sistema.BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    "\nNo se encontró el empleado.");

                return;
            }

            Console.WriteLine(
                $"Empleado encontrado: {empleado.Nombre}");

            Console.Write(
                "¿Está seguro de eliminarlo? (S/N): ");

            string respuesta =
                Console.ReadLine().Trim().ToUpper();

            if (respuesta == "S")
            {
                sistema.EliminarEmpleado(id);
            }
            else
            {
                Console.WriteLine(
                    "\nOperación cancelada.");
            }
        }

        // ==========================================
        // AUMENTO
        // ==========================================

        static void AplicarAumento()
        {
            Console.WriteLine("===== APLICAR AUMENTO =====\n");

            int id = LeerEntero("ID del empleado: ");

            Empleado empleado = sistema.BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    "\nNo se encontró el empleado.");

                return;
            }

            Console.WriteLine(
                $"Empleado: {empleado.Nombre}");

            Console.WriteLine(
                $"Salario actual: ${empleado.Salario:N2}");

            decimal porcentaje =
                LeerDecimal("Porcentaje de aumento: ");

            try
            {
                empleado.AplicarAumento(porcentaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"\nError: {ex.Message}");
            }
        }

        // ==========================================
        // LEER ENTERO
        // ==========================================

        static int LeerEntero(string mensaje)
        {
            int numero;

            while (true)
            {
                Console.Write(mensaje);

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }

                Console.WriteLine(
                    "Ingrese un número entero válido.");
            }
        }

        // ==========================================
        // LEER DECIMAL
        // ==========================================

        static decimal LeerDecimal(string mensaje)
        {
            decimal numero;

            while (true)
            {
                Console.Write(mensaje);

                if (decimal.TryParse(
                    Console.ReadLine(),
                    out numero))
                {
                    return numero;
                }

                Console.WriteLine(
                    "Ingrese un número decimal válido.");
            }
        }
    }
}