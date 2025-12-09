using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using Controladora;
using Entidades;
using ClosedXML.Excel;

namespace Vista._4_Modulo_Reportes_y_Consultas
{
    public partial class FormEstadisticasDeProductos : Form
    {
        Controladora.ControladoraProductos controladoraProductos = Controladora.ControladoraProductos.Instancia;
        Controladora.ControladoraVentas controladoraVentas = Controladora.ControladoraVentas.Instancia;

        public FormEstadisticasDeProductos()
        {
            InitializeComponent();
            CargarCmbSucursales();
            CargarCmbVendedores();
        }


        private void CargarCmbSucursales()
        {
            Controladora.ControladoraSucursales controladoraSucursales = Controladora.ControladoraSucursales.Instancia;

            var sucursales = controladoraSucursales.ListarSucursales();

            if (sucursales != null)
            {
                cmbSucursal.DataSource = sucursales;
                cmbSucursal.DisplayMember = "Direccion";
                cmbSucursal.ValueMember = "IDSucursal";
            }
        }

        private void CargarCmbVendedores()
        {
            Controladora.ControladoraCategorias controladoraCategorias = Controladora.ControladoraCategorias.Instancia;

            var categorias = controladoraCategorias.ListarCategorias();

            if (categorias != null)
            {
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IDCategoria";
            }
        }

        private void GenerarGraficoPorCategoria()
        {

            var listaProductos = controladoraProductos.FiltrarPorCategoria(cmbCategoria.Text);

            var datos = listaProductos
                .Select(p => new
                {
                    Producto = p.Nombre,
                    CantidadTotal = controladoraVentas.CantidadVendidaProducto(p.IDProducto)
                })
                .Where(x => x.CantidadTotal > 0)
                .ToList();

            chartEstadisticas.Series.Clear();
            chartEstadisticas.Titles.Clear();

            var serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "{#}"; // porcentaje

            foreach (var item in datos)
            {
                serie.Points.AddXY(item.Producto, item.CantidadTotal);
            }

            chartEstadisticas.Series.Add(serie);
            chartEstadisticas.Titles.Add($"Ventas por producto en categoría: {cmbCategoria.Text}");
        }
        private void GenerarGraficoPorSucursal()
        {
            // Obtengo solo productos de esa sucursal desde tu controladora
            var listaProductos = controladoraProductos.FiltrarPorSucursales((int)cmbSucursal.SelectedValue);

            // Consulto cuántas unidades se vendió de cada producto
            var datos = listaProductos
                .Select(p => new
                {
                    Producto = p.Nombre,   // ajustá si tu atributo es otro
                    CantidadTotal = controladoraVentas.CantidadVendidaProducto(p.IDProducto)
                })
                .Where(x => x.CantidadTotal > 0)
                .ToList();

            chartEstadisticas.Series.Clear();
            chartEstadisticas.Titles.Clear();

            var serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "{#}";

            foreach (var item in datos)
            {
                serie.Points.AddXY(item.Producto, item.CantidadTotal);
            }

            chartEstadisticas.Series.Add(serie);
            chartEstadisticas.Titles.Add($"Ventas por producto en sucursal: {cmbSucursal.Text}");
        }

        private void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCategoria.Text))
                GenerarGraficoPorCategoria();
        }

        private void btnFiltrarSucursal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSucursal.Text))
                GenerarGraficoPorSucursal();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (chartEstadisticas.Series.Count == 0 ||
                 chartEstadisticas.Series[0].Points.Count == 0)
            {
                MessageBox.Show("No hay datos en el gráfico para generar el reporte.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                sfd.Title = "Guardar reporte de estadísticas";
                sfd.FileName = "ReporteEstadisticas.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        GenerarReporteExcelDesdeGrafico(sfd.FileName);
                        MessageBox.Show("Reporte generado correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el reporte: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void GenerarReporteExcelDesdeGrafico(string rutaArchivo)
        {
            // 1) Guardar el gráfico actual como imagen temporal
            string rutaImagenTemp = Path.Combine(Path.GetTempPath(), "GraficoEstadisticas.png");
            chartEstadisticas.SaveImage(rutaImagenTemp, ChartImageFormat.Png);

            // 2) Crear el Excel
            using (var workbook = new XLWorkbook())
            {
                // ---- Hoja de datos ----
                var wsDatos = workbook.Worksheets.Add("Datos");

                wsDatos.Cell(1, 1).Value = "Producto";
                wsDatos.Cell(1, 2).Value = "Cantidad";

                int fila = 2;
                var serie = chartEstadisticas.Series[0];

                foreach (var point in serie.Points)
                {
                    // Etiqueta (lo que pusiste como X en AddXY)
                    string etiqueta = point.AxisLabel;

                    // Valor numérico (Y)
                    double valor = point.YValues.Length > 0 ? point.YValues[0] : 0;

                    wsDatos.Cell(fila, 1).Value = etiqueta;
                    wsDatos.Cell(fila, 2).Value = valor;
                    fila++;
                }

                wsDatos.Range(1, 1, 1, 2).Style.Font.Bold = true;
                wsDatos.Columns().AdjustToContents();
                wsDatos.RangeUsed().SetAutoFilter();

                // ---- Hoja de gráfico (imagen) ----
                var wsGrafico = workbook.Worksheets.Add("Gráfico");

                if (File.Exists(rutaImagenTemp))
                {
                    var img = wsGrafico.AddPicture(rutaImagenTemp)
                                       .MoveTo(wsGrafico.Cell("A1"))
                                       .Scale(0.9);   // ajustá tamaño si querés
                }

                // 3) Guardar archivo
                workbook.SaveAs(rutaArchivo);
            }

            // 4) Limpiar imagen temporal (opcional)
            try
            {
                if (File.Exists(rutaImagenTemp))
                    File.Delete(rutaImagenTemp);
            }
            catch { }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReporteYConsultas formReporteYConsultas = new FormReporteYConsultas();
            this.Close();
            formReporteYConsultas.ShowDialog();
        }
    }
}
