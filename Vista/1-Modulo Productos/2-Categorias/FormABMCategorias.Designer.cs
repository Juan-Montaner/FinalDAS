namespace Vista.Gestion_de_Productos
{
    partial class FormABMCategorias
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 26;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(14, 63);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 38);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(140, 63);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 38);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormABMCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FormABMCategorias";
            Text = "FormABMCategorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private Button btnVolver;
    }
}