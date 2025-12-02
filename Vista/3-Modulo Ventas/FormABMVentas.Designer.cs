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
            btnAgregar = new Button();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            lblVendedor = new Label();
            lblFecha = new Label();
            lblRazon = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            grpProductos = new GroupBox();
            lblSucursal = new Label();
            lblSucursalID = new Label();
            grpCarritoDeCompras = new GroupBox();
            grpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            grpProductos.SuspendLayout();
            grpCarritoDeCompras.SuspendLayout();
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
            grpVentas.Location = new Point(14, 89);
            grpVentas.Margin = new Padding(3, 2, 3, 2);
            grpVentas.Name = "grpVentas";
            grpVentas.Padding = new Padding(3, 2, 3, 2);
            grpVentas.Size = new Size(300, 397);
            grpVentas.TabIndex = 0;
            grpVentas.TabStop = false;
            grpVentas.Enter += gbVentas_Enter;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(194, 200);
            btnFinalizar.Margin = new Padding(3, 2, 3, 2);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(82, 22);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(24, 200);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 141);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(71, 104);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(205, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 60);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 5;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(24, 144);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 2;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(24, 104);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(24, 63);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(76, 15);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 21);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 201);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 21);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(577, 206);
            dataGridView2.TabIndex = 2;
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
            // grpProductos
            // 
            grpProductos.Controls.Add(dataGridView1);
            grpProductos.Location = new Point(320, 16);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(596, 232);
            grpProductos.TabIndex = 3;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(24, 22);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(203, 65);
            lblSucursal.TabIndex = 4;
            lblSucursal.Text = "Sucursal";
            // 
            // lblSucursalID
            // 
            lblSucursalID.AutoSize = true;
            lblSucursalID.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursalID.Location = new Point(215, 22);
            lblSucursalID.Name = "lblSucursalID";
            lblSucursalID.Size = new Size(75, 65);
            lblSucursalID.TabIndex = 5;
            lblSucursalID.Text = "ID";
            // 
            // grpCarritoDeCompras
            // 
            grpCarritoDeCompras.Controls.Add(dataGridView2);
            grpCarritoDeCompras.Location = new Point(320, 254);
            grpCarritoDeCompras.Name = "grpCarritoDeCompras";
            grpCarritoDeCompras.Size = new Size(596, 232);
            grpCarritoDeCompras.TabIndex = 6;
            grpCarritoDeCompras.TabStop = false;
            grpCarritoDeCompras.Text = "Carrito De Compras";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpProductos.ResumeLayout(false);
            grpCarritoDeCompras.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
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