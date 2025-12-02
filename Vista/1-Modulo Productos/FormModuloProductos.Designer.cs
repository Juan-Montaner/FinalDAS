namespace Vista
{
    partial class FormModuloProductos
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
            btnGestionarSucursales = new Button();
            btnGestionarCategorias = new Button();
            btnGestionarProductos = new Button();
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            lblModulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGestionarSucursales
            // 
            btnGestionarSucursales.Location = new Point(26, 188);
            btnGestionarSucursales.Name = "btnGestionarSucursales";
            btnGestionarSucursales.Size = new Size(149, 48);
            btnGestionarSucursales.TabIndex = 7;
            btnGestionarSucursales.Text = "Gestion de Sucursales";
            btnGestionarSucursales.UseVisualStyleBackColor = true;
            btnGestionarSucursales.Click += btnGestionarSucursales_Click;
            // 
            // btnGestionarCategorias
            // 
            btnGestionarCategorias.Location = new Point(26, 126);
            btnGestionarCategorias.Name = "btnGestionarCategorias";
            btnGestionarCategorias.Size = new Size(149, 48);
            btnGestionarCategorias.TabIndex = 6;
            btnGestionarCategorias.Text = "Gestion de Categorias";
            btnGestionarCategorias.UseVisualStyleBackColor = true;
            btnGestionarCategorias.Click += btnGestionarCategorias_Click;
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.Location = new Point(26, 68);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Size = new Size(149, 48);
            btnGestionarProductos.TabIndex = 5;
            btnGestionarProductos.Text = "Gestion de Productos";
            btnGestionarProductos.UseVisualStyleBackColor = true;
            btnGestionarProductos.Click += btnGestionarProductos_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(47, 258);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 48);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblModulo);
            groupBox1.Controls.Add(btnGestionarProductos);
            groupBox1.Controls.Add(btnGestionarSucursales);
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(btnGestionarCategorias);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 323);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModulo.Location = new Point(17, 29);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(168, 25);
            lblModulo.TabIndex = 8;
            lblModulo.Text = "Modulo Productos";
            // 
            // FormModuloProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(223, 336);
            Controls.Add(groupBox1);
            Name = "FormModuloProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarSucursales;
        private Button btnGestionarCategorias;
        private Button btnGestionarProductos;
        private Button btnVolver;
        private GroupBox groupBox1;
        private Label lblModulo;
    }
}