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
            btnAgregar.Location = new Point(21, 431);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 36);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(143, 431);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 36);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(265, 431);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(700, 431);
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
            dgvGestionProductos.Size = new Size(776, 321);
            dgvGestionProductos.TabIndex = 4;
            // 
            // grpListaProductos
            // 
            grpListaProductos.Controls.Add(dgvGestionProductos);
            grpListaProductos.Location = new Point(15, 22);
            grpListaProductos.Name = "grpListaProductos";
            grpListaProductos.Size = new Size(791, 361);
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
            grpProductos.Location = new Point(5, 2);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(815, 486);
            grpProductos.TabIndex = 6;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // FormGestionDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(827, 500);
            Controls.Add(grpProductos);
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