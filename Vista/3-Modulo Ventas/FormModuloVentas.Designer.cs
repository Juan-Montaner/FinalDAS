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
            btnVolver = new Button();
            btnGestionVentas = new Button();
            gbVentas.SuspendLayout();
            SuspendLayout();
            // 
            // gbVentas
            // 
            gbVentas.Controls.Add(btnVolver);
            gbVentas.Controls.Add(btnGestionVentas);
            gbVentas.Location = new Point(10, 9);
            gbVentas.Margin = new Padding(3, 2, 3, 2);
            gbVentas.Name = "gbVentas";
            gbVentas.Padding = new Padding(3, 2, 3, 2);
            gbVentas.Size = new Size(274, 239);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(80, 186);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(106, 35);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.Location = new Point(66, 20);
            btnGestionVentas.Margin = new Padding(3, 2, 3, 2);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(135, 35);
            btnGestionVentas.TabIndex = 0;
            btnGestionVentas.Text = "Gestion Ventas";
            btnGestionVentas.UseVisualStyleBackColor = true;
            btnGestionVentas.Click += btnGestionVentas_Click;
            // 
            // FormModuloVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(296, 259);
            Controls.Add(gbVentas);
            Margin = new Padding(3, 2, 3, 2);
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