namespace Vista._2_Modulo_Clientes
{
    partial class FormModificarSaldo
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
            gbSaldo = new GroupBox();
            lblImporte = new Label();
            lblSaldoActual = new Label();
            btnVolver = new Button();
            btnGuardar = new Button();
            txtSaldo = new TextBox();
            lblSaldo = new Label();
            gbSaldo.SuspendLayout();
            SuspendLayout();
            // 
            // gbSaldo
            // 
            gbSaldo.Controls.Add(lblImporte);
            gbSaldo.Controls.Add(lblSaldoActual);
            gbSaldo.Controls.Add(btnVolver);
            gbSaldo.Controls.Add(btnGuardar);
            gbSaldo.Controls.Add(txtSaldo);
            gbSaldo.Controls.Add(lblSaldo);
            gbSaldo.Location = new Point(12, 12);
            gbSaldo.Name = "gbSaldo";
            gbSaldo.Size = new Size(270, 179);
            gbSaldo.TabIndex = 0;
            gbSaldo.TabStop = false;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(15, 71);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(65, 20);
            lblImporte.TabIndex = 5;
            lblImporte.Text = "Importe:";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Location = new Point(140, 23);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(56, 20);
            lblSaldoActual.TabIndex = 4;
            lblSaldoActual.Text = "SALDO";
            lblSaldoActual.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(157, 128);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(99, 34);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(15, 128);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(96, 71);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(160, 27);
            txtSaldo.TabIndex = 1;
            txtSaldo.KeyPress += txtSaldo_KeyPress;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(15, 23);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(94, 20);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo actual:";
            // 
            // FormModificarSaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(329, 203);
            Controls.Add(gbSaldo);
            Name = "FormModificarSaldo";
            Text = "FormModificarSaldo";
            gbSaldo.ResumeLayout(false);
            gbSaldo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSaldo;
        private Button btnVolver;
        private Button btnGuardar;
        private TextBox txtSaldo;
        private Label lblSaldo;
        private Label lblImporte;
        private Label lblSaldoActual;
    }
}