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
            txtVendedor = new TextBox();
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
            grpVentas.Location = new Point(14, 16);
            grpVentas.Margin = new Padding(3, 2, 3, 2);
            grpVentas.Name = "grpVentas";
            grpVentas.Padding = new Padding(3, 2, 3, 2);
            grpVentas.Size = new Size(277, 535);
            grpVentas.TabIndex = 0;
            grpVentas.TabStop = false;
            // 
            // groupBox2
            // 
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
            groupBox2.Controls.Add(txtVendedor);
            groupBox2.Controls.Add(gbCuentaCorriente);
            groupBox2.Location = new Point(6, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 292);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Venta";
            // 
            // rbCuentaCorriente
            // 
            rbCuentaCorriente.AutoSize = true;
            rbCuentaCorriente.Location = new Point(130, 185);
            rbCuentaCorriente.Margin = new Padding(3, 2, 3, 2);
            rbCuentaCorriente.Name = "rbCuentaCorriente";
            rbCuentaCorriente.Size = new Size(115, 19);
            rbCuentaCorriente.TabIndex = 15;
            rbCuentaCorriente.TabStop = true;
            rbCuentaCorriente.Text = "Cuenta Corriente";
            rbCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(68, 256);
            btnComenzar.Margin = new Padding(3, 2, 3, 2);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(123, 26);
            btnComenzar.TabIndex = 14;
            btnComenzar.Text = "Comenzar Venta";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // rbTransferencia
            // 
            rbTransferencia.AutoSize = true;
            rbTransferencia.Location = new Point(6, 185);
            rbTransferencia.Name = "rbTransferencia";
            rbTransferencia.Size = new Size(95, 19);
            rbTransferencia.TabIndex = 13;
            rbTransferencia.TabStop = true;
            rbTransferencia.Text = "Transferencia";
            rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(6, 154);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 12;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(130, 154);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(60, 19);
            rbTarjeta.TabIndex = 12;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // cmbRazonSocial
            // 
            cmbRazonSocial.FormattingEnabled = true;
            cmbRazonSocial.Location = new Point(94, 45);
            cmbRazonSocial.Name = "cmbRazonSocial";
            cmbRazonSocial.Size = new Size(161, 23);
            cmbRazonSocial.TabIndex = 11;
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(6, 45);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(76, 15);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(6, 83);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(6, 117);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 2;
            lblVendedor.Text = "Vendedor:";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Format = DateTimePickerFormat.Short;
            dtpFechaVenta.Location = new Point(59, 83);
            dtpFechaVenta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(196, 23);
            dtpFechaVenta.TabIndex = 6;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(78, 117);
            txtVendedor.Margin = new Padding(3, 2, 3, 2);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(177, 23);
            txtVendedor.TabIndex = 8;
            // 
            // gbCuentaCorriente
            // 
            gbCuentaCorriente.Location = new Point(5, 139);
            gbCuentaCorriente.Margin = new Padding(3, 2, 3, 2);
            gbCuentaCorriente.Name = "gbCuentaCorriente";
            gbCuentaCorriente.Padding = new Padding(3, 2, 3, 2);
            gbCuentaCorriente.Size = new Size(251, 76);
            gbCuentaCorriente.TabIndex = 16;
            gbCuentaCorriente.TabStop = false;
            // 
            // lblSucursalID
            // 
            lblSucursalID.AutoSize = true;
            lblSucursalID.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursalID.Location = new Point(195, 43);
            lblSucursalID.Name = "lblSucursalID";
            lblSucursalID.Size = new Size(66, 59);
            lblSucursalID.TabIndex = 5;
            lblSucursalID.Text = "ID";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(12, 43);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(190, 59);
            lblSucursal.TabIndex = 4;
            lblSucursal.Text = "Sucursal:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(36, 496);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(177, 33);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Cancelar Venta";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(465, 237);
            btnFinalizar.Margin = new Padding(3, 2, 3, 2);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(195, 28);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar Venta";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnAgregarACarrito
            // 
            btnAgregarACarrito.Location = new Point(465, 228);
            btnAgregarACarrito.Margin = new Padding(3, 2, 3, 2);
            btnAgregarACarrito.Name = "btnAgregarACarrito";
            btnAgregarACarrito.Size = new Size(195, 28);
            btnAgregarACarrito.TabIndex = 9;
            btnAgregarACarrito.Text = "Agregar A Carrito";
            btnAgregarACarrito.UseVisualStyleBackColor = true;
            btnAgregarACarrito.Click += btnAgregar_Click;
            // 
            // dgvProductosSucursal
            // 
            dgvProductosSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosSucursal.Location = new Point(6, 21);
            dgvProductosSucursal.Margin = new Padding(3, 2, 3, 2);
            dgvProductosSucursal.Name = "dgvProductosSucursal";
            dgvProductosSucursal.RowHeadersWidth = 51;
            dgvProductosSucursal.Size = new Size(654, 201);
            dgvProductosSucursal.TabIndex = 1;
            // 
            // dgvProductosCompra
            // 
            dgvProductosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCompra.Location = new Point(6, 16);
            dgvProductosCompra.Margin = new Padding(3, 2, 3, 2);
            dgvProductosCompra.Name = "dgvProductosCompra";
            dgvProductosCompra.RowHeadersWidth = 51;
            dgvProductosCompra.Size = new Size(654, 216);
            dgvProductosCompra.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grpCarritoDeCompras);
            groupBox1.Controls.Add(grpProductos);
            groupBox1.Controls.Add(grpVentas);
            groupBox1.Location = new Point(11, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(969, 560);
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
            grpCarritoDeCompras.Location = new Point(297, 281);
            grpCarritoDeCompras.Name = "grpCarritoDeCompras";
            grpCarritoDeCompras.Size = new Size(666, 270);
            grpCarritoDeCompras.TabIndex = 6;
            grpCarritoDeCompras.TabStop = false;
            grpCarritoDeCompras.Text = "Carrito De Compras";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotal.Location = new Point(280, 240);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.No;
            lblTotal.Size = new Size(17, 20);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 240);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 12;
            label1.Text = "Total:";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(6, 236);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(195, 28);
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
            grpProductos.Location = new Point(297, 16);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(666, 263);
            grpProductos.TabIndex = 3;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(6, 227);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(85, 28);
            btnSeleccionar.TabIndex = 13;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(339, 232);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 12;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // FormABMVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(986, 562);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtVendedor;
        private GroupBox gbCuentaCorriente;
    }
}