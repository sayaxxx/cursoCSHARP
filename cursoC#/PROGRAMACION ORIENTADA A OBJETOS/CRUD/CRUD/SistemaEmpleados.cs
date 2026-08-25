using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    internal class SistemaEmpleados
    {
        // Colección privada: Nadie puede acceder directamente a la lista
        private List<Empleado> empleados;
        private int siguienteId;

        // CONSTRUCTOR
        public SistemaEmpleados()
        {
            empleados = new List<Empleado>();
            siguienteId = 1;
        }

        // ========================================
        // OPERACIONES CRUD
        // ========================================

        // CREATE: Agregar nuevo empleado
        public bool AgregarEmpleado(string nombre, int edad, string cargo, decimal salario)
        {
            try
            {
                // Crear nuevo empleado con ID autoincrementable
                Empleado nuevoEmpleado = new Empleado(siguienteId, nombre, edad, cargo, salario);
                empleados.Add(nuevoEmpleado);
                siguienteId++;

                Console.WriteLine($"\n✅ Empleado agregado exitosamente con ID: {nuevoEmpleado.Id}\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Error al agregar empleado: {ex.Message}\n");
                return false;
            }
        }

        // READ: Mostrar todos los empleados
        public void MostrarTodosLosEmpleados()
        {
            Console.WriteLine("\n=== LISTA DE EMPLEADOS ===\n");

            if (empleados.Count == 0)
            {
                Console.WriteLine("⚠️ No hay empleados registrados en el sistema.\n");
                return;
            }

            // Usamos polimorfismo: llamamos a MostrarInformacion() de cada empleado
            foreach (Empleado empleado in empleados)
            {
                empleado.MostrarInformacion();
            }
        }

        // READ: Buscar empleado por ID
        public Empleado BuscarPorId(int id)
        {
            return empleados.Find(e => e.Id == id);
        }

        // READ: Buscar empleados por cargo (devuelve lista)
        public List<Empleado> BuscarPorCargo(string cargo)
        {
            return empleados.Where(e => e.Cargo.Equals(cargo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // UPDATE: Actualizar salario de un empleado
        public bool ActualizarSalario(int id, decimal nuevoSalario)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine($"\n❌ No se encontró empleado con ID {id}\n");
                return false;
            }

            try
            {
                empleado.Salario = nuevoSalario; // Usa la propiedad con validación
                Console.WriteLine($"\n✅ Salario actualizado exitosamente para {empleado.Nombre}\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Error al actualizar salario: {ex.Message}\n");
                return false;
            }
        }

        // DELETE: Eliminar empleado por ID
        public bool EliminarEmpleado(int id)
        {
            Empleado empleado = BuscarPorId(id);

            if (empleado == null)
            {
                Console.WriteLine($"\n❌ No se encontró empleado con ID {id}\n");
                return false;
            }

            empleados.Remove(empleado);
            Console.WriteLine($"\n✅ Empleado {empleado.Nombre} eliminado exitosamente\n");
            return true;
        }

        // ========================================
        // MÉTODOS DE NEGOCIO ADICIONALES
        // ========================================

        // Calcular nómina total de la empresa
        public decimal CalcularNominaTotal()
        {
            return empleados.Sum(e => e.Salario);
        }

        // Generar estadísticas básicas
        public void MostrarEstadisticas()
        {
            Console.WriteLine("\n=== ESTADÍSTICAS DEL SISTEMA ===\n");
            Console.WriteLine($"Total de empleados: {empleados.Count}");

            if (empleados.Count > 0)
            {
                decimal nominaTotal = CalcularNominaTotal();
                decimal salarioPromedio = nominaTotal / empleados.Count;
                Empleado mejorPagado = empleados.OrderByDescending(e => e.Salario).First();

                Console.WriteLine($"Nómina total mensual: ${nominaTotal:N2}");
                Console.WriteLine($"Salario promedio: ${salarioPromedio:N2}");
                Console.WriteLine($"Empleado mejor pagado: {mejorPagado.Nombre} (${mejorPagado.Salario:N2})");
                Console.WriteLine($"Cargos únicos: {empleados.Select(e => e.Cargo).Distinct().Count()}");
            }
            else
            {
                Console.WriteLine("⚠️ No hay datos suficientes para generar estadísticas.\n");
            }
        }
    }
}
