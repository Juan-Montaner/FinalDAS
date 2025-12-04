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
            groupBox2 = new GroupBox();
            rbCuentaCorriente = new RadioButton();
            btnComenzar = new Button();
            rbTransferencia = new RadioButton();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            cmbRazonSocial = new ComboBox();
            lblRazon = new Label();
            lblFecha = new Label();
            lblVendedor = new Label();
            dtpFechaVenta = new DateTimePicker();
            gbCuentaCorriente = new GroupBox();
            lblSucursalID = new Label();
            lblSucursal = new Label();
            btnVolver = new Button();
            btnFinalizar = new Button();
            btnAgregarACarrito = new Button();
            dgvProductosSucursal = new DataGridView();
            dgvProductosCompra = new DataGridView();
            groupBox1 = new GroupBox();
            grpCarritoDeCompras = new GroupBox();
            lblTotal = new Label();
            label1 = new Label();
            btnBorrar = new Button();
            grpProductos = new GroupBox();
            btnSeleccionar = new Button();
            nudCantidad = new NumericUpDown();
            cmbVendedor = new ComboBox();
            grpVentas.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSucursal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCompra).BeginInit();
            groupBox1.SuspendLayout();
            grpCarritoDeCompras.SuspendLayout();
            grpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // grpVentas
            // 
            grpVentas.Controls.Add(groupBox2);
            grpVentas.Controls.Add(lblSucursalID);
            grpVentas.Controls.Add(lblSucursal);
            grpVentas.Controls.Add(btnVolver);
            grpVentas.Location = new Point(16, 21);
            grpVentas.Name = "grpVentas";
            grpVentas.Size = new Size(317, 713);
            grpVentas.TabIndex = 0;
            grpVentas.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbVendedor);
            groupBox2.Controls.Add(rbCuentaCorriente);
            groupBox2.Controls.Add(btnComenzar);
            groupBox2.Controls.Add(rbTransferencia);
            groupBox2.Controls.Add(rbEfectivo);
            groupBox2.Controls.Add(rbTarjeta);
            groupBox2.Controls.Add(cmbRazonSocial);
            groupBox2.Controls.Add(lblRazon);
            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(lblVendedor);
            groupBox2.Controls.Add(dtpFechaVenta);
            groupBox2.Controls.Add(gbCuentaCorriente);
            groupBox2.Location = new Point(7, 169);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(299, 389);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Venta";
            // 
            // rbCuentaCorriente
            // 
            rbCuentaCorriente.AutoSize = true;
            rbCuentaCorriente.Location = new Point(149, 247);
            rbCuentaCorriente.Name = "rbCuentaCorriente";
            rbCuentaCorriente.Size = new Size(141, 24);
            rbCuentaCorriente.TabIndex = 15;
            rbCuentaCorriente.TabStop = true;
            rbCuentaCorriente.Text = "Cuenta Corriente";
            rbCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(78, 341);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(141, 35);
            btnComenzar.TabIndex = 14;
            btnComenzar.Text = "Comenzar Venta";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // rbTransferencia
            // 
            rbTransferencia.AutoSize = true;
            rbTransferencia.Location = new Point(7, 247);
            rbTransferencia.Margin = new Padding(3, 4, 3, 4);
            rbTransferencia.Name = "rbTransferencia";
            rbTransferencia.Size = new Size(117, 24);
            rbTransferencia.TabIndex = 13;
            rbTransferencia.TabStop = true;
            rbTransferencia.Text = "Transferencia";
            rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(7, 205);
            rbEfectivo.Margin = new Padding(3, 4, 3, 4);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(83, 24);
            rbEfectivo.TabIndex = 12;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(149, 205);
            rbTarjeta.Margin = new Padding(3, 4, 3, 4);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(74, 24);
            rbTarjeta.TabIndex = 12;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // cmbRazonSocial
            // 
            cmbRazonSocial.FormattingEnabled = true;
            cmbRazonSocial.Location = new Point(107, 60);
            cmbRazonSocial.Margin = new Padding(3, 4, 3, 4);
            cmbRazonSocial.Name = "cmbRazonSocial";
            cmbRazonSocial.Size = new Size(183, 28);
            cmbRazonSocial.TabIndex = 11;
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(7, 60);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(97, 20);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(7, 111);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(7, 156);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(76, 20);
            lblVendedor.TabIndex = 2;
            lblVendedor.Text = "Vendedor:";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Format = DateTimePickerFormat.Short;
            dtpFechaVenta.Location = new Point(67, 111);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(223, 27);
            dtpFechaVenta.TabIndex = 6;
            // 
            // gbCuentaCorriente
            // 
            gbCuentaCorriente.Location = new Point(6, 185);
            gbCuentaCorriente.Name = "gbCuentaCorriente";
            gbCuentaCorriente.Size = new Size(287, 101);
            gbCuentaCorriente.TabIndex = 16;
            gbCuentaCorriente.TabStop = false;
            // 
            // lblSucursalID
            // 
            lblSucursalID.AutoSize = true;
            lblSucursalID.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursalID.Location = new Point(223, 57);
            lblSucursalID.Name = "lblSucursalID";
            lblSucursalID.Size = new Size(82, 72);
            lblSucursalID.TabIndex = 5;
            lblSucursalID.Text = "ID";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(14, 57);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(240, 72);
            lblSucursal.TabIndex = 4;
            lblSucursal.Text = "Sucursal:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(41, 661);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(202, 44);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Cancelar Venta";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(531, 316);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(223, 37);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar Venta";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnAgregarACarrito
            // 
            btnAgregarACarrito.Location = new Point(531, 304);
            btnAgregarACarrito.Name = "btnAgregarACarrito";
            btnAgregarACarrito.Size = new Size(223, 37);
            btnAgregarACarrito.TabIndex = 9;
            btnAgregarACarrito.Text = "Agregar A Carrito";
            btnAgregarACarrito.UseVisualStyleBackColor = true;
            btnAgregarACarrito.Click += btnAgregar_Click;
            // 
            // dgvProductosSucursal
            // 
            dgvProductosSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosSucursal.Location = new Point(7, 28);
            dgvProductosSucursal.Name = "dgvProductosSucursal";
            dgvProductosSucursal.RowHeadersWidth = 51;
            dgvProductosSucursal.Size = new Size(747, 268);
            dgvProductosSucursal.TabIndex = 1;
            // 
            // dgvProductosCompra
            // 
            dgvProductosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCompra.Location = new Point(7, 21);
            dgvProductosCompra.Name = "dgvProductosCompra";
            dgvProductosCompra.RowHeadersWidth = 51;
            dgvProductosCompra.Size = new Size(747, 288);
            dgvProductosCompra.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grpCarritoDeCompras);
            groupBox1.Controls.Add(grpProductos);
            groupBox1.Controls.Add(grpVentas);
            groupBox1.Location = new Point(13, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1107, 747);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // grpCarritoDeCompras
            // 
            grpCarritoDeCompras.Controls.Add(lblTotal);
            grpCarritoDeCompras.Controls.Add(label1);
            grpCarritoDeCompras.Controls.Add(btnBorrar);
            grpCarritoDeCompras.Controls.Add(dgvProductosCompra);
            grpCarritoDeCompras.Controls.Add(btnFinalizar);
            grpCarritoDeCompras.Location = new Point(339, 375);
            grpCarritoDeCompras.Margin = new Padding(3, 4, 3, 4);
            grpCarritoDeCompras.Name = "grpCarritoDeCompras";
            grpCarritoDeCompras.Padding = new Padding(3, 4, 3, 4);
            grpCarritoDeCompras.Size = new Size(761, 360);
            grpCarritoDeCompras.TabIndex = 6;
            grpCarritoDeCompras.TabStop = false;
            grpCarritoDeCompras.Text = "Carrito De Compras";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotal.Location = new Point(320, 320);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.No;
            lblTotal.Size = new Size(22, 25);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 320);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 12;
            label1.Text = "Total:";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(7, 315);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(223, 37);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Sacar Del Carrito";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(btnSeleccionar);
            grpProductos.Controls.Add(nudCantidad);
            grpProductos.Controls.Add(dgvProductosSucursal);
            grpProductos.Controls.Add(btnAgregarACarrito);
            grpProductos.Location = new Point(339, 21);
            grpProductos.Margin = new Padding(3, 4, 3, 4);
            grpProductos.Name = "grpProductos";
            grpProductos.Padding = new Padding(3, 4, 3, 4);
            grpProductos.Size = new Size(761, 351);
            grpProductos.TabIndex = 3;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(7, 303);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(97, 37);
            btnSeleccionar.TabIndex = 13;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(387, 309);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(137, 27);
            nudCantidad.TabIndex = 12;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(85, 156);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(205, 28);
            cmbVendedor.TabIndex = 17;
            cmbVendedor.SelectedIndexChanged += cmbVendedor_SelectedIndexChanged;
            // 
            // FormABMVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1127, 749);
            Controls.Add(groupBox1);
            Name = "FormABMVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormABMVentas";
            grpVentas.ResumeLayout(false);
            grpVentas.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSucursal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCompra).EndInit();
            groupBox1.ResumeLayout(false);
            grpCarritoDeCompras.ResumeLayout(false);
            grpCarritoDeCompras.PerformLayout();
            grpProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpVentas;
        private DataGridView dgvProductosSucursal;
        private DataGridView dgvProductosCompra;
        private Button btnFinalizar;
        private Button btnAgregarACarrito;
        private Button btnVolver;
        private GroupBox groupBox1;
        private GroupBox grpCarritoDeCompras;
        private Label lblSucursalID;
        private Label lblSucursal;
        private GroupBox grpProductos;
        private NumericUpDown nudCantidad;
        private Button btnBorrar;
        private Button btnSeleccionar;
        private Label lblTotal;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbCuentaCorriente;
        private Button btnComenzar;
        private RadioButton rbTransferencia;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private ComboBox cmbRazonSocial;
        private Label lblRazon;
        private Label lblFecha;
        private Label lblVendedor;
        private DateTimePicker dtpFechaVenta;
        private GroupBox gbCuentaCorriente;
        private ComboBox cmbVendedor;
    }
}