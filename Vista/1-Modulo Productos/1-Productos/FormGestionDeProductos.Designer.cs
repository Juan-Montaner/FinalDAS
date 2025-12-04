namespace Vista.Gestion_de_Productos
{
    partial class FormGestionDeProductos
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            dgvGestionProductos = new DataGridView();
            grpListaProductos = new GroupBox();
            grpProductos = new GroupBox();
            btnCantidadVendida = new Button();
            btnMasVendidos = new Button();
            btnDesfiltrar = new Button();
            groupBox1 = new GroupBox();
            btnFiltrarSucursal = new Button();
            cmbSucursales = new ComboBox();
            grpFiltrarCategoria = new GroupBox();
            btnFiltrarCategoria = new Button();
            cmbCategorias = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).BeginInit();
            grpListaProductos.SuspendLayout();
            grpProductos.SuspendLayout();
            groupBox1.SuspendLayout();
            grpFiltrarCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(17, 532);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 48);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(145, 532);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 48);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(266, 532);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 48);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(770, 585);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 55);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvGestionProductos
            // 
            dgvGestionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionProductos.Location = new Point(7, 28);
            dgvGestionProductos.Margin = new Padding(3, 4, 3, 4);
            dgvGestionProductos.Name = "dgvGestionProductos";
            dgvGestionProductos.RowHeadersWidth = 51;
            dgvGestionProductos.Size = new Size(842, 428);
            dgvGestionProductos.TabIndex = 4;
            // 
            // grpListaProductos
            // 
            grpListaProductos.Controls.Add(dgvGestionProductos);
            grpListaProductos.Location = new Point(17, 29);
            grpListaProductos.Margin = new Padding(3, 4, 3, 4);
            grpListaProductos.Name = "grpListaProductos";
            grpListaProductos.Padding = new Padding(3, 4, 3, 4);
            grpListaProductos.Size = new Size(864, 481);
            grpListaProductos.TabIndex = 5;
            grpListaProductos.TabStop = false;
            grpListaProductos.Text = "Lista De Productos";
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(btnCantidadVendida);
            grpProductos.Controls.Add(btnMasVendidos);
            grpProductos.Controls.Add(btnDesfiltrar);
            grpProductos.Controls.Add(groupBox1);
            grpProductos.Controls.Add(grpFiltrarCategoria);
            grpProductos.Controls.Add(grpListaProductos);
            grpProductos.Controls.Add(btnAgregar);
            grpProductos.Controls.Add(btnModificar);
            grpProductos.Controls.Add(btnVolver);
            grpProductos.Controls.Add(btnEliminar);
            grpProductos.Location = new Point(6, 3);
            grpProductos.Margin = new Padding(3, 4, 3, 4);
            grpProductos.Name = "grpProductos";
            grpProductos.Padding = new Padding(3, 4, 3, 4);
            grpProductos.Size = new Size(890, 651);
            grpProductos.TabIndex = 6;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // btnCantidadVendida
            // 
            btnCantidadVendida.Location = new Point(258, 588);
            btnCantidadVendida.Name = "btnCantidadVendida";
            btnCantidadVendida.Size = new Size(123, 52);
            btnCantidadVendida.TabIndex = 11;
            btnCantidadVendida.Text = "Cantidad Vendida";
            btnCantidadVendida.UseVisualStyleBackColor = true;
            btnCantidadVendida.Click += btnCantidadVendida_Click;
            // 
            // btnMasVendidos
            // 
            btnMasVendidos.Location = new Point(17, 588);
            btnMasVendidos.Name = "btnMasVendidos";
            btnMasVendidos.Size = new Size(235, 52);
            btnMasVendidos.TabIndex = 10;
            btnMasVendidos.Text = "Productos mas vendidos";
            btnMasVendidos.UseVisualStyleBackColor = true;
            btnMasVendidos.Click += btnMasVendidos_Click;
            // 
            // btnDesfiltrar
            // 
            btnDesfiltrar.Location = new Point(767, 529);
            btnDesfiltrar.Margin = new Padding(3, 4, 3, 4);
            btnDesfiltrar.Name = "btnDesfiltrar";
            btnDesfiltrar.Size = new Size(114, 48);
            btnDesfiltrar.TabIndex = 9;
            btnDesfiltrar.Text = "Refrescar Lista";
            btnDesfiltrar.UseVisualStyleBackColor = true;
            btnDesfiltrar.Click += btnDesfiltrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrarSucursal);
            groupBox1.Controls.Add(cmbSucursales);
            groupBox1.Location = new Point(571, 515);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(177, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por Sucursal";
            // 
            // btnFiltrarSucursal
            // 
            btnFiltrarSucursal.Location = new Point(94, 73);
            btnFiltrarSucursal.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarSucursal.Name = "btnFiltrarSucursal";
            btnFiltrarSucursal.Size = new Size(64, 32);
            btnFiltrarSucursal.TabIndex = 7;
            btnFiltrarSucursal.Text = "Filtrar";
            btnFiltrarSucursal.UseVisualStyleBackColor = true;
            btnFiltrarSucursal.Click += btnFiltrarSucursal_Click;
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(19, 35);
            cmbSucursales.Margin = new Padding(3, 4, 3, 4);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(138, 28);
            cmbSucursales.TabIndex = 0;
            // 
            // grpFiltrarCategoria
            // 
            grpFiltrarCategoria.Controls.Add(btnFiltrarCategoria);
            grpFiltrarCategoria.Controls.Add(cmbCategorias);
            grpFiltrarCategoria.Location = new Point(387, 515);
            grpFiltrarCategoria.Margin = new Padding(3, 4, 3, 4);
            grpFiltrarCategoria.Name = "grpFiltrarCategoria";
            grpFiltrarCategoria.Padding = new Padding(3, 4, 3, 4);
            grpFiltrarCategoria.Size = new Size(177, 125);
            grpFiltrarCategoria.TabIndex = 6;
            grpFiltrarCategoria.TabStop = false;
            grpFiltrarCategoria.Text = "Filtrar Por Categoria";
            // 
            // btnFiltrarCategoria
            // 
            btnFiltrarCategoria.Location = new Point(94, 73);
            btnFiltrarCategoria.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarCategoria.Name = "btnFiltrarCategoria";
            btnFiltrarCategoria.Size = new Size(64, 32);
            btnFiltrarCategoria.TabIndex = 7;
            btnFiltrarCategoria.Text = "Filtrar";
            btnFiltrarCategoria.UseVisualStyleBackColor = true;
            btnFiltrarCategoria.Click += btnFiltrarCategoria_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(19, 35);
            cmbCategorias.Margin = new Padding(3, 4, 3, 4);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(138, 28);
            cmbCategorias.TabIndex = 0;
            // 
            // FormGestionDeProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(907, 664);
            Controls.Add(grpProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionDeProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestionDeProductos";
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).EndInit();
            grpListaProductos.ResumeLayout(false);
            grpProductos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grpFiltrarCategoria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVolver;
        private DataGridView dgvGestionProductos;
        private GroupBox grpListaProductos;
        private GroupBox grpProductos;
        private GroupBox grpFiltrarCategoria;
        private ComboBox cmbCategorias;
        private Button btnFiltrarCategoria;
        private GroupBox groupBox1;
        private Button btnFiltrarSucursal;
        private ComboBox cmbSucursales;
        private Button btnDesfiltrar;
        private Button btnMasVendidos;
        private Button btnCantidadVendida;
    }
}