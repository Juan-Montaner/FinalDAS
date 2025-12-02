namespace Vista._2_Modulo_Clientes
{
    partial class FormModuloClientes
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
            btnGestionClientes = new Button();
            btnVolver = new Button();
            gbClientes.SuspendLayout();
            SuspendLayout();
            // 
            // gbClientes
            // 
            gbClientes.Controls.Add(btnVolver);
            gbClientes.Controls.Add(btnGestionClientes);
            gbClientes.Location = new Point(12, 12);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new Size(238, 373);
            gbClientes.TabIndex = 0;
            gbClientes.TabStop = false;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(29, 26);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(152, 29);
            btnGestionClientes.TabIndex = 0;
            btnGestionClientes.Text = "Gestion Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(47, 310);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(134, 30);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormModuloClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(262, 397);
            Controls.Add(gbClientes);
            Name = "FormModuloClientes";
            Text = "FormModuloClientes";
            gbClientes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbClientes;
        private Button btnGestionClientes;
        private Button btnVolver;
    }
}