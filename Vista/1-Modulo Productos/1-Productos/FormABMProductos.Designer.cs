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
            grpAgregarMod = new GroupBox();
            cmbSucursal = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUdStock).BeginInit();
            grpAgregarMod.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 286);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 38);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numUdStock
            // 
            numUdStock.Location = new Point(66, 234);
            numUdStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numUdStock.Name = "numUdStock";
            numUdStock.Size = new Size(164, 23);
            numUdStock.TabIndex = 28;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(70, 196);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(160, 23);
            txtPrecio.TabIndex = 27;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(87, 120);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(142, 23);
            cmbCategoria.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(98, 82);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(131, 23);
            txtDescripcion.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 24;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(146, 286);
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
            lblStock.Location = new Point(20, 237);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 22;
            lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(20, 199);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(20, 123);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 20;
            lblCategoria.Text = "Categoria:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(20, 85);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 19;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // grpAgregarMod
            // 
            grpAgregarMod.Controls.Add(cmbSucursal);
            grpAgregarMod.Controls.Add(label1);
            grpAgregarMod.Controls.Add(lblNombre);
            grpAgregarMod.Controls.Add(btnGuardar);
            grpAgregarMod.Controls.Add(lblDescripcion);
            grpAgregarMod.Controls.Add(numUdStock);
            grpAgregarMod.Controls.Add(lblCategoria);
            grpAgregarMod.Controls.Add(txtPrecio);
            grpAgregarMod.Controls.Add(lblPrecio);
            grpAgregarMod.Controls.Add(cmbCategoria);
            grpAgregarMod.Controls.Add(lblStock);
            grpAgregarMod.Controls.Add(txtDescripcion);
            grpAgregarMod.Controls.Add(btnVolver);
            grpAgregarMod.Controls.Add(txtNombre);
            grpAgregarMod.Location = new Point(10, 3);
            grpAgregarMod.Name = "grpAgregarMod";
            grpAgregarMod.Size = new Size(250, 347);
            grpAgregarMod.TabIndex = 30;
            grpAgregarMod.TabStop = false;
            grpAgregarMod.Text = "Agregar Producto";
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(90, 158);
            cmbSucursal.Margin = new Padding(3, 2, 3, 2);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(139, 23);
            cmbSucursal.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 161);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 30;
            label1.Text = "Sucursal:";
            // 
            // FormABMProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(269, 358);
            Controls.Add(grpAgregarMod);
            Name = "FormABMProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)numUdStock).EndInit();
            grpAgregarMod.ResumeLayout(false);
            grpAgregarMod.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox grpAgregarMod;
        private Label label1;
        private ComboBox cmbSucursal;
    }
}