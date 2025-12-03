namespace Vista._3_Modulo_Ventas
{
    partial class FormABMVentas
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
            grpVentas = new GroupBox();
            btnFinalizar = new Button();
            btnVolver = new Button();
            btnAgregar = new Button();
            txtVendedor = new TextBox();
            dtpFechaVenta = new DateTimePicker();
            lblVendedor = new Label();
            lblFecha = new Label();
            lblRazon = new Label();
            dgvProductosSucursal = new DataGridView();
            dgvProductosCompra = new DataGridView();
            groupBox1 = new GroupBox();
            grpCarritoDeCompras = new GroupBox();
            lblSucursalID = new Label();
            lblSucursal = new Label();
            grpProductos = new GroupBox();
            cmbRazonSocial = new ComboBox();
            grpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSucursal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCompra).BeginInit();
            groupBox1.SuspendLayout();
            grpCarritoDeCompras.SuspendLayout();
            grpProductos.SuspendLayout();
            SuspendLayout();
            // 
            // grpVentas
            // 
            grpVentas.Controls.Add(cmbRazonSocial);
            grpVentas.Controls.Add(btnFinalizar);
            grpVentas.Controls.Add(btnVolver);
            grpVentas.Controls.Add(btnAgregar);
            grpVentas.Controls.Add(txtVendedor);
            grpVentas.Controls.Add(dtpFechaVenta);
            grpVentas.Controls.Add(lblVendedor);
            grpVentas.Controls.Add(lblFecha);
            grpVentas.Controls.Add(lblRazon);
            grpVentas.Location = new Point(14, 89);
            grpVentas.Margin = new Padding(3, 2, 3, 2);
            grpVentas.Name = "grpVentas";
            grpVentas.Padding = new Padding(3, 2, 3, 2);
            grpVentas.Size = new Size(300, 397);
            grpVentas.TabIndex = 0;
            grpVentas.TabStop = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(194, 199);
            btnFinalizar.Margin = new Padding(3, 2, 3, 2);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(82, 28);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(6, 359);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(92, 33);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 199);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 28);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(90, 143);
            txtVendedor.Margin = new Padding(3, 2, 3, 2);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(186, 23);
            txtVendedor.TabIndex = 8;
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Location = new Point(71, 104);
            dtpFechaVenta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(205, 23);
            dtpFechaVenta.TabIndex = 6;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(10, 143);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 2;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(10, 104);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(10, 60);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(76, 15);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // dgvProductosSucursal
            // 
            dgvProductosSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosSucursal.Location = new Point(6, 21);
            dgvProductosSucursal.Margin = new Padding(3, 2, 3, 2);
            dgvProductosSucursal.Name = "dgvProductosSucursal";
            dgvProductosSucursal.RowHeadersWidth = 51;
            dgvProductosSucursal.Size = new Size(577, 201);
            dgvProductosSucursal.TabIndex = 1;
            // 
            // dgvProductosCompra
            // 
            dgvProductosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCompra.Location = new Point(6, 21);
            dgvProductosCompra.Margin = new Padding(3, 2, 3, 2);
            dgvProductosCompra.Name = "dgvProductosCompra";
            dgvProductosCompra.RowHeadersWidth = 51;
            dgvProductosCompra.Size = new Size(577, 206);
            dgvProductosCompra.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grpCarritoDeCompras);
            groupBox1.Controls.Add(lblSucursalID);
            groupBox1.Controls.Add(lblSucursal);
            groupBox1.Controls.Add(grpProductos);
            groupBox1.Controls.Add(grpVentas);
            groupBox1.Location = new Point(11, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(926, 496);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // grpCarritoDeCompras
            // 
            grpCarritoDeCompras.Controls.Add(dgvProductosCompra);
            grpCarritoDeCompras.Location = new Point(320, 254);
            grpCarritoDeCompras.Name = "grpCarritoDeCompras";
            grpCarritoDeCompras.Size = new Size(596, 232);
            grpCarritoDeCompras.TabIndex = 6;
            grpCarritoDeCompras.TabStop = false;
            grpCarritoDeCompras.Text = "Carrito De Compras";
            // 
            // lblSucursalID
            // 
            lblSucursalID.AutoSize = true;
            lblSucursalID.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursalID.Location = new Point(208, 16);
            lblSucursalID.Name = "lblSucursalID";
            lblSucursalID.Size = new Size(75, 65);
            lblSucursalID.TabIndex = 5;
            lblSucursalID.Text = "ID";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(6, 16);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(213, 65);
            lblSucursal.TabIndex = 4;
            lblSucursal.Text = "Sucursal:";
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(dgvProductosSucursal);
            grpProductos.Location = new Point(320, 16);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(596, 232);
            grpProductos.TabIndex = 3;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // cmbRazonSocial
            // 
            cmbRazonSocial.FormattingEnabled = true;
            cmbRazonSocial.Location = new Point(92, 60);
            cmbRazonSocial.Name = "cmbRazonSocial";
            cmbRazonSocial.Size = new Size(184, 23);
            cmbRazonSocial.TabIndex = 11;
            // 
            // FormABMVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(949, 504);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormABMVentas";
            Text = "FormABMVentas";
            grpVentas.ResumeLayout(false);
            grpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSucursal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCompra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpCarritoDeCompras.ResumeLayout(false);
            grpProductos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpVentas;
        private DateTimePicker dtpFechaVenta;
        private Label lblVendedor;
        private Label lblFecha;
        private Label lblRazon;
        private TextBox txtVendedor;
        private DataGridView dgvProductosSucursal;
        private DataGridView dgvProductosCompra;
        private Button btnFinalizar;
        private Button btnAgregar;
        private Button btnVolver;
        private GroupBox groupBox1;
        private GroupBox grpCarritoDeCompras;
        private Label lblSucursalID;
        private Label lblSucursal;
        private GroupBox grpProductos;
        private ComboBox cmbRazonSocial;
    }
}