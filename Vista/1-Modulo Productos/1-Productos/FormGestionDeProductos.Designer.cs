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
            groupBox1 = new GroupBox();
            btnFiltrarSucursal = new Button();
            cmbSucursales = new ComboBox();
            grpFiltrarCategoria = new GroupBox();
            btnFiltrarCategoria = new Button();
            cmbCategorias = new ComboBox();
            btnDesfiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).BeginInit();
            grpListaProductos.SuspendLayout();
            grpProductos.SuspendLayout();
            groupBox1.SuspendLayout();
            grpFiltrarCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(21, 399);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 36);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(127, 399);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 36);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(233, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(674, 439);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 41);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvGestionProductos
            // 
            dgvGestionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionProductos.Location = new Point(6, 21);
            dgvGestionProductos.Name = "dgvGestionProductos";
            dgvGestionProductos.RowHeadersWidth = 51;
            dgvGestionProductos.Size = new Size(737, 321);
            dgvGestionProductos.TabIndex = 4;
            // 
            // grpListaProductos
            // 
            grpListaProductos.Controls.Add(dgvGestionProductos);
            grpListaProductos.Location = new Point(15, 22);
            grpListaProductos.Name = "grpListaProductos";
            grpListaProductos.Size = new Size(756, 361);
            grpListaProductos.TabIndex = 5;
            grpListaProductos.TabStop = false;
            grpListaProductos.Text = "Lista De Productos";
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(btnDesfiltrar);
            grpProductos.Controls.Add(groupBox1);
            grpProductos.Controls.Add(grpFiltrarCategoria);
            grpProductos.Controls.Add(grpListaProductos);
            grpProductos.Controls.Add(btnAgregar);
            grpProductos.Controls.Add(btnModificar);
            grpProductos.Controls.Add(btnVolver);
            grpProductos.Controls.Add(btnEliminar);
            grpProductos.Location = new Point(5, 2);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(779, 488);
            grpProductos.TabIndex = 6;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrarSucursal);
            groupBox1.Controls.Add(cmbSucursales);
            groupBox1.Location = new Point(500, 386);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 94);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por Sucursal";
            // 
            // btnFiltrarSucursal
            // 
            btnFiltrarSucursal.Location = new Point(82, 55);
            btnFiltrarSucursal.Name = "btnFiltrarSucursal";
            btnFiltrarSucursal.Size = new Size(56, 24);
            btnFiltrarSucursal.TabIndex = 7;
            btnFiltrarSucursal.Text = "Filtrar";
            btnFiltrarSucursal.UseVisualStyleBackColor = true;
            btnFiltrarSucursal.Click += btnFiltrarSucursal_Click;
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(17, 26);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(121, 23);
            cmbSucursales.TabIndex = 0;
            // 
            // grpFiltrarCategoria
            // 
            grpFiltrarCategoria.Controls.Add(btnFiltrarCategoria);
            grpFiltrarCategoria.Controls.Add(cmbCategorias);
            grpFiltrarCategoria.Location = new Point(339, 386);
            grpFiltrarCategoria.Name = "grpFiltrarCategoria";
            grpFiltrarCategoria.Size = new Size(155, 94);
            grpFiltrarCategoria.TabIndex = 6;
            grpFiltrarCategoria.TabStop = false;
            grpFiltrarCategoria.Text = "Filtrar Por Categoria";
            // 
            // btnFiltrarCategoria
            // 
            btnFiltrarCategoria.Location = new Point(82, 55);
            btnFiltrarCategoria.Name = "btnFiltrarCategoria";
            btnFiltrarCategoria.Size = new Size(56, 24);
            btnFiltrarCategoria.TabIndex = 7;
            btnFiltrarCategoria.Text = "Filtrar";
            btnFiltrarCategoria.UseVisualStyleBackColor = true;
            btnFiltrarCategoria.Click += btnFiltrarCategoria_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(17, 26);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 23);
            cmbCategorias.TabIndex = 0;
            // 
            // btnDesfiltrar
            // 
            btnDesfiltrar.Location = new Point(671, 397);
            btnDesfiltrar.Name = "btnDesfiltrar";
            btnDesfiltrar.Size = new Size(100, 36);
            btnDesfiltrar.TabIndex = 9;
            btnDesfiltrar.Text = "Refrescar Lista";
            btnDesfiltrar.UseVisualStyleBackColor = true;
            btnDesfiltrar.Click += btnDesfiltrar_Click;
            // 
            // FormGestionDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(794, 498);
            Controls.Add(grpProductos);
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
    }
}