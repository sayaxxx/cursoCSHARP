using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    internal class SistemaEmpleados
    {
        private List<Empleado> empleados;
        private int siguienteId;

        public SistemaEmpleados()
        {
            empleados = new List<Empleado>();
            siguienteId = 1;
        }

        // ==========================================
        // CREATE
        // ==========================================

        public bool AgregarEmpleado(
            string nombre,
            int edad,
            string cargo,
            decimal salario)
        {
            try
            {
                Empleado nuevoEmpleado = new Empleado(
                    siguienteId,
                    nombre,
                    edad,
                    cargo,
                    salario);

                empleados.Add(nuevoEmpleado);

                siguienteId++;

                Console.WriteLine(
                    $"\nEmpleado agregado exitosamente. ID: {nuevoEmpleado.Id}");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"\nError al agregar empleado: {ex.Message}");

                return false;
            }
        }

        // ==========================================
        // READ - MOSTRAR TODOS
        // ==========================================

        public void MostrarTodosLosEmpleados()
        {
            Console.WriteLine("\n===== LISTA DE EMPLEADOS =====");

            if (empleados.Count == 0)
            {
                Console.WriteLine("\nNo hay empleados registrados.");
                return;
            }

            foreach (Empleado empleado in empleados)
            {
                empleado.MostrarInformacion();
            }
        }

        // ==========================================
        // READ - BUSCAR POR ID
        // ==========================================

        public Empleado BuscarPorId(int id)
        {
            return empleados.Find(e => e.Id == id);
        }

        // ==========================================
        // READ - BUSCAR POR CARGO
        // ==========================================

        public List<Empleado> BuscarPorCargo(string cargo)
        {
            if (string.IsNullOrWhiteSpace(cargo))
                return new List<Empleado>();

            return empleados
                .Where(e => e.Cargo.Equals(
                    cargo.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // ==========================================
        // UPDATE - ACTUALIZAR EMPLEADO
        // ==========================================

        public bool ActualizarEmpleado(
            int id,
            string nombre,
            int edad,
            string cargo,
            decimal nuevoSalario)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    $"\nNo se encontró un empleado con ID {id}.");

                return false;
            }

            try
            {
                empleado.Nombre = nombre;
                empleado.Edad = edad;

                empleado.Cargo = string.IsNullOrWhiteSpace(cargo)
                    ? "Sin especificar"
                    : cargo.Trim();

                empleado.Salario = nuevoSalario;

                Console.WriteLine(
                    "\nEmpleado actualizado exitosamente.");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"\nError al actualizar empleado: {ex.Message}");

                return false;
            }
        }

        // ==========================================
        // UPDATE - ACTUALIZAR SOLO SALARIO
        // ==========================================

        public bool ActualizarSalario(int id, decimal nuevoSalario)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    $"\nNo se encontró empleado con ID {id}.");

                return false;
            }

            try
            {
                empleado.Salario = nuevoSalario;

                Console.WriteLine(
                    $"\nSalario actualizado exitosamente.");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"\nError al actualizar salario: {ex.Message}");

                return false;
            }
        }

        // ==========================================
        // DELETE
        // ==========================================

        public bool EliminarEmpleado(int id)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine(
                    $"\nNo se encontró empleado con ID {id}.");

                return false;
            }

            empleados.Remove(empleado);

            Console.WriteLine(
                $"\nEmpleado {empleado.Nombre} eliminado exitosamente.");

            return true;
        }

        // ==========================================
        // MÉTODOS ADICIONALES
        // ==========================================

        public decimal CalcularNominaTotal()
        {
            return empleados.Sum(e => e.Salario);
        }

        public void MostrarEstadisticas()
        {
            Console.WriteLine("\n===== ESTADÍSTICAS DEL SISTEMA =====");

            Console.WriteLine(
                $"Total de empleados: {empleados.Count}");

            if (empleados.Count == 0)
            {
                Console.WriteLine(
                    "\nNo hay datos suficientes para generar estadísticas.");

                return;
            }

            decimal nominaTotal = CalcularNominaTotal();

            decimal salarioPromedio =
                nominaTotal / empleados.Count;

            Empleado mejorPagado =
                empleados
                .OrderByDescending(e => e.Salario)
                .First();

            int cargosUnicos =
                empleados
                .Select(e => e.Cargo)
                .Distinct()
                .Count();

            Console.WriteLine(
                $"Nómina total mensual: ${nominaTotal:N2}");

            Console.WriteLine(
                $"Salario promedio: ${salarioPromedio:N2}");

            Console.WriteLine(
                $"Empleado mejor pagado: {mejorPagado.Nombre}");

            Console.WriteLine(
                $"Salario del mejor pagado: ${mejorPagado.Salario:N2}");

            Console.WriteLine(
                $"Cantidad de cargos diferentes: {cargosUnicos}");
        }

        public void MostrarEmpleadosPorCargo(string cargo)
        {
            List<Empleado> resultados = BuscarPorCargo(cargo);

            Console.WriteLine(
                $"\n===== EMPLEADOS DEL CARGO: {cargo} =====");

            if (resultados.Count == 0)
            {
                Console.WriteLine(
                    "No se encontraron empleados con ese cargo.");

                return;
            }

            foreach (Empleado empleado in resultados)
            {
                Console.WriteLine(empleado);
            }
        }
    }
}