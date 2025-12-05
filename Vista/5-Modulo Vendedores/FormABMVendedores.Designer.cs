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
            gbVendedores.Location = new Point(11, 12);
            gbVendedores.Name = "gbVendedores";
            gbVendedores.Size = new Size(274, 227);
            gbVendedores.TabIndex = 0;
            gbVendedores.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(152, 168);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(99, 43);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(17, 168);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 43);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(61, 101);
            txtDNI.MaxLength = 9;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(190, 27);
            txtDNI.TabIndex = 3;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 27);
            txtNombre.TabIndex = 2;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(17, 101);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // FormABMVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(297, 251);
            Controls.Add(gbVendedores);
            Name = "FormABMVendedores";
            StartPosition = FormStartPosition.CenterScreen;
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