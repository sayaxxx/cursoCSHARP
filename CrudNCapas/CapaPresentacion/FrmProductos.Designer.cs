namespace CapaPresentacion
{
    partial class FrmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtNombre = new TextBox();
            TxtDescripcion = new TextBox();
            TxtMarca = new TextBox();
            TxtPrecio = new TextBox();
            TxtStock = new TextBox();
            BtnGuardar = new Button();
            dgvProductos = new DataGridView();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(736, 12);
            label1.Name = "label1";
            label1.Size = new Size(277, 22);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(720, 63);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(685, 98);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPCION:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(732, 132);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "MARCA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(732, 167);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 4;
            label5.Text = "PRECIO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(736, 203);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 5;
            label6.Text = "STOCK:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(809, 61);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(172, 23);
            TxtNombre.TabIndex = 6;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(809, 96);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(172, 23);
            TxtDescripcion.TabIndex = 7;
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(809, 130);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(172, 23);
            TxtMarca.TabIndex = 8;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(809, 165);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(172, 23);
            TxtPrecio.TabIndex = 9;
            // 
            // TxtStock
            // 
            TxtStock.Location = new Point(809, 201);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(172, 23);
            TxtStock.TabIndex = 10;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = Color.DeepSkyBlue;
            BtnGuardar.Location = new Point(809, 254);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(139, 35);
            BtnGuardar.TabIndex = 11;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(667, 285);
            dgvProductos.TabIndex = 12;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.DeepSkyBlue;
            BtnEditar.Location = new Point(12, 325);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(139, 35);
            BtnEditar.TabIndex = 13;
            BtnEditar.Text = "EDITAR";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.ForeColor = Color.DeepSkyBlue;
            BtnEliminar.Location = new Point(210, 325);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(139, 35);
            BtnEliminar.TabIndex = 14;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += btnEliminar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 384);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(dgvProductos);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtStock);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtMarca);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmProductos";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtNombre;
        private TextBox TxtDescripcion;
        private TextBox TxtMarca;
        private TextBox TxtPrecio;
        private TextBox TxtStock;
        private Button BtnGuardar;
        private DataGridView dgvProductos;
        private Button BtnEditar;
        private Button BtnEliminar;
    }
}
