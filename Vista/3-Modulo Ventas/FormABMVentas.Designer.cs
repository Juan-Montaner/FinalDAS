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
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
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
            grpVentas.Controls.Add(btnFinalizar);
            grpVentas.Controls.Add(btnVolver);
            grpVentas.Controls.Add(btnAgregar);
            grpVentas.Controls.Add(textBox2);
            grpVentas.Controls.Add(dateTimePicker1);
            grpVentas.Controls.Add(textBox1);
            grpVentas.Controls.Add(lblVendedor);
            grpVentas.Controls.Add(lblFecha);
            grpVentas.Controls.Add(lblRazon);
            grpVentas.Location = new Point(16, 119);
            grpVentas.Name = "grpVentas";
            grpVentas.Size = new Size(343, 529);
            grpVentas.TabIndex = 0;
            grpVentas.TabStop = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(222, 267);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(7, 479);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 44);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(27, 267);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(81, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 5;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(11, 191);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(76, 20);
            lblVendedor.TabIndex = 2;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(11, 139);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(11, 80);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(97, 20);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // dgvProductosSucursal
            // 
            dgvProductosSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosSucursal.Location = new Point(7, 28);
            dgvProductosSucursal.Name = "dgvProductosSucursal";
            dgvProductosSucursal.RowHeadersWidth = 51;
            dgvProductosSucursal.Size = new Size(659, 268);
            dgvProductosSucursal.TabIndex = 1;
            // 
            // dgvProductosCompra
            // 
            dgvProductosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCompra.Location = new Point(7, 28);
            dgvProductosCompra.Name = "dgvProductosCompra";
            dgvProductosCompra.RowHeadersWidth = 51;
            dgvProductosCompra.Size = new Size(659, 275);
            dgvProductosCompra.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grpCarritoDeCompras);
            groupBox1.Controls.Add(lblSucursalID);
            groupBox1.Controls.Add(lblSucursal);
            groupBox1.Controls.Add(grpProductos);
            groupBox1.Controls.Add(grpVentas);
            groupBox1.Location = new Point(13, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1058, 661);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // grpCarritoDeCompras
            // 
            grpCarritoDeCompras.Controls.Add(dgvProductosCompra);
            grpCarritoDeCompras.Location = new Point(366, 339);
            grpCarritoDeCompras.Margin = new Padding(3, 4, 3, 4);
            grpCarritoDeCompras.Name = "grpCarritoDeCompras";
            grpCarritoDeCompras.Padding = new Padding(3, 4, 3, 4);
            grpCarritoDeCompras.Size = new Size(681, 309);
            grpCarritoDeCompras.TabIndex = 6;
            grpCarritoDeCompras.TabStop = false;
            grpCarritoDeCompras.Text = "Carrito De Compras";
            // 
            // lblSucursalID
            // 
            lblSucursalID.AutoSize = true;
            lblSucursalID.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursalID.Location = new Point(246, 29);
            lblSucursalID.Name = "lblSucursalID";
            lblSucursalID.Size = new Size(93, 81);
            lblSucursalID.TabIndex = 5;
            lblSucursalID.Text = "ID";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(16, 29);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(255, 81);
            lblSucursal.TabIndex = 4;
            lblSucursal.Text = "Sucursal";
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(dgvProductosSucursal);
            grpProductos.Location = new Point(366, 21);
            grpProductos.Margin = new Padding(3, 4, 3, 4);
            grpProductos.Name = "grpProductos";
            grpProductos.Padding = new Padding(3, 4, 3, 4);
            grpProductos.Size = new Size(681, 309);
            grpProductos.TabIndex = 3;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // FormABMVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1085, 672);
            Controls.Add(groupBox1);
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
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label lblVendedor;
        private Label lblFecha;
        private Label lblRazon;
        private TextBox textBox2;
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
    }
}