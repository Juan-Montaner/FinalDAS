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
            grpSucursales = new GroupBox();
            grpListaSucursales = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).BeginInit();
            grpSucursales.SuspendLayout();
            grpListaSucursales.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGestionProductos
            // 
            dgvGestionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionProductos.Location = new Point(16, 22);
            dgvGestionProductos.Name = "dgvGestionProductos";
            dgvGestionProductos.RowHeadersWidth = 51;
            dgvGestionProductos.Size = new Size(454, 261);
            dgvGestionProductos.TabIndex = 14;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(379, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 41);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(260, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 41);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(141, 326);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 41);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 326);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 41);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grpSucursales
            // 
            grpSucursales.Controls.Add(grpListaSucursales);
            grpSucursales.Controls.Add(btnVolver);
            grpSucursales.Controls.Add(btnAgregar);
            grpSucursales.Controls.Add(btnEliminar);
            grpSucursales.Controls.Add(btnModificar);
            grpSucursales.Location = new Point(10, -2);
            grpSucursales.Name = "grpSucursales";
            grpSucursales.Size = new Size(502, 378);
            grpSucursales.TabIndex = 15;
            grpSucursales.TabStop = false;
            grpSucursales.Text = "Sucursales";
            // 
            // grpListaSucursales
            // 
            grpListaSucursales.Controls.Add(dgvGestionProductos);
            grpListaSucursales.Location = new Point(6, 22);
            grpListaSucursales.Name = "grpListaSucursales";
            grpListaSucursales.Size = new Size(484, 298);
            grpListaSucursales.TabIndex = 15;
            grpListaSucursales.TabStop = false;
            grpListaSucursales.Text = "Lista de Sucursales";
            // 
            // FormGestionDeSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(521, 385);
            Controls.Add(grpSucursales);
            Name = "FormGestionDeSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Sucursales";
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).EndInit();
            grpSucursales.ResumeLayout(false);
            grpListaSucursales.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGestionProductos;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private GroupBox grpSucursales;
        private GroupBox grpListaSucursales;
    }
}