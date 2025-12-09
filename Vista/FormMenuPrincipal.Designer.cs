namespace Vista
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            btnSalir = new Button();
            btnRepYCons = new Button();
            btnGestionVentas = new Button();
            btnGestionClientes = new Button();
            btnGestionProductos = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            lblMenuPrincipal = new Label();
            btnVendedores = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(60, 478);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 53);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnRepYCons
            // 
            btnRepYCons.Location = new Point(60, 406);
            btnRepYCons.Name = "btnRepYCons";
            btnRepYCons.Size = new Size(142, 53);
            btnRepYCons.TabIndex = 8;
            btnRepYCons.Text = "Reportes y Consultas";
            btnRepYCons.UseVisualStyleBackColor = true;
            btnRepYCons.Click += btnRepYCons_Click;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.Location = new Point(60, 262);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(142, 53);
            btnGestionVentas.TabIndex = 7;
            btnGestionVentas.Text = "Gestion de Ventas";
            btnGestionVentas.UseVisualStyleBackColor = true;
            btnGestionVentas.Click += btnGestionVentas_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(60, 190);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(142, 53);
            btnGestionClientes.TabIndex = 6;
            btnGestionClientes.Text = "Gestion de Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.Location = new Point(60, 118);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(142, 53);
            btnGestionProductos.TabIndex = 5;
            btnGestionProductos.Text = "Gestion de Productos y Sucursales";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblMenuPrincipal);
            groupBox1.Controls.Add(btnVendedores);
            groupBox1.Controls.Add(btnGestionProductos);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnGestionClientes);
            groupBox1.Controls.Add(btnRepYCons);
            groupBox1.Controls.Add(btnGestionVentas);
            groupBox1.Location = new Point(10, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 550);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenuPrincipal.Location = new Point(36, 19);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(460, 86);
            lblMenuPrincipal.TabIndex = 11;
            lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btnVendedores
            // 
            btnVendedores.Location = new Point(60, 334);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(142, 53);
            btnVendedores.TabIndex = 10;
            btnVendedores.Text = "Gestion de Vendedores";
            btnVendedores.UseVisualStyleBackColor = true;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 408);
            label1.Name = "label1";
            label1.Size = new Size(178, 50);
            label1.TabIndex = 13;
            label1.Text = "Manual de Usuario \r\nDiagrama de Clases";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(557, 562);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnRepYCons;
        private Button btnGestionVentas;
        private Button btnGestionClientes;
        private Button btnGestionProductos;
        private GroupBox groupBox1;
        private Button btnVendedores;
        private Label lblMenuPrincipal;
        private PictureBox pictureBox1;
        private Label label1;
    }
}