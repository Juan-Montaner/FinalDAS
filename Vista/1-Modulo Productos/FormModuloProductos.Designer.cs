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
            SuspendLayout();
            // 
            // btnGestionarSucursales
            // 
            btnGestionarSucursales.Location = new Point(22, 139);
            btnGestionarSucursales.Name = "btnGestionarSucursales";
            btnGestionarSucursales.Size = new Size(149, 48);
            btnGestionarSucursales.TabIndex = 7;
            btnGestionarSucursales.Text = "Gestion de Sucursales";
            btnGestionarSucursales.UseVisualStyleBackColor = true;
            btnGestionarSucursales.Click += btnGestionarSucursales_Click;
            // 
            // btnGestionarCategorias
            // 
            btnGestionarCategorias.Location = new Point(22, 77);
            btnGestionarCategorias.Name = "btnGestionarCategorias";
            btnGestionarCategorias.Size = new Size(149, 48);
            btnGestionarCategorias.TabIndex = 6;
            btnGestionarCategorias.Text = "Gestion de Categorias";
            btnGestionarCategorias.UseVisualStyleBackColor = true;
            btnGestionarCategorias.Click += btnGestionarCategorias_Click;
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.Location = new Point(22, 19);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Size = new Size(149, 48);
            btnGestionarProductos.TabIndex = 5;
            btnGestionarProductos.Text = "Gestion de Productos";
            btnGestionarProductos.UseVisualStyleBackColor = true;
            btnGestionarProductos.Click += btnGestionarProductos_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(671, 383);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 48);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // FormModuloProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionarSucursales);
            Controls.Add(btnGestionarCategorias);
            Controls.Add(btnGestionarProductos);
            Controls.Add(btnVolver);
            Name = "FormModuloProductos";
            Text = "FormProductos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarSucursales;
        private Button btnGestionarCategorias;
        private Button btnGestionarProductos;
        private Button btnVolver;
    }
}