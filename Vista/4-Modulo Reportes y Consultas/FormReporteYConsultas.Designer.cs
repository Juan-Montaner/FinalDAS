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
            btnEstadisticas = new Button();
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
            grpProductos.Controls.Add(btnEstadisticas);
            grpProductos.Controls.Add(btnRefrescar);
            grpProductos.Controls.Add(grpVendedor);
            grpProductos.Controls.Add(grpSucursal);
            grpProductos.Controls.Add(btnGenerarReporte);
            grpProductos.Controls.Add(grpFiltrarProducto);
            grpProductos.Controls.Add(grpFiltrarCategoria);
            grpProductos.Controls.Add(grpListaProductos);
            grpProductos.Controls.Add(btnVolver);
            grpProductos.Location = new Point(12, 3);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(813, 554);
            grpProductos.TabIndex = 7;
            grpProductos.TabStop = false;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(15, 508);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(226, 36);
            btnEstadisticas.TabIndex = 12;
            btnEstadisticas.Text = "Estadisticas De Productos";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(273, 508);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(155, 36);
            btnRefrescar.TabIndex = 11;
            btnRefrescar.Text = "Refrescar Lista";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // grpVendedor
            // 
            grpVendedor.Controls.Add(btnVendedor);
            grpVendedor.Controls.Add(cmbVendedor);
            grpVendedor.Location = new Point(647, 389);
            grpVendedor.Name = "grpVendedor";
            grpVendedor.Size = new Size(155, 113);
            grpVendedor.TabIndex = 10;
            grpVendedor.TabStop = false;
            grpVendedor.Text = "Filtrar Por Vendedor";
            // 
            // btnVendedor
            // 
            btnVendedor.Location = new Point(63, 81);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(75, 23);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Filtrar";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(17, 37);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(121, 23);
            cmbVendedor.TabIndex = 0;
            // 
            // grpSucursal
            // 
            grpSucursal.Controls.Add(btnFiltrarSucursal);
            grpSucursal.Controls.Add(cmbSucursal);
            grpSucursal.Location = new Point(460, 389);
            grpSucursal.Name = "grpSucursal";
            grpSucursal.Size = new Size(155, 113);
            grpSucursal.TabIndex = 9;
            grpSucursal.TabStop = false;
            grpSucursal.Text = "Filtrar Por Sucursal";
            // 
            // btnFiltrarSucursal
            // 
            btnFiltrarSucursal.Location = new Point(63, 81);
            btnFiltrarSucursal.Name = "btnFiltrarSucursal";
            btnFiltrarSucursal.Size = new Size(75, 23);
            btnFiltrarSucursal.TabIndex = 2;
            btnFiltrarSucursal.Text = "Filtrar";
            btnFiltrarSucursal.UseVisualStyleBackColor = true;
            btnFiltrarSucursal.Click += btnFiltrarSucursal_Click;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(17, 37);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(121, 23);
            cmbSucursal.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(460, 508);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(155, 36);
            btnGenerarReporte.TabIndex = 9;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // grpFiltrarProducto
            // 
            grpFiltrarProducto.Controls.Add(btnFiltrarProducto);
            grpFiltrarProducto.Controls.Add(cmbProductos);
            grpFiltrarProducto.Location = new Point(273, 389);
            grpFiltrarProducto.Name = "grpFiltrarProducto";
            grpFiltrarProducto.Size = new Size(155, 113);
            grpFiltrarProducto.TabIndex = 8;
            grpFiltrarProducto.TabStop = false;
            grpFiltrarProducto.Text = "Filtrar Por Producto";
            // 
            // btnFiltrarProducto
            // 
            btnFiltrarProducto.Location = new Point(64, 81);
            btnFiltrarProducto.Name = "btnFiltrarProducto";
            btnFiltrarProducto.Size = new Size(75, 23);
            btnFiltrarProducto.TabIndex = 1;
            btnFiltrarProducto.Text = "Filtrar";
            btnFiltrarProducto.UseVisualStyleBackColor = true;
            btnFiltrarProducto.Click += btnFiltrarProducto_Click;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(17, 37);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(122, 23);
            cmbProductos.TabIndex = 0;
            // 
            // grpFiltrarCategoria
            // 
            grpFiltrarCategoria.Controls.Add(lblHasta);
            grpFiltrarCategoria.Controls.Add(lblDesde);
            grpFiltrarCategoria.Controls.Add(btnFiltrarPeriodo);
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
            // btnFiltrarPeriodo
            // 
            btnFiltrarPeriodo.Location = new Point(138, 81);
            btnFiltrarPeriodo.Name = "btnFiltrarPeriodo";
            btnFiltrarPeriodo.Size = new Size(75, 23);
            btnFiltrarPeriodo.TabIndex = 2;
            btnFiltrarPeriodo.Text = "Filtrar";
            btnFiltrarPeriodo.UseVisualStyleBackColor = true;
            btnFiltrarPeriodo.Click += btnFiltrarPeriodo_Click;
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
            grpListaProductos.Size = new Size(789, 361);
            grpListaProductos.TabIndex = 5;
            grpListaProductos.TabStop = false;
            grpListaProductos.Text = "Consultas";
            // 
            // dgvReportesVentas
            // 
            dgvReportesVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportesVentas.Location = new Point(13, 22);
            dgvReportesVentas.Name = "dgvReportesVentas";
            dgvReportesVentas.RowHeadersWidth = 51;
            dgvReportesVentas.Size = new Size(763, 321);
            dgvReportesVentas.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(647, 508);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(157, 36);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormReporteYConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(832, 562);
            Controls.Add(grpProductos);
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
        private Button btnEstadisticas;
    }
}