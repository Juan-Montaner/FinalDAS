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
            gbHistorialDeCompras = new GroupBox();
            btnVolver = new Button();
            dgvHistorial = new DataGridView();
            gbHistorialDeCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // gbHistorialDeCompras
            // 
            gbHistorialDeCompras.Controls.Add(dgvHistorial);
            gbHistorialDeCompras.Location = new Point(10, 9);
            gbHistorialDeCompras.Margin = new Padding(3, 2, 3, 2);
            gbHistorialDeCompras.Name = "gbHistorialDeCompras";
            gbHistorialDeCompras.Padding = new Padding(3, 2, 3, 2);
            gbHistorialDeCompras.Size = new Size(802, 297);
            gbHistorialDeCompras.TabIndex = 1;
            gbHistorialDeCompras.TabStop = false;
            gbHistorialDeCompras.Text = "Historial de Compras";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(726, 310);
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
            dgvHistorial.Location = new Point(16, 20);
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
            ClientSize = new Size(822, 347);
            Controls.Add(btnVolver);
            Controls.Add(gbHistorialDeCompras);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormHistorialCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Compras";
            gbHistorialDeCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbHistorialDeCompras;
        private Button btnVolver;
        private DataGridView dgvHistorial;
    }
}