namespace NaturVida.App.UI
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnProductos = new Button();
            btnCategorias = new Button();
            lblTitulo = new Label();
            panelContenido = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(10, 10);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 430);
            panelMenu.TabIndex = 0;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Silver;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Location = new Point(0, 82);
            btnProductos.Margin = new Padding(5);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(220, 45);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.Silver;
            btnCategorias.Dock = DockStyle.Top;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Location = new Point(0, 37);
            btnCategorias.Margin = new Padding(5);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(220, 45);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "NaturVida";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(243, 244, 246);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(230, 10);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(560, 430);
            panelContenido.TabIndex = 1;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Name = "frmMenu";
            Padding = new Padding(10);
            Text = "frmMenu";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContenido;
        private Button btnCategorias;
        private Label lblTitulo;
        private Button btnProductos;
    }
}