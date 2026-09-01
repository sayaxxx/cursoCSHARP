using System;
using System.Collections.Generic;
using System.Linq;
using NaturVida.App.Data;
using NaturVida.App.Models;

namespace NaturVida.App.Logic
{
    public class CategoriaBLL
    {
        private readonly CategoriaDAL dal = new();

        // 1. Obtener la lista ordenada
        public List<Categoria> ObtenerCategorias()
        {
            using var db = new NaturVidaContext();
            return db.Categorias.OrderBy(c => c.Nombre).ToList();
        }

        // 2. Buscar por ID
        public Categoria ObtenerPorId(int id)
        {
            using var db = new NaturVidaContext();
            return db.Categorias.FirstOrDefault(c => c.Id == id);
        }

        // 3. Verificar si existe por nombre
        public bool ExisteNombre(string nombre)
        {
            using var db = new NaturVidaContext();
            return db.Categorias.Any(c => c.Nombre == nombre);
        }

        public List<Categoria> Listar() => dal.ObtenerTodos();

        public string Guardar(Categoria cat)
        {
            if (string.IsNullOrWhiteSpace(cat.Nombre))
                return "⚠️ El nombre es obligatorio.";

            if (cat.Nombre.Length > 50)
                return "⚠️ El nombre no puede exceder 50 caracteres.";

            try
            {
                if (cat.Id > 0) dal.Actualizar(cat);
                else dal.Insertar(cat);

                return "✅ Guardado correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                dal.Eliminar(id);
                return "✅ Eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error: " + ex.Message;
            }
        }
    }
}