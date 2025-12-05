using Controladora;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista._4_Modulo_Reportes_y_Consultas
{
    public partial class FormReporteYConsultas : Form
    {
        public FormReporteYConsultas()
        {
            InitializeComponent();
            btnGenerarReporte.Enabled = false;
            Refrescar();
            CargarCmbProductos();
            CargarCmbSucursales();
            CargarCmbVendedores();
        }
        private void Refrescar()
        {
            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
            dgvReportesVentas.DataSource = controladora.ListarVentas();
        }
        private void btnFiltrarPeriodo_Click(object sender, EventArgs e)
        {
            btnGenerarReporte.Enabled = true;
            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;

            if (DateTimeOffset.Compare(dtpTiempoInicio.Value, dtpTiempoHasta.Value) > 0)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.");
                return;
            }

            dgvReportesVentas.DataSource = controladora.FiltrarVentasPorPeriodo(dtpTiempoInicio.Value, dtpTiempoHasta.Value);
        }

        private void btnFiltrarProducto_Click(object sender, EventArgs e)
        {
            btnGenerarReporte.Enabled = true;

            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
            dgvReportesVentas.DataSource = controladora.FiltrarVentasPorProducto(Convert.ToInt32(cmbProductos.SelectedValue));
        }

        private void btnFiltrarSucursal_Click(object sender, EventArgs e)
        {
            btnGenerarReporte.Enabled = true;
            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
            dgvReportesVentas.DataSource = controladora.FiltrarVentasPorSucursal(Convert.ToInt32(cmbSucursal.SelectedValue));
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            btnGenerarReporte.Enabled = true;
            Controladora.ControladoraVendedores controladoraVendedores = Controladora.ControladoraVendedores.Instancia;
            Controladora.ControladoraVentas controladoraVentas = Controladora.ControladoraVentas.Instancia;

            var vendedor = controladoraVendedores.BuscarVendedorID(Convert.ToInt32(cmbVendedor.SelectedValue));

            dgvReportesVentas.DataSource = controladoraVentas.FiltrarVentasPorVendedor(vendedor.Nombre);
        }
        private void GenerarReporteExcelDesdeDGV()
        {
            if (dgvReportesVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar Reporte de Ventas";
            saveFileDialog.FileName = "ReporteVentas.xlsx";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string ruta = saveFileDialog.FileName;

            using (SpreadsheetDocument document =
                SpreadsheetDocument.Create(ruta, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                SheetData sheetData = new SheetData();
                worksheetPart.Worksheet = new Worksheet(sheetData);

                Sheets sheets = document.WorkbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet()
                {
                    Id = document.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Reporte"
                };
                sheets.Append(sheet);

                // ENCABEZADOS
                Row header = new Row();
                foreach (DataGridViewColumn col in dgvReportesVentas.Columns)
                {
                    header.Append(new Cell()
                    {
                        CellValue = new CellValue(col.HeaderText),
                        DataType = CellValues.String
                    });
                }
                sheetData.Append(header);

                // FILAS
                foreach (DataGridViewRow fila in dgvReportesVentas.Rows)
                {
                    if (fila.IsNewRow) continue;

                    Row row = new Row();

                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        row.Append(new Cell()
                        {
                            CellValue = new CellValue(celda.Value?.ToString() ?? ""),
                            DataType = CellValues.String
                        });
                    }

                    sheetData.Append(row);
                }
            }

            MessageBox.Show("Reporte generado correctamente.");
        }


        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteExcelDesdeDGV();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            btnGenerarReporte.Enabled = false;
            Refrescar();

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCmbProductos()
        {
            Controladora.ControladoraProductos controladoraProductos = Controladora.ControladoraProductos.Instancia;

            var productos = controladoraProductos.ListarProductos();

            if (productos != null)
            {
                cmbProductos.DataSource = productos;
                cmbProductos.DisplayMember = "Nombre";
                cmbProductos.ValueMember = "IDProducto";
            }
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
            Controladora.ControladoraVendedores controladoraVendedores = Controladora.ControladoraVendedores.Instancia;

            var vendedores = controladoraVendedores.ListarVendedores();

            if (vendedores != null)
            {
                cmbVendedor.DataSource = vendedores;
                cmbVendedor.DisplayMember = "Nombre";
                cmbVendedor.ValueMember = "IDVendedor";
            }
        }
    }
}
