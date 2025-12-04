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
            btnSaldo = new Button();
            btnHistorial = new Button();
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
            gbGestionClientes.Controls.Add(btnSaldo);
            gbGestionClientes.Controls.Add(btnHistorial);
            gbGestionClientes.Controls.Add(btnVolver);
            gbGestionClientes.Controls.Add(btnEliminar);
            gbGestionClientes.Controls.Add(btnModificar);
            gbGestionClientes.Controls.Add(btnAgregar);
            gbGestionClientes.Controls.Add(dgvClientes);
            gbGestionClientes.Location = new Point(15, 14);
            gbGestionClientes.Margin = new Padding(3, 2, 3, 2);
            gbGestionClientes.Name = "gbGestionClientes";
            gbGestionClientes.Padding = new Padding(3, 2, 3, 2);
            gbGestionClientes.Size = new Size(802, 340);
            gbGestionClientes.TabIndex = 0;
            gbGestionClientes.TabStop = false;
            // 
            // btnSaldo
            // 
            btnSaldo.Location = new Point(516, 302);
            btnSaldo.Margin = new Padding(3, 2, 3, 2);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(113, 28);
            btnSaldo.TabIndex = 6;
            btnSaldo.Text = "Modificar Saldo";
            btnSaldo.UseVisualStyleBackColor = true;
            btnSaldo.Click += btnSaldo_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(351, 302);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(147, 28);
            btnHistorial.TabIndex = 5;
            btnHistorial.Text = "Historial de Compras";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(698, 302);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 28);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(242, 302);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 28);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(128, 302);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 28);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(16, 302);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 28);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(16, 21);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(768, 259);
            dgvClientes.TabIndex = 0;
            // 
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(830, 361);
            Controls.Add(gbGestionClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionClientes";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnHistorial;
        private Button btnSaldo;
    }
}