namespace Vista.Gestion_de_Productos
{
    partial class FormGestionDeSucursales
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
            dgvGestionProductos = new DataGridView();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnGestionSucursal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvGestionProductos
            // 
            dgvGestionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionProductos.Location = new Point(14, 16);
            dgvGestionProductos.Margin = new Padding(3, 4, 3, 4);
            dgvGestionProductos.Name = "dgvGestionProductos";
            dgvGestionProductos.RowHeadersWidth = 51;
            dgvGestionProductos.Size = new Size(887, 368);
            dgvGestionProductos.TabIndex = 14;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(790, 407);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 55);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(293, 407);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 48);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(153, 407);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 48);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 407);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 48);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGestionSucursal
            // 
            btnGestionSucursal.Location = new Point(18, 471);
            btnGestionSucursal.Name = "btnGestionSucursal";
            btnGestionSucursal.Size = new Size(389, 32);
            btnGestionSucursal.TabIndex = 15;
            btnGestionSucursal.Text = "Gestionar Sucursal";
            btnGestionSucursal.UseVisualStyleBackColor = true;
            btnGestionSucursal.Click += btnGestionSucursal_Click;
            // 
            // FormGestionDeSucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(914, 527);
            Controls.Add(btnGestionSucursal);
            Controls.Add(dgvGestionProductos);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionDeSucursales";
            Text = "FormGestionDeSucursales";
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGestionProductos;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnGestionSucursal;
    }
}