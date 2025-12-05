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
            grpListaDeClientes = new GroupBox();
            dgvClientes = new DataGridView();
            btnSaldo = new Button();
            btnHistorial = new Button();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            gbGestionClientes.SuspendLayout();
            grpListaDeClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // gbGestionClientes
            // 
            gbGestionClientes.Controls.Add(grpListaDeClientes);
            gbGestionClientes.Controls.Add(btnSaldo);
            gbGestionClientes.Controls.Add(btnHistorial);
            gbGestionClientes.Controls.Add(btnVolver);
            gbGestionClientes.Controls.Add(btnEliminar);
            gbGestionClientes.Controls.Add(btnModificar);
            gbGestionClientes.Controls.Add(btnAgregar);
            gbGestionClientes.Location = new Point(4, -2);
            gbGestionClientes.Margin = new Padding(3, 2, 3, 2);
            gbGestionClientes.Name = "gbGestionClientes";
            gbGestionClientes.Padding = new Padding(3, 2, 3, 2);
            gbGestionClientes.Size = new Size(799, 388);
            gbGestionClientes.TabIndex = 0;
            gbGestionClientes.TabStop = false;
            gbGestionClientes.Text = "Gestion De Clientes";
            // 
            // grpListaDeClientes
            // 
            grpListaDeClientes.Controls.Add(dgvClientes);
            grpListaDeClientes.Location = new Point(14, 21);
            grpListaDeClientes.Name = "grpListaDeClientes";
            grpListaDeClientes.Size = new Size(770, 319);
            grpListaDeClientes.TabIndex = 7;
            grpListaDeClientes.TabStop = false;
            grpListaDeClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(18, 32);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(734, 272);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellFormatting += dgvClientes_CellFormatting;
            // 
            // btnSaldo
            // 
            btnSaldo.Location = new Point(447, 345);
            btnSaldo.Margin = new Padding(3, 2, 3, 2);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(147, 39);
            btnSaldo.TabIndex = 6;
            btnSaldo.Text = "Modificar Saldo";
            btnSaldo.UseVisualStyleBackColor = true;
            btnSaldo.Click += btnSaldo_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(294, 345);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(147, 39);
            btnHistorial.TabIndex = 5;
            btnHistorial.Text = "Historial de Compras";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(693, 345);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(91, 39);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(198, 345);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(106, 345);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 39);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 345);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(807, 391);
            Controls.Add(gbGestionClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Clientes";
            gbGestionClientes.ResumeLayout(false);
            grpListaDeClientes.ResumeLayout(false);
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
        private Button btnHistorial;
        private Button btnSaldo;
        private GroupBox grpListaDeClientes;
    }
}