namespace Vista._2_Modulo_Clientes
{
    partial class FormHistorialCompras
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
            dgvHistorial = new DataGridView();
            gbGestionClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // gbGestionClientes
            // 
            gbGestionClientes.Controls.Add(btnVolver);
            gbGestionClientes.Controls.Add(dgvHistorial);
            gbGestionClientes.Location = new Point(10, 9);
            gbGestionClientes.Margin = new Padding(3, 2, 3, 2);
            gbGestionClientes.Name = "gbGestionClientes";
            gbGestionClientes.Padding = new Padding(3, 2, 3, 2);
            gbGestionClientes.Size = new Size(802, 340);
            gbGestionClientes.TabIndex = 1;
            gbGestionClientes.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(16, 308);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 28);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(16, 21);
            dgvHistorial.Margin = new Padding(3, 2, 3, 2);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(768, 259);
            dgvHistorial.TabIndex = 0;
            // 
            // FormHistorialCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(827, 353);
            Controls.Add(gbGestionClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormHistorialCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Compras";
            gbGestionClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGestionClientes;
        private Button btnVolver;
        private DataGridView dgvHistorial;
    }
}