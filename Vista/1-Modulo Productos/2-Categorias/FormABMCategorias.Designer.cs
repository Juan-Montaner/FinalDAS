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
            grpAbm = new GroupBox();
            grpAbm.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 26;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(23, 92);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 38);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(149, 92);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 38);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpAbm
            // 
            grpAbm.Controls.Add(lblNombre);
            grpAbm.Controls.Add(btnGuardar);
            grpAbm.Controls.Add(txtNombre);
            grpAbm.Controls.Add(btnVolver);
            grpAbm.Location = new Point(10, 1);
            grpAbm.Name = "grpAbm";
            grpAbm.Size = new Size(258, 145);
            grpAbm.TabIndex = 32;
            grpAbm.TabStop = false;
            // 
            // FormABMCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(280, 155);
            Controls.Add(grpAbm);
            Name = "FormABMCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABMCategorias";
            grpAbm.ResumeLayout(false);
            grpAbm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private Button btnVolver;
        private GroupBox grpAbm;
    }
}