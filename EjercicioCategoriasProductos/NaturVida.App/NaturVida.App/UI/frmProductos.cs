using NaturVida.App.Data;
using NaturVida.App.Logic;
using NaturVida.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NaturVida.App.UI
{
    public partial class frmProductos : Form
    {
        private readonly CategoriaBLL catBll = new();
        private readonly ProductoBLL prodBll = new();
        public frmProductos()
        {
            InitializeComponent();
            dgvProductos.CellClick += dgvProductos_CellClick;
        }

        private void frmProductos_Load(object s, EventArgs e)
        {
            CargarCategorias();
            CargarGrilla();
        }

        private void CargarCategorias()
        {
            // 1. Cargar ComboBox de categorías
            var categorias = catBll.Listar();
            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "Nombre";   // Lo que ve el usuario
            cboCategoria.ValueMember = "Id";         // El valor oculto (ID)
        }

        private void CargarGrilla()
        {
            dgvProductos.DataSource = prodBll.Listar();
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["CategoriaId"].Visible = false;
            dgvProductos.Columns["Categoria"].Visible = false;
            Limpiar();
        }

        // 🔘 Evento al hacer clic en una fila del DataGridView
        private void dgvProductos_CellClick(object? s, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            var prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            lblId.Text = prod.Id.ToString();
            txtNombre.Text = prod.Nombre;
            txtPrecio.Text = prod.Precio.ToString();
            numStock.Value = prod.Stock;

            // Seleccionar la categoría correcta en el ComboBox
            cboCategoria.SelectedValue = prod.CategoriaId;
        }

        private void btnGuardar_Click(object s, EventArgs e)
        {
            // 2. Obtener ID seleccionado del ComboBox
            int idCatSeleccionada = cboCategoria.SelectedValue != null
                ? (int)cboCategoria.SelectedValue : 0;

            var prod = new Producto
            {
                Id = int.TryParse(lblId.Text, out int id) ? id : 0,
                Nombre = txtNombre.Text,
                Precio = txtPrecio.Text != "" ? decimal.Parse(txtPrecio.Text) : 0,
                Stock = (int)numStock.Value,
                CategoriaId = idCatSeleccionada
            };

            string msg = prod.Id > 0 ? prodBll.Guardar(prod) : prodBll.Insertar(prod);
            MessageBox.Show(msg);
            CargarGrilla();
        }

        private void btnEliminar_Click(object s, EventArgs e)
        {
            if (lblId.Text == "" || lblId.Text == "0") return;

            var res = MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                prodBll.Eliminar(int.Parse(lblId.Text));
                CargarGrilla();
            }
        }

        private void btnNuevo_Click(object s, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            lblId.Text = "";
            txtNombre.Clear();
            txtPrecio.Clear();
            numStock.Value = 0;
            // Resetear ComboBox al primer elemento
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
            dgvProductos.ClearSelection();
        }
    }
}