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
            lblNombre = new Label();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            btnGuardar = new Button();
            btnVolver = new Button();
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
            gbVendedores.Location = new Point(12, 12);
            gbVendedores.Name = "gbVendedores";
            gbVendedores.Size = new Size(274, 227);
            gbVendedores.TabIndex = 0;
            gbVendedores.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(17, 84);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(61, 84);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(190, 27);
            txtDNI.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(17, 168);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 42);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(152, 168);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(99, 42);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormABMVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(297, 250);
            Controls.Add(gbVendedores);
            Name = "FormABMVendedores";
            Text = "FormABMVendedores";
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