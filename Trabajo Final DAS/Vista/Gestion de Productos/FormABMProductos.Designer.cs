namespace Vista.Gestion_de_Productos
{
    partial class FormABMProductos
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
            btnGuardar = new Button();
            numUdStock = new NumericUpDown();
            txtPrecio = new TextBox();
            cmbCategoria = new ComboBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            btnVolver = new Button();
            lblStock = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)numUdStock).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(13, 267);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 38);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // numUdStock
            // 
            numUdStock.Location = new Point(58, 202);
            numUdStock.Name = "numUdStock";
            numUdStock.Size = new Size(164, 23);
            numUdStock.TabIndex = 28;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(62, 155);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(160, 23);
            txtPrecio.TabIndex = 27;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(80, 111);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(142, 23);
            cmbCategoria.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(91, 68);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(131, 23);
            txtDescripcion.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(73, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 24;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(139, 267);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 38);
            btnVolver.TabIndex = 23;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(13, 204);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 22;
            lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(13, 158);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(13, 114);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 20;
            lblCategoria.Text = "Categoria:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(13, 71);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 19;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(13, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // FormABMProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(266, 343);
            Controls.Add(btnGuardar);
            Controls.Add(numUdStock);
            Controls.Add(txtPrecio);
            Controls.Add(cmbCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(btnVolver);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Name = "FormABMProductos";
            Text = "FormABMProductos";
            ((System.ComponentModel.ISupportInitialize)numUdStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private NumericUpDown numUdStock;
        private TextBox txtPrecio;
        private ComboBox cmbCategoria;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnVolver;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Label lblNombre;
    }
}