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
            btnSalir = new Button();
            btnRepYCons = new Button();
            btnGestionVentas = new Button();
            btnGestionClientes = new Button();
            btnGestionProductos = new Button();
            groupBox1 = new GroupBox();
            lblMenuPrincipal = new Label();
            btnVendedores = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(75, 659);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(162, 71);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnRepYCons
            // 
            btnRepYCons.Location = new Point(75, 563);
            btnRepYCons.Margin = new Padding(3, 4, 3, 4);
            btnRepYCons.Name = "btnRepYCons";
            btnRepYCons.Size = new Size(162, 71);
            btnRepYCons.TabIndex = 8;
            btnRepYCons.Text = "Reportes y Consultas";
            btnRepYCons.UseVisualStyleBackColor = true;
            btnRepYCons.Click += btnRepYCons_Click;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.Location = new Point(75, 371);
            btnGestionVentas.Margin = new Padding(3, 4, 3, 4);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(162, 71);
            btnGestionVentas.TabIndex = 7;
            btnGestionVentas.Text = "Gestion de Ventas";
            btnGestionVentas.UseVisualStyleBackColor = true;
            btnGestionVentas.Click += btnGestionVentas_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(75, 275);
            btnGestionClientes.Margin = new Padding(3, 4, 3, 4);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(162, 71);
            btnGestionClientes.TabIndex = 6;
            btnGestionClientes.Text = "Gestion de Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.Location = new Point(75, 179);
            btnGestionProductos.Margin = new Padding(3, 4, 3, 4);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(162, 71);
            btnGestionProductos.TabIndex = 5;
            btnGestionProductos.Text = "Gestion de Productos y Sucursales";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMenuPrincipal);
            groupBox1.Controls.Add(btnVendedores);
            groupBox1.Controls.Add(btnGestionProductos);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnGestionClientes);
            groupBox1.Controls.Add(btnRepYCons);
            groupBox1.Controls.Add(btnGestionVentas);
            groupBox1.Location = new Point(11, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(609, 756);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenuPrincipal.Location = new Point(49, 37);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(571, 106);
            lblMenuPrincipal.TabIndex = 11;
            lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btnVendedores
            // 
            btnVendedores.Location = new Point(75, 467);
            btnVendedores.Margin = new Padding(3, 4, 3, 4);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(162, 71);
            btnVendedores.TabIndex = 10;
            btnVendedores.Text = "Gestion de Vendedores";
            btnVendedores.UseVisualStyleBackColor = true;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(637, 772);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}