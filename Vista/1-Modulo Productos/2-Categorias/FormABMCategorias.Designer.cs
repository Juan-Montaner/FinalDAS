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
            txtNombre.Location = new Point(95, 55);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 27);
            txtNombre.TabIndex = 26;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(22, 123);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 51);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(170, 123);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 51);
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
            grpAbm.Location = new Point(11, 1);
            grpAbm.Margin = new Padding(3, 4, 3, 4);
            grpAbm.Name = "grpAbm";
            grpAbm.Padding = new Padding(3, 4, 3, 4);
            grpAbm.Size = new Size(295, 193);
            grpAbm.TabIndex = 32;
            grpAbm.TabStop = false;
            // 
            // FormABMCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(320, 207);
            Controls.Add(grpAbm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormABMCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
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