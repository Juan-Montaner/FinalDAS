namespace Vista._4_Modulo_Reportes_y_Consultas
{
    partial class FormEstadisticasDeProductos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grpEstadisticas = new GroupBox();
            btnGenerarReporte = new Button();
            grpGrafico = new GroupBox();
            chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnVolver = new Button();
            grpSucursal = new GroupBox();
            btnFiltrarSucursal = new Button();
            cmbSucursal = new ComboBox();
            grpCategoria = new GroupBox();
            btnFiltrarCategoria = new Button();
            cmbCategoria = new ComboBox();
            grpEstadisticas.SuspendLayout();
            grpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartEstadisticas).BeginInit();
            grpSucursal.SuspendLayout();
            grpCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // grpEstadisticas
            // 
            grpEstadisticas.Controls.Add(btnGenerarReporte);
            grpEstadisticas.Controls.Add(grpGrafico);
            grpEstadisticas.Controls.Add(btnVolver);
            grpEstadisticas.Controls.Add(grpSucursal);
            grpEstadisticas.Controls.Add(grpCategoria);
            grpEstadisticas.Location = new Point(12, 1);
            grpEstadisticas.Name = "grpEstadisticas";
            grpEstadisticas.Size = new Size(776, 413);
            grpEstadisticas.TabIndex = 0;
            grpEstadisticas.TabStop = false;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(49, 358);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(143, 49);
            btnGenerarReporte.TabIndex = 10;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // grpGrafico
            // 
            grpGrafico.Controls.Add(chartEstadisticas);
            grpGrafico.Location = new Point(241, 22);
            grpGrafico.Name = "grpGrafico";
            grpGrafico.Size = new Size(529, 346);
            grpGrafico.TabIndex = 6;
            grpGrafico.TabStop = false;
            grpGrafico.Text = "GraficoDeTorta";
            // 
            // chartEstadisticas
            // 
            chartArea1.Name = "ChartArea1";
            chartEstadisticas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartEstadisticas.Legends.Add(legend1);
            chartEstadisticas.Location = new Point(5, 22);
            chartEstadisticas.Name = "chartEstadisticas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartEstadisticas.Series.Add(series1);
            chartEstadisticas.Size = new Size(518, 317);
            chartEstadisticas.TabIndex = 5;
            chartEstadisticas.Text = "chartEstadisticas";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(635, 374);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(135, 33);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpSucursal
            // 
            grpSucursal.Controls.Add(btnFiltrarSucursal);
            grpSucursal.Controls.Add(cmbSucursal);
            grpSucursal.Location = new Point(6, 156);
            grpSucursal.Name = "grpSucursal";
            grpSucursal.Size = new Size(229, 128);
            grpSucursal.TabIndex = 4;
            grpSucursal.TabStop = false;
            grpSucursal.Text = "Filtrar Por Sucursal";
            // 
            // btnFiltrarSucursal
            // 
            btnFiltrarSucursal.Location = new Point(129, 76);
            btnFiltrarSucursal.Name = "btnFiltrarSucursal";
            btnFiltrarSucursal.Size = new Size(75, 23);
            btnFiltrarSucursal.TabIndex = 3;
            btnFiltrarSucursal.Text = "Filtrar";
            btnFiltrarSucursal.UseVisualStyleBackColor = true;
            btnFiltrarSucursal.Click += btnFiltrarSucursal_Click;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(22, 36);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(182, 23);
            cmbSucursal.TabIndex = 2;
            // 
            // grpCategoria
            // 
            grpCategoria.Controls.Add(btnFiltrarCategoria);
            grpCategoria.Controls.Add(cmbCategoria);
            grpCategoria.Location = new Point(6, 22);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(229, 128);
            grpCategoria.TabIndex = 1;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Filtrar Por Categoria";
            // 
            // btnFiltrarCategoria
            // 
            btnFiltrarCategoria.Location = new Point(129, 76);
            btnFiltrarCategoria.Name = "btnFiltrarCategoria";
            btnFiltrarCategoria.Size = new Size(75, 23);
            btnFiltrarCategoria.TabIndex = 3;
            btnFiltrarCategoria.Text = "Filtrar";
            btnFiltrarCategoria.UseVisualStyleBackColor = true;
            btnFiltrarCategoria.Click += btnFiltrarCategoria_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(22, 36);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(182, 23);
            cmbCategoria.TabIndex = 2;
            // 
            // FormEstadisticasDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(797, 421);
            Controls.Add(grpEstadisticas);
            Name = "FormEstadisticasDeProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas De Productos";
            grpEstadisticas.ResumeLayout(false);
            grpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartEstadisticas).EndInit();
            grpSucursal.ResumeLayout(false);
            grpCategoria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEstadisticas;
        private GroupBox grpSucursal;
        private Button btnFiltrarSucursal;
        private ComboBox cmbSucursal;
        private GroupBox grpCategoria;
        private Button btnFiltrarCategoria;
        private ComboBox cmbCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private GroupBox grpGrafico;
        private Button btnVolver;
        private Button btnGenerarReporte;
    }
}