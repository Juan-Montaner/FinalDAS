namespace Vista.Gestion_de_Productos
{
    partial class FormABMSucursales
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
            btnGuardar = new Button();
            btnVolver = new Button();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            lblMail = new Label();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            gbSucursal = new GroupBox();
            gbSucursal.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(16, 148);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 38);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(142, 148);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 38);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(87, 24);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 23);
            txtDireccion.TabIndex = 33;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(16, 26);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 32;
            lblDireccion.Text = "Direccion:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(9, 47);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(33, 15);
            lblMail.TabIndex = 36;
            lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(5, 76);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 37;
            lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(87, 85);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(155, 23);
            txtTelefono.TabIndex = 38;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(87, 54);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(149, 23);
            txtMail.TabIndex = 39;
            // 
            // gbSucursal
            // 
            gbSucursal.Controls.Add(lblMail);
            gbSucursal.Controls.Add(lblTelefono);
            gbSucursal.Location = new Point(10, 9);
            gbSucursal.Margin = new Padding(3, 2, 3, 2);
            gbSucursal.Name = "gbSucursal";
            gbSucursal.Padding = new Padding(3, 2, 3, 2);
            gbSucursal.Size = new Size(250, 197);
            gbSucursal.TabIndex = 40;
            gbSucursal.TabStop = false;
            // 
            // FormABMSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(gbSucursal);
            Name = "FormABMSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormABMSucursales";
            gbSucursal.ResumeLayout(false);
            gbSucursal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnVolver;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Label lblMail;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private GroupBox gbSucursal;
    }
}