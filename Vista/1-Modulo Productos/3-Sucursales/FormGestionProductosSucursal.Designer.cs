namespace Vista._1_Modulo_Productos._3_Sucursales
{
    partial class FormGestionProductosSucursal
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
            grpAgregartModProducto = new GroupBox();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            numUdStock = new NumericUpDown();
            lblStock = new Label();
            btnGuardar = new Button();
            btnVolver = new Button();
            grpAgregartModProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUdStock).BeginInit();
            SuspendLayout();
            // 
            // grpAgregartModProducto
            // 
            grpAgregartModProducto.Controls.Add(lblProducto);
            grpAgregartModProducto.Controls.Add(cmbProducto);
            grpAgregartModProducto.Controls.Add(numUdStock);
            grpAgregartModProducto.Controls.Add(lblStock);
            grpAgregartModProducto.Controls.Add(btnGuardar);
            grpAgregartModProducto.Controls.Add(btnVolver);
            grpAgregartModProducto.Location = new Point(12, 2);
            grpAgregartModProducto.Name = "grpAgregartModProducto";
            grpAgregartModProducto.Size = new Size(261, 170);
            grpAgregartModProducto.TabIndex = 1;
            grpAgregartModProducto.TabStop = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(20, 37);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 31;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(87, 34);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(142, 23);
            cmbProducto.TabIndex = 32;
            // 
            // numUdStock
            // 
            numUdStock.Location = new Point(65, 63);
            numUdStock.Name = "numUdStock";
            numUdStock.Size = new Size(164, 23);
            numUdStock.TabIndex = 30;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(20, 65);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 29;
            lblStock.Text = "Stock:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 121);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(167, 121);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // FormGestionProductosSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(287, 180);
            Controls.Add(grpAgregartModProducto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionProductosSucursal";
            Text = "FormGestionProductosSucursal";
            grpAgregartModProducto.ResumeLayout(false);
            grpAgregartModProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUdStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAgregartModProducto;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private NumericUpDown numUdStock;
        private Label lblStock;
        private Button btnGuardar;
        private Button btnVolver;
    }
}