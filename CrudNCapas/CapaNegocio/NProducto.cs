using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class NProducto
    {
        private DProducto datos = new DProducto();

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Insertar(string nombre, string descripcion, string marca, string precio, string stock)
        {
            datos.Insertar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void Editar(string id, string nombre, string descripcion, string marca, string precio, string stock)
        {
            datos.Editar(Convert.ToInt32(id), nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void Eliminar(string id)
        {
            datos.Eliminar(Convert.ToInt32(id));
        }
    }
}

