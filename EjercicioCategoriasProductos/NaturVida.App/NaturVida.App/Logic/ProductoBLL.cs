using System;
using System.Collections.Generic;
using System.Linq;
using NaturVida.App.Data;
using NaturVida.App.Models;

namespace NaturVida.App.Logic
{
    public class ProductoBLL
    {
        private readonly ProductoDAL dal = new();

        // Obtener la lista completa
        public List<Producto> Listar()
        {
            return dal.ObtenerTodos();
        }

        // Obtener por ID
        public Producto? ObtenerPorId(int id)
        {
            return dal.ObtenerPorId(id);
        }

        // Insertar nuevo producto
        public string Insertar(Producto prod)
        {
            string errorValidacion = ValidarProducto(prod);
            if (!string.IsNullOrEmpty(errorValidacion))
                return errorValidacion;

            try
            {
                dal.Insertar(prod);
                return "✅ Producto registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error al registrar: " + ex.Message;
            }
        }

        // Actualizar/Guardar producto existente
        public string Guardar(Producto prod)
        {
            string errorValidacion = ValidarProducto(prod);
            if (!string.IsNullOrEmpty(errorValidacion))
                return errorValidacion;

            try
            {
                dal.Actualizar(prod);
                return "✅ Producto actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error al actualizar: " + ex.Message;
            }
        }

        // Eliminar por ID
        public string Eliminar(int id)
        {
            try
            {
                dal.Eliminar(id);
                return "✅ Producto eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error al eliminar: " + ex.Message;
            }
        }

        // Método privado para centralizar reglas de negocio
        private string ValidarProducto(Producto prod)
        {
            if (string.IsNullOrWhiteSpace(prod.Nombre))
                return "⚠️ El nombre del producto es obligatorio.";

            if (prod.Nombre.Length > 100)
                return "⚠️ El nombre no puede exceder los 100 caracteres.";

            if (prod.Precio <= 0)
                return "⚠️ El precio debe ser mayor a 0.";

            if (prod.Stock < 0)
                return "⚠️ El stock no puede ser un número negativo.";

            if (prod.CategoriaId <= 0)
                return "⚠️ Debe seleccionar una categoría válida.";

            return string.Empty;
        }
    }
}