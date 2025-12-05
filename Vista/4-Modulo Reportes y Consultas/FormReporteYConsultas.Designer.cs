namespace Vista._4_Modulo_Reportes_y_Consultas
{
    partial class FormReporteYConsultas
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
            grpProductos = new GroupBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            btnVendedor = new Button();
            comboBox2 = new ComboBox();
            groupBox2 = new GroupBox();
            btnFiltrarSucursal = new Button();
            comboBox1 = new ComboBox();
            btnGenerarReporte = new Button();
            groupBox1 = new GroupBox();
            btnFiltrarProducto = new Button();
            cmbSucursales = new ComboBox();
            grpFiltrarCategoria = new GroupBox();
            lblHasta = new Label();
            lblDesde = new Label();
            button1 = new Button();
            dtpTiempoHasta = new DateTimePicker();
            dtpTiempoInicio = new DateTimePicker();
            grpListaProductos = new GroupBox();
            dgvReportesVentas = new DataGridView();
            btnVolver = new Button();
            grpProductos.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            grpFiltrarCategoria.SuspendLayout();
            grpListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportesVentas).BeginInit();
            SuspendLayout();
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(button2);
            grpProductos.Controls.Add(groupBox3);
            grpProductos.Controls.Add(groupBox2);
            grpProductos.Controls.Add(btnGenerarReporte);
            grpProductos.Controls.Add(groupBox1);
            grpProductos.Controls.Add(grpFiltrarCategoria);
            grpProductos.Controls.Add(grpListaProductos);
            grpProductos.Controls.Add(btnVolver);
            grpProductos.Location = new Point(12, 3);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(864, 517);
            grpProductos.TabIndex = 7;
            grpProductos.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(742, 389);
            button2.Name = "button2";
            button2.Size = new Size(108, 36);
            button2.TabIndex = 11;
            button2.Text = "Refrescar Lista";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnVendedor);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Location = new Point(569, 389);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(155, 113);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtrar Por Vendedor";
            // 
            // btnVendedor
            // 
            btnVendedor.Location = new Point(63, 81);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(75, 23);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Filtrar";
            btnVendedor.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(17, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFiltrarSucursal);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(408, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 113);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar Por Sucursal";
            // 
            // btnFiltrarSucursal
            // 
            btnFiltrarSucursal.Location = new Point(63, 81);
            btnFiltrarSucursal.Name = "btnFiltrarSucursal";
            btnFiltrarSucursal.Size = new Size(75, 23);
            btnFiltrarSucursal.TabIndex = 2;
            btnFiltrarSucursal.Text = "Filtrar";
            btnFiltrarSucursal.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(742, 428);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(108, 36);
            btnGenerarReporte.TabIndex = 9;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrarProducto);
            groupBox1.Controls.Add(cmbSucursales);
            groupBox1.Location = new Point(247, 389);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 113);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por Producto";
            // 
            // btnFiltrarProducto
            // 
            btnFiltrarProducto.Location = new Point(64, 81);
            btnFiltrarProducto.Name = "btnFiltrarProducto";
            btnFiltrarProducto.Size = new Size(75, 23);
            btnFiltrarProducto.TabIndex = 1;
            btnFiltrarProducto.Text = "Filtrar";
            btnFiltrarProducto.UseVisualStyleBackColor = true;
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(17, 37);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(122, 23);
            cmbSucursales.TabIndex = 0;
            // 
            // grpFiltrarCategoria
            // 
            grpFiltrarCategoria.Controls.Add(lblHasta);
            grpFiltrarCategoria.Controls.Add(lblDesde);
            grpFiltrarCategoria.Controls.Add(button1);
            grpFiltrarCategoria.Controls.Add(dtpTiempoHasta);
            grpFiltrarCategoria.Controls.Add(dtpTiempoInicio);
            grpFiltrarCategoria.Location = new Point(15, 389);
            grpFiltrarCategoria.Name = "grpFiltrarCategoria";
            grpFiltrarCategoria.Size = new Size(226, 113);
            grpFiltrarCategoria.TabIndex = 6;
            grpFiltrarCategoria.TabStop = false;
            grpFiltrarCategoria.Text = "Filtrar Por Periodo";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHasta.Location = new Point(13, 54);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(49, 21);
            lblHasta.TabIndex = 4;
            lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesde.Location = new Point(13, 25);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(53, 21);
            lblDesde.TabIndex = 3;
            lblDesde.Text = "Desde";
            // 
            // button1
            // 
            button1.Location = new Point(138, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtpTiempoHasta
            // 
            dtpTiempoHasta.Format = DateTimePickerFormat.Short;
            dtpTiempoHasta.Location = new Point(72, 52);
            dtpTiempoHasta.Name = "dtpTiempoHasta";
            dtpTiempoHasta.Size = new Size(141, 23);
            dtpTiempoHasta.TabIndex = 1;
            // 
            // dtpTiempoInicio
            // 
            dtpTiempoInicio.Format = DateTimePickerFormat.Short;
            dtpTiempoInicio.Location = new Point(72, 23);
            dtpTiempoInicio.Name = "dtpTiempoInicio";
            dtpTiempoInicio.Size = new Size(141, 23);
            dtpTiempoInicio.TabIndex = 0;
            // 
            // grpListaProductos
            // 
            grpListaProductos.Controls.Add(dgvReportesVentas);
            grpListaProductos.Location = new Point(15, 22);
            grpListaProductos.Name = "grpListaProductos";
            grpListaProductos.Size = new Size(835, 361);
            grpListaProductos.TabIndex = 5;
            grpListaProductos.TabStop = false;
            grpListaProductos.Text = "Reporte";
            // 
            // dgvReportesVentas
            // 
            dgvReportesVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportesVentas.Location = new Point(13, 22);
            dgvReportesVentas.Name = "dgvReportesVentas";
            dgvReportesVentas.RowHeadersWidth = 51;
            dgvReportesVentas.Size = new Size(810, 321);
            dgvReportesVentas.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(742, 466);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 36);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // FormReporteYConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(888, 528);
            Controls.Add(grpProductos);
            Name = "FormReporteYConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte Y Consultas";
            grpProductos.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grpFiltrarCategoria.ResumeLayout(false);
            grpFiltrarCategoria.PerformLayout();
            grpListaProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportesVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProductos;
        private Button btnGenerarReporte;
        private GroupBox groupBox1;
        private ComboBox cmbSucursales;
        private GroupBox grpFiltrarCategoria;
        private GroupBox grpListaProductos;
        private DataGridView dgvReportesVentas;
        private Button btnVolver;
        private GroupBox groupBox3;
        private Button btnVendedor;
        private ComboBox comboBox2;
        private GroupBox groupBox2;
        private Button btnFiltrarSucursal;
        private ComboBox comboBox1;
        private Button btnFiltrarProducto;
        private DateTimePicker dtpTiempoHasta;
        private DateTimePicker dtpTiempoInicio;
        private Label lblHasta;
        private Label lblDesde;
        private Button button1;
        private Button button2;
    }
}