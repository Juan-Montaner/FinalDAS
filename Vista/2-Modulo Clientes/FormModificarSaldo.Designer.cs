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
            gbSaldo.Location = new Point(5, 7);
            gbSaldo.Margin = new Padding(3, 2, 3, 2);
            gbSaldo.Name = "gbSaldo";
            gbSaldo.Padding = new Padding(3, 2, 3, 2);
            gbSaldo.Size = new Size(236, 153);
            gbSaldo.TabIndex = 0;
            gbSaldo.TabStop = false;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(13, 72);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(52, 15);
            lblImporte.TabIndex = 5;
            lblImporte.Text = "Importe:";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldoActual.Location = new Point(121, 27);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(60, 21);
            lblSaldoActual.TabIndex = 4;
            lblSaldoActual.Text = "SALDO";
            lblSaldoActual.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(137, 114);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(87, 26);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(13, 114);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 26);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(71, 69);
            txtSaldo.Margin = new Padding(3, 2, 3, 2);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(153, 23);
            txtSaldo.TabIndex = 1;
            txtSaldo.KeyPress += txtSaldo_KeyPress;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(28, 27);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(97, 21);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo actual:";
            // 
            // FormModificarSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(247, 171);
            Controls.Add(gbSaldo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormModificarSaldo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Saldo";
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