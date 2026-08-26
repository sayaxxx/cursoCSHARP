using System;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        private NProducto negocio = new NProducto();
        private string idProducto = null;
        private bool esEditar = false;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            dgvProductos.DataSource = negocio.Listar();
        }

        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtMarca.Clear();
            TxtPrecio.Clear();
            TxtStock.Clear();
            idProducto = null;
            esEditar = false;
        }

        // BOTÓN GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (esEditar == false)
                {
                    negocio.Insertar(TxtNombre.Text, TxtDescripcion.Text, TxtMarca.Text, TxtPrecio.Text, TxtStock.Text);
                    MessageBox.Show("Producto guardado correctamente");
                }
                else
                {
                    negocio.Editar(idProducto, TxtNombre.Text, TxtDescripcion.Text, TxtMarca.Text, TxtPrecio.Text, TxtStock.Text);
                    MessageBox.Show("Producto editado correctamente");
                }

                MostrarProductos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar: " + ex.Message);
            }
        }

        // BOTÓN EDITAR
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                esEditar = true;
                idProducto = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                TxtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtDescripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                TxtMarca.Text = dgvProductos.CurrentRow.Cells["Marca"].Value.ToString();
                TxtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                TxtStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar");
            }
        }

        // BOTÓN ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    idProducto = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                    negocio.Eliminar(idProducto);
                    MessageBox.Show("Producto eliminado correctamente");
                    MostrarProductos();
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
        }
    }
}
