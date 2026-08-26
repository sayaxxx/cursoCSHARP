using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DProducto
    {
        private string cadenaConexion =
            "Server=(localdb)\\MSSQLLocalDB;Database=Practica;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security =True";

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT Id, Nombre, Descripcion, Marca, Precio, Stock FROM Productos";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public void Insertar(string nombre, string descripcion, string marca, double precio, int stock)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "INSERT INTO Productos (Nombre, Descripcion, Marca, Precio, Stock) VALUES (@nombre, @descripcion, @marca, @precio, @stock)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@stock", stock);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Editar(int id, string nombre, string descripcion, string marca, double precio, int stock)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "UPDATE Productos SET Nombre=@nombre, Descripcion=@descripcion, Marca=@marca, Precio=@precio, Stock=@stock WHERE Id=@id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@stock", stock);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "DELETE FROM Productos WHERE Id=@id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
