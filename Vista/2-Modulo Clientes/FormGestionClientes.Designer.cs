namespace Vista._2_Modulo_Clientes
{
    partial class FormGestionClientes
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
            gbGestionClientes = new GroupBox();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvClientes = new DataGridView();
            gbGestionClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // gbGestionClientes
            // 
            gbGestionClientes.Controls.Add(btnVolver);
            gbGestionClientes.Controls.Add(btnEliminar);
            gbGestionClientes.Controls.Add(btnModificar);
            gbGestionClientes.Controls.Add(btnAgregar);
            gbGestionClientes.Controls.Add(dgvClientes);
            gbGestionClientes.Location = new Point(17, 19);
            gbGestionClientes.Name = "gbGestionClientes";
            gbGestionClientes.Size = new Size(917, 475);
            gbGestionClientes.TabIndex = 0;
            gbGestionClientes.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(457, 401);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(323, 402);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(176, 400);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(29, 400);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(18, 28);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(878, 345);
            dgvClientes.TabIndex = 0;
            // 
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(948, 502);
            Controls.Add(gbGestionClientes);
            Name = "FormGestionClientes";
            Text = "FormGestionClientes";
            gbGestionClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGestionClientes;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvClientes;
    }
}