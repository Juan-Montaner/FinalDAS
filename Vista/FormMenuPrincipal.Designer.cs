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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(40, 292);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 53);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnRepYCons
            // 
            btnRepYCons.Location = new Point(40, 227);
            btnRepYCons.Name = "btnRepYCons";
            btnRepYCons.Size = new Size(142, 53);
            btnRepYCons.TabIndex = 8;
            btnRepYCons.Text = "Reportes y Consultas";
            btnRepYCons.UseVisualStyleBackColor = true;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.Location = new Point(40, 162);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(142, 53);
            btnGestionVentas.TabIndex = 7;
            btnGestionVentas.Text = "Gestion de Ventas";
            btnGestionVentas.UseVisualStyleBackColor = true;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(40, 97);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(142, 53);
            btnGestionClientes.TabIndex = 6;
            btnGestionClientes.Text = "Gestion de Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.Location = new Point(40, 32);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(142, 53);
            btnGestionProductos.TabIndex = 5;
            btnGestionProductos.Text = "Gestion de Productos y Sucursales";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGestionProductos);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnGestionClientes);
            groupBox1.Controls.Add(btnRepYCons);
            groupBox1.Controls.Add(btnGestionVentas);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 367);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(249, 389);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnRepYCons;
        private Button btnGestionVentas;
        private Button btnGestionClientes;
        private Button btnGestionProductos;
        private GroupBox groupBox1;
    }
}