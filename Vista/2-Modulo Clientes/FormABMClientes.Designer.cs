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
            btnVolver = new Button();
            btnGuardar = new Button();
            txtMail = new TextBox();
            txtTelefono = new TextBox();
            txtRazonSocial = new TextBox();
            lblMail = new Label();
            lblTelefono = new Label();
            lblRazon = new Label();
            rbnMinorista = new RadioButton();
            rbnMayorista = new RadioButton();
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
            gbClientes.Location = new Point(24, 23);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new Size(302, 269);
            gbClientes.TabIndex = 0;
            gbClientes.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(168, 207);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 207);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(82, 118);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(181, 27);
            txtMail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(111, 82);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 27);
            txtTelefono.TabIndex = 4;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(138, 32);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(125, 27);
            txtRazonSocial.TabIndex = 3;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(35, 121);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(41, 20);
            lblMail.TabIndex = 2;
            lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(35, 80);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono:";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(35, 35);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(97, 20);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // rbnMinorista
            // 
            rbnMinorista.AutoSize = true;
            rbnMinorista.Location = new Point(36, 162);
            rbnMinorista.Name = "rbnMinorista";
            rbnMinorista.Size = new Size(92, 24);
            rbnMinorista.TabIndex = 8;
            rbnMinorista.TabStop = true;
            rbnMinorista.Text = "Minorista";
            rbnMinorista.UseVisualStyleBackColor = true;
            // 
            // rbnMayorista
            // 
            rbnMayorista.AutoSize = true;
            rbnMayorista.Location = new Point(168, 162);
            rbnMayorista.Name = "rbnMayorista";
            rbnMayorista.Size = new Size(95, 24);
            rbnMayorista.TabIndex = 9;
            rbnMayorista.TabStop = true;
            rbnMayorista.Text = "Mayorista";
            rbnMayorista.UseVisualStyleBackColor = true;
            // 
            // FormABMClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(344, 307);
            Controls.Add(gbClientes);
            Name = "FormABMClientes";
            Text = "FormABMClientes";
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