namespace Vista._2_Modulo_Clientes
{
    partial class FormABMClientes
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
            gbClientes = new GroupBox();
            rbnMayorista = new RadioButton();
            rbnMinorista = new RadioButton();
            btnVolver = new Button();
            btnGuardar = new Button();
            txtMail = new TextBox();
            txtTelefono = new TextBox();
            txtRazonSocial = new TextBox();
            lblMail = new Label();
            lblTelefono = new Label();
            lblRazon = new Label();
            gbClientes.SuspendLayout();
            SuspendLayout();
            // 
            // gbClientes
            // 
            gbClientes.Controls.Add(rbnMayorista);
            gbClientes.Controls.Add(rbnMinorista);
            gbClientes.Controls.Add(btnVolver);
            gbClientes.Controls.Add(btnGuardar);
            gbClientes.Controls.Add(txtMail);
            gbClientes.Controls.Add(txtTelefono);
            gbClientes.Controls.Add(txtRazonSocial);
            gbClientes.Controls.Add(lblMail);
            gbClientes.Controls.Add(lblTelefono);
            gbClientes.Controls.Add(lblRazon);
            gbClientes.Location = new Point(6, 3);
            gbClientes.Margin = new Padding(3, 2, 3, 2);
            gbClientes.Name = "gbClientes";
            gbClientes.Padding = new Padding(3, 2, 3, 2);
            gbClientes.Size = new Size(232, 220);
            gbClientes.TabIndex = 0;
            gbClientes.TabStop = false;
            // 
            // rbnMayorista
            // 
            rbnMayorista.AutoSize = true;
            rbnMayorista.Location = new Point(133, 128);
            rbnMayorista.Margin = new Padding(3, 2, 3, 2);
            rbnMayorista.Name = "rbnMayorista";
            rbnMayorista.Size = new Size(77, 19);
            rbnMayorista.TabIndex = 9;
            rbnMayorista.TabStop = true;
            rbnMayorista.Text = "Mayorista";
            rbnMayorista.UseVisualStyleBackColor = true;
            // 
            // rbnMinorista
            // 
            rbnMinorista.AutoSize = true;
            rbnMinorista.Location = new Point(23, 128);
            rbnMinorista.Margin = new Padding(3, 2, 3, 2);
            rbnMinorista.Name = "rbnMinorista";
            rbnMinorista.Size = new Size(75, 19);
            rbnMinorista.TabIndex = 8;
            rbnMinorista.TabStop = true;
            rbnMinorista.Text = "Minorista";
            rbnMinorista.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(133, 170);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 34);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(16, 170);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 34);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(57, 91);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(159, 23);
            txtMail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(82, 59);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(133, 23);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(106, 27);
            txtRazonSocial.Margin = new Padding(3, 2, 3, 2);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(110, 23);
            txtRazonSocial.TabIndex = 3;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(16, 94);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(33, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(16, 62);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono:";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(16, 30);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(76, 15);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // FormABMClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(247, 231);
            Controls.Add(gbClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormABMClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            gbClientes.ResumeLayout(false);
            gbClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbClientes;
        private Label lblRazon;
        private TextBox txtRazonSocial;
        private Label lblMail;
        private Label lblTelefono;
        private Button btnVolver;
        private Button btnGuardar;
        private TextBox txtMail;
        private TextBox txtTelefono;
        private RadioButton rbnMayorista;
        private RadioButton rbnMinorista;
    }
}