using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NaturVida.App.Logic;
using NaturVida.App.Models;

namespace NaturVida.App.UI
{
    public partial class frmCategorias : Form
    {
        private readonly CategoriaBLL bll = new();
        public frmCategorias()
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnNuevo.Click += btnNuevo_Click;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
        }

        private void frmCategorias_Load(object s, EventArgs e) => Cargar();

        private void Cargar()
        {
            dgvCategorias.DataSource = bll.Listar();
            dgvCategorias.Columns["Id"].Visible = false; // Ocultar ID en grilla
            Limpiar();
        }

        private void dgvCategorias_CellClick(object? s, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) return;

            var cat = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            lblId.Text = cat.Id.ToString();
            txtNombre.Text = cat.Nombre;
            chkActivo.Checked = cat.Activo;
        }

        private void btnGuardar_Click(object? s, EventArgs e)
        {
            var cat = new Categoria
            {
                Id = int.TryParse(lblId.Text, out int id) ? id : 0,
                Nombre = txtNombre.Text.Trim(),
                Activo = chkActivo.Checked
            };

            string msg = bll.Guardar(cat);
            MessageBox.Show(msg, "Resultado");
            Cargar();
        }

        private void btnEliminar_Click(object? s, EventArgs e)
        {
            if (lblId.Text == "") return;

            var res = MessageBox.Show("¿Eliminar categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string msg = bll.Eliminar(int.Parse(lblId.Text));
                MessageBox.Show(msg);
                Cargar();
            }
        }

        private void btnNuevo_Click(object? s, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            txtNombre.Clear();
            chkActivo.Checked = true;
            lblId.Text = string.Empty;
            txtNombre.Focus();
        }
    }
}
