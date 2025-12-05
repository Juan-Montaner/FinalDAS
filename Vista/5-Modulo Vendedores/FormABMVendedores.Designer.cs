namespace Vista._5_Modulo_Vendedores
{
    partial class FormABMVendedores
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
            gbVendedores = new GroupBox();
            btnVolver = new Button();
            btnGuardar = new Button();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            lblDNI = new Label();
            lblNombre = new Label();
            gbVendedores.SuspendLayout();
            SuspendLayout();
            // 
            // gbVendedores
            // 
            gbVendedores.Controls.Add(btnVolver);
            gbVendedores.Controls.Add(btnGuardar);
            gbVendedores.Controls.Add(txtDNI);
            gbVendedores.Controls.Add(txtNombre);
            gbVendedores.Controls.Add(lblDNI);
            gbVendedores.Controls.Add(lblNombre);
            gbVendedores.Location = new Point(10, 9);
            gbVendedores.Margin = new Padding(3, 2, 3, 2);
            gbVendedores.Name = "gbVendedores";
            gbVendedores.Padding = new Padding(3, 2, 3, 2);
            gbVendedores.Size = new Size(240, 170);
            gbVendedores.TabIndex = 0;
            gbVendedores.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(133, 126);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(87, 32);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(15, 126);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 32);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(53, 76);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(167, 23);
            txtDNI.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 41);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(15, 76);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // FormABMVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(260, 188);
            Controls.Add(gbVendedores);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormABMVendedores";
            Text = "Vendedores";
            gbVendedores.ResumeLayout(false);
            gbVendedores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbVendedores;
        private Button btnVolver;
        private Button btnGuardar;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label lblDNI;
        private Label lblNombre;
    }
}