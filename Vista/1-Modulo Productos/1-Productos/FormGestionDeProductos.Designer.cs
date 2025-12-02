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
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).BeginInit();
            grpListaProductos.SuspendLayout();
            grpProductos.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(24, 575);
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
            btnModificar.Location = new Point(163, 575);
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
            btnEliminar.Location = new Point(303, 575);
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
            btnVolver.Location = new Point(800, 575);
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
            dgvGestionProductos.Size = new Size(887, 428);
            dgvGestionProductos.TabIndex = 4;
            // 
            // grpListaProductos
            // 
            grpListaProductos.Controls.Add(dgvGestionProductos);
            grpListaProductos.Location = new Point(17, 29);
            grpListaProductos.Margin = new Padding(3, 4, 3, 4);
            grpListaProductos.Name = "grpListaProductos";
            grpListaProductos.Padding = new Padding(3, 4, 3, 4);
            grpListaProductos.Size = new Size(904, 481);
            grpListaProductos.TabIndex = 5;
            grpListaProductos.TabStop = false;
            grpListaProductos.Text = "Lista De Productos";
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(grpListaProductos);
            grpProductos.Controls.Add(btnAgregar);
            grpProductos.Controls.Add(btnModificar);
            grpProductos.Controls.Add(btnVolver);
            grpProductos.Controls.Add(btnEliminar);
            grpProductos.Location = new Point(6, 3);
            grpProductos.Margin = new Padding(3, 4, 3, 4);
            grpProductos.Name = "grpProductos";
            grpProductos.Padding = new Padding(3, 4, 3, 4);
            grpProductos.Size = new Size(931, 648);
            grpProductos.TabIndex = 6;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // FormGestionDeProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(945, 667);
            Controls.Add(grpProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionDeProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestionDeProductos";
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).EndInit();
            grpListaProductos.ResumeLayout(false);
            grpProductos.ResumeLayout(false);
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
    }
}