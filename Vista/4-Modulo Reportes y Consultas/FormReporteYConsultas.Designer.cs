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
            btnRefrescar = new Button();
            grpVendedor = new GroupBox();
            btnVendedor = new Button();
            cmbVendedor = new ComboBox();
            grpSucursal = new GroupBox();
            btnFiltrarSucursal = new Button();
            cmbSucursal = new ComboBox();
            btnGenerarReporte = new Button();
            grpFiltrarProducto = new GroupBox();
            btnFiltrarProducto = new Button();
            cmbProductos = new ComboBox();
            grpFiltrarCategoria = new GroupBox();
            lblHasta = new Label();
            lblDesde = new Label();
            btnFiltrarPeriodo = new Button();
            dtpTiempoHasta = new DateTimePicker();
            dtpTiempoInicio = new DateTimePicker();
            grpListaProductos = new GroupBox();
            dgvReportesVentas = new DataGridView();
            btnVolver = new Button();
            grpProductos.SuspendLayout();
            grpVendedor.SuspendLayout();
            grpSucursal.SuspendLayout();
            grpFiltrarProducto.SuspendLayout();
            grpFiltrarCategoria.SuspendLayout();
            grpListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportesVentas).BeginInit();
            SuspendLayout();
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(btnRefrescar);
            grpProductos.Controls.Add(grpVendedor);
            grpProductos.Controls.Add(grpSucursal);
            grpProductos.Controls.Add(btnGenerarReporte);
            grpProductos.Controls.Add(grpFiltrarProducto);
            grpProductos.Controls.Add(grpFiltrarCategoria);
            grpProductos.Controls.Add(grpListaProductos);
            grpProductos.Controls.Add(btnVolver);
            grpProductos.Location = new Point(14, 4);
            grpProductos.Margin = new Padding(3, 4, 3, 4);
            grpProductos.Name = "grpProductos";
            grpProductos.Padding = new Padding(3, 4, 3, 4);
            grpProductos.Size = new Size(987, 689);
            grpProductos.TabIndex = 7;
            grpProductos.TabStop = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(848, 519);
            btnRefrescar.Margin = new Padding(3, 4, 3, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(123, 48);
            btnRefrescar.TabIndex = 11;
            btnRefrescar.Text = "Refrescar Lista";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // grpVendedor
            // 
            grpVendedor.Controls.Add(btnVendedor);
            grpVendedor.Controls.Add(cmbVendedor);
            grpVendedor.Location = new Point(650, 519);
            grpVendedor.Margin = new Padding(3, 4, 3, 4);
            grpVendedor.Name = "grpVendedor";
            grpVendedor.Padding = new Padding(3, 4, 3, 4);
            grpVendedor.Size = new Size(177, 151);
            grpVendedor.TabIndex = 10;
            grpVendedor.TabStop = false;
            grpVendedor.Text = "Filtrar Por Vendedor";
            // 
            // btnVendedor
            // 
            btnVendedor.Location = new Point(72, 108);
            btnVendedor.Margin = new Padding(3, 4, 3, 4);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(86, 31);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Filtrar";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(19, 49);
            cmbVendedor.Margin = new Padding(3, 4, 3, 4);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(138, 28);
            cmbVendedor.TabIndex = 0;
            // 
            // grpSucursal
            // 
            grpSucursal.Controls.Add(btnFiltrarSucursal);
            grpSucursal.Controls.Add(cmbSucursal);
            grpSucursal.Location = new Point(466, 519);
            grpSucursal.Margin = new Padding(3, 4, 3, 4);
            grpSucursal.Name = "grpSucursal";
            grpSucursal.Padding = new Padding(3, 4, 3, 4);
            grpSucursal.Size = new Size(177, 151);
            grpSucursal.TabIndex = 9;
            grpSucursal.TabStop = false;
            grpSucursal.Text = "Filtrar Por Sucursal";
            // 
            // btnFiltrarSucursal
            // 
            btnFiltrarSucursal.Location = new Point(72, 108);
            btnFiltrarSucursal.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarSucursal.Name = "btnFiltrarSucursal";
            btnFiltrarSucursal.Size = new Size(86, 31);
            btnFiltrarSucursal.TabIndex = 2;
            btnFiltrarSucursal.Text = "Filtrar";
            btnFiltrarSucursal.UseVisualStyleBackColor = true;
            btnFiltrarSucursal.Click += btnFiltrarSucursal_Click;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(19, 49);
            cmbSucursal.Margin = new Padding(3, 4, 3, 4);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(138, 28);
            cmbSucursal.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(848, 571);
            btnGenerarReporte.Margin = new Padding(3, 4, 3, 4);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(123, 48);
            btnGenerarReporte.TabIndex = 9;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // grpFiltrarProducto
            // 
            grpFiltrarProducto.Controls.Add(btnFiltrarProducto);
            grpFiltrarProducto.Controls.Add(cmbProductos);
            grpFiltrarProducto.Location = new Point(282, 519);
            grpFiltrarProducto.Margin = new Padding(3, 4, 3, 4);
            grpFiltrarProducto.Name = "grpFiltrarProducto";
            grpFiltrarProducto.Padding = new Padding(3, 4, 3, 4);
            grpFiltrarProducto.Size = new Size(177, 151);
            grpFiltrarProducto.TabIndex = 8;
            grpFiltrarProducto.TabStop = false;
            grpFiltrarProducto.Text = "Filtrar Por Producto";
            // 
            // btnFiltrarProducto
            // 
            btnFiltrarProducto.Location = new Point(73, 108);
            btnFiltrarProducto.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarProducto.Name = "btnFiltrarProducto";
            btnFiltrarProducto.Size = new Size(86, 31);
            btnFiltrarProducto.TabIndex = 1;
            btnFiltrarProducto.Text = "Filtrar";
            btnFiltrarProducto.UseVisualStyleBackColor = true;
            btnFiltrarProducto.Click += btnFiltrarProducto_Click;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(19, 49);
            cmbProductos.Margin = new Padding(3, 4, 3, 4);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(139, 28);
            cmbProductos.TabIndex = 0;
            // 
            // grpFiltrarCategoria
            // 
            grpFiltrarCategoria.Controls.Add(lblHasta);
            grpFiltrarCategoria.Controls.Add(lblDesde);
            grpFiltrarCategoria.Controls.Add(btnFiltrarPeriodo);
            grpFiltrarCategoria.Controls.Add(dtpTiempoHasta);
            grpFiltrarCategoria.Controls.Add(dtpTiempoInicio);
            grpFiltrarCategoria.Location = new Point(17, 519);
            grpFiltrarCategoria.Margin = new Padding(3, 4, 3, 4);
            grpFiltrarCategoria.Name = "grpFiltrarCategoria";
            grpFiltrarCategoria.Padding = new Padding(3, 4, 3, 4);
            grpFiltrarCategoria.Size = new Size(258, 151);
            grpFiltrarCategoria.TabIndex = 6;
            grpFiltrarCategoria.TabStop = false;
            grpFiltrarCategoria.Text = "Filtrar Por Periodo";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHasta.Location = new Point(15, 72);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(61, 28);
            lblHasta.TabIndex = 4;
            lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesde.Location = new Point(15, 33);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(66, 28);
            lblDesde.TabIndex = 3;
            lblDesde.Text = "Desde";
            // 
            // btnFiltrarPeriodo
            // 
            btnFiltrarPeriodo.Location = new Point(158, 108);
            btnFiltrarPeriodo.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarPeriodo.Name = "btnFiltrarPeriodo";
            btnFiltrarPeriodo.Size = new Size(86, 31);
            btnFiltrarPeriodo.TabIndex = 2;
            btnFiltrarPeriodo.Text = "Filtrar";
            btnFiltrarPeriodo.UseVisualStyleBackColor = true;
            btnFiltrarPeriodo.Click += btnFiltrarPeriodo_Click;
            // 
            // dtpTiempoHasta
            // 
            dtpTiempoHasta.Format = DateTimePickerFormat.Short;
            dtpTiempoHasta.Location = new Point(82, 69);
            dtpTiempoHasta.Margin = new Padding(3, 4, 3, 4);
            dtpTiempoHasta.Name = "dtpTiempoHasta";
            dtpTiempoHasta.Size = new Size(161, 27);
            dtpTiempoHasta.TabIndex = 1;
            // 
            // dtpTiempoInicio
            // 
            dtpTiempoInicio.Format = DateTimePickerFormat.Short;
            dtpTiempoInicio.Location = new Point(82, 31);
            dtpTiempoInicio.Margin = new Padding(3, 4, 3, 4);
            dtpTiempoInicio.Name = "dtpTiempoInicio";
            dtpTiempoInicio.Size = new Size(161, 27);
            dtpTiempoInicio.TabIndex = 0;
            // 
            // grpListaProductos
            // 
            grpListaProductos.Controls.Add(dgvReportesVentas);
            grpListaProductos.Location = new Point(17, 29);
            grpListaProductos.Margin = new Padding(3, 4, 3, 4);
            grpListaProductos.Name = "grpListaProductos";
            grpListaProductos.Padding = new Padding(3, 4, 3, 4);
            grpListaProductos.Size = new Size(954, 481);
            grpListaProductos.TabIndex = 5;
            grpListaProductos.TabStop = false;
            grpListaProductos.Text = "Consultas";
            // 
            // dgvReportesVentas
            // 
            dgvReportesVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportesVentas.Location = new Point(15, 29);
            dgvReportesVentas.Margin = new Padding(3, 4, 3, 4);
            dgvReportesVentas.Name = "dgvReportesVentas";
            dgvReportesVentas.RowHeadersWidth = 51;
            dgvReportesVentas.Size = new Size(926, 428);
            dgvReportesVentas.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(848, 621);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(123, 48);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormReporteYConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1015, 704);
            Controls.Add(grpProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReporteYConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte Y Consultas";
            grpProductos.ResumeLayout(false);
            grpVendedor.ResumeLayout(false);
            grpSucursal.ResumeLayout(false);
            grpFiltrarProducto.ResumeLayout(false);
            grpFiltrarCategoria.ResumeLayout(false);
            grpFiltrarCategoria.PerformLayout();
            grpListaProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportesVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProductos;
        private Button btnGenerarReporte;
        private GroupBox grpFiltrarProducto;
        private ComboBox cmbProductos;
        private GroupBox grpFiltrarCategoria;
        private GroupBox grpListaProductos;
        private DataGridView dgvReportesVentas;
        private Button btnVolver;
        private GroupBox grpVendedor;
        private Button btnVendedor;
        private ComboBox cmbVendedor;
        private GroupBox grpSucursal;
        private Button btnFiltrarSucursal;
        private ComboBox cmbSucursal;
        private Button btnFiltrarProducto;
        private DateTimePicker dtpTiempoHasta;
        private DateTimePicker dtpTiempoInicio;
        private Label lblHasta;
        private Label lblDesde;
        private Button btnFiltrarPeriodo;
        private Button btnRefrescar;
    }
}