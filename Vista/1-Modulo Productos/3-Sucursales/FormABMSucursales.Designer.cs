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
            lblErrorMail = new Label();
            gbSucursal.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(15, 206);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 51);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(144, 206);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 51);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 36);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 27);
            txtDireccion.TabIndex = 33;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 36);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 32;
            lblDireccion.Text = "Direccion:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(15, 85);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(41, 20);
            lblMail.TabIndex = 36;
            lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(15, 131);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 37;
            lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(90, 131);
            txtTelefono.MaxLength = 13;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(149, 27);
            txtTelefono.TabIndex = 38;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(59, 85);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(180, 27);
            txtMail.TabIndex = 39;
            txtMail.Leave += txtMail_Leave;
            // 
            // gbSucursal
            // 
            gbSucursal.Controls.Add(lblErrorMail);
            gbSucursal.Controls.Add(btnVolver);
            gbSucursal.Controls.Add(btnGuardar);
            gbSucursal.Controls.Add(txtMail);
            gbSucursal.Controls.Add(lblMail);
            gbSucursal.Controls.Add(txtDireccion);
            gbSucursal.Controls.Add(txtTelefono);
            gbSucursal.Controls.Add(lblTelefono);
            gbSucursal.Controls.Add(lblDireccion);
            gbSucursal.Location = new Point(8, 4);
            gbSucursal.Name = "gbSucursal";
            gbSucursal.Size = new Size(258, 273);
            gbSucursal.TabIndex = 40;
            gbSucursal.TabStop = false;
            // 
            // lblErrorMail
            // 
            lblErrorMail.AutoSize = true;
            lblErrorMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMail.ForeColor = Color.Red;
            lblErrorMail.Location = new Point(15, 170);
            lblErrorMail.Name = "lblErrorMail";
            lblErrorMail.Size = new Size(0, 20);
            lblErrorMail.TabIndex = 40;
            // 
            // FormABMSucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(274, 283);
            Controls.Add(gbSucursal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormABMSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sucursales";
            gbSucursal.ResumeLayout(false);
            gbSucursal.PerformLayout();
            ResumeLayout(false);
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
        private Label lblErrorMail;
    }
}