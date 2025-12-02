namespace Vista._3_Modulo_Ventas
{
    partial class FormModuloVentas
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
            gbVentas = new GroupBox();
            btnGestionVentas = new Button();
            btnVolver = new Button();
            gbVentas.SuspendLayout();
            SuspendLayout();
            // 
            // gbVentas
            // 
            gbVentas.Controls.Add(btnVolver);
            gbVentas.Controls.Add(btnGestionVentas);
            gbVentas.Location = new Point(12, 12);
            gbVentas.Name = "gbVentas";
            gbVentas.Size = new Size(313, 319);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.Location = new Point(75, 26);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(130, 29);
            btnGestionVentas.TabIndex = 0;
            btnGestionVentas.Text = "Gestion Ventas";
            btnGestionVentas.UseVisualStyleBackColor = true;
            btnGestionVentas.Click += btnGestionVentas_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(90, 237);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormModuloVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(338, 345);
            Controls.Add(gbVentas);
            Name = "FormModuloVentas";
            Text = "FormModuloVentas";
            gbVentas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbVentas;
        private Button btnGestionVentas;
        private Button btnVolver;
    }
}