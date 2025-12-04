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
            gbGestionClientes.Location = new Point(12, 12);
            gbGestionClientes.Name = "gbGestionClientes";
            gbGestionClientes.Size = new Size(917, 453);
            gbGestionClientes.TabIndex = 1;
            gbGestionClientes.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 410);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 37);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(18, 28);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(878, 345);
            dgvHistorial.TabIndex = 0;
            // 
            // FormHistorialCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(945, 471);
            Controls.Add(gbGestionClientes);
            Name = "FormHistorialCompras";
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