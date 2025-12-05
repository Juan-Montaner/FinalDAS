using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista._2_Modulo_Clientes;
using Vista.Gestion_de_Productos;
using ClosedXML.Excel;
using System.IO;
using DocumentFormat.OpenXml.Presentation;
using WinColor = System.Drawing.Color;
using WinFont = System.Drawing.Font;

namespace Vista._3_Modulo_Ventas
{
    public partial class FormGestionVentas : Form
    {
        public FormGestionVentas()
        {
            InitializeComponent();
            cmbSucursales.SelectedIndexChanged -= cmbSucursales_SelectedIndexChanged;
            CargarComboBox();
            cmbSucursales.SelectedIndexChanged += cmbSucursales_SelectedIndexChanged;
            Refrescar();
            PintarEncabezados(dgvVentas);
        }

        private void Refrescar()
        {
            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
            dgvVentas.DataSource = controladora.ListarVentas();
        }

        private void PintarEncabezados(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderCell.Style.Font = new WinFont(dgv.Font, System.Drawing.FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = WinColor.White;
                col.HeaderCell.Style.BackColor = WinColor.FromArgb(60, 141, 188);
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.GridColor = WinColor.Silver; // Líneas gris claro

            dgv.Refresh();
        }

        private int? GetId()
        {
            if (Controladora.ControladoraVentas.Instancia.ListarVentas().Count != 0)
            {
                try
                {
                    return int.Parse(dgvVentas.Rows[dgvVentas.CurrentRow.Index].Cells[0].Value.ToString());
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void CargarComboBox()
        {
            Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;

            var sucursales = controladora.ListarSucursales();

            if (sucursales != null)
            {
                cmbSucursales.DataSource = sucursales;
                cmbSucursales.DisplayMember = "Direccion";
                cmbSucursales.ValueMember = "IDSucursal";
            }
        }

        private void FiltrarVentas()
        {
            if (cmbSucursales.SelectedValue == null)
                return;

            if (!(cmbSucursales.SelectedValue is int))
                return;

            int idSucursal = (int)cmbSucursales.SelectedValue;

            var controladora = Controladora.ControladoraVentas.Instancia;
            var ventas = controladora.ListarVentas().Where(p => p.IDSucursal == idSucursal).ToList();

            dgvVentas.DataSource = ventas;
        }

        private int? IDSucursal()
        {
            if (cmbSucursales.SelectedItem == null)
                return null;

            if (cmbSucursales.SelectedValue == null)
                return null;

            int id;

            if (int.TryParse(cmbSucursales.SelectedValue.ToString(), out id))
                return id;

            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraSucursales controladoraSucursales = Controladora.ControladoraSucursales.Instancia;
            Controladora.ControladoraProductos controladoraProductos = Controladora.ControladoraProductos.Instancia;

            int? idSucursal = IDSucursal();

            if (idSucursal == null)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            var lista = controladoraProductos.FiltrarPorSucursales((int)idSucursal);

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("La sucursal NO tiene productos, seleccione otra.");
                return;
            }

            var sucursal = controladoraSucursales.ListarSucursales().FirstOrDefault(s => s.IDSucursal == idSucursal);

            if (sucursal == null)
            {
                MessageBox.Show("Sucursal no encontrada.");
                return;
            }

            this.Hide();
            FormABMVentas formABMVentas = new FormABMVentas(idSucursal);
            formABMVentas.ShowDialog();
            this.Show();

            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
                controladora.EliminarVenta((int)id);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una venta para eliminar");
            }
            Refrescar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal FormMenuPrincipal = new FormMenuPrincipal();
            this.Hide();
            FormMenuPrincipal.ShowDialog();
        }

        private void cmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarVentas();

        }


        private void btnFactura_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id == null)
            {
                MessageBox.Show("Seleccione una factura/venta.");
                return;
            }

            var controladora = Controladora.ControladoraVentas.Instancia;
            var venta = controladora.BuscarVentaIDDetallesBuscarDatId((int)id); 

            if (venta == null)
            {
                MessageBox.Show("No se encontró la factura.");
                return;
            }

            if (venta.Detalles == null || venta.Detalles.Count == 0)
            {
                MessageBox.Show("La venta no tiene detalles.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xlsx)|*.xlsx";
            save.FileName = $"Factura_{venta.IDVenta}.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                GenerarFacturaExcel(venta, save.FileName);
                MessageBox.Show("Factura exportada correctamente.");
            }
        }


        private void GenerarFacturaExcel(Venta venta, string rutaArchivo)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Factura");

            int row = 1;

            // ===== Encabezado de la empresa =====
            ws.Cell(row, 1).Value = "TechStore S.A.";
            ws.Cell(row, 1).Style.Font.Bold = true;
            ws.Cell(row, 1).Style.Font.FontSize = 18;
            row++;

            ws.Cell(row, 1).Value = "Tel: 341-202-5678 | Email: TechStoreSA@gmail.com";
            row += 2;

            // ===== Datos de la factura =====
            ws.Cell(row, 1).Value = $"FACTURA N° {venta.IDVenta}";
            ws.Cell(row, 1).Style.Font.Bold = true;
            ws.Cell(row, 1).Style.Font.FontSize = 14;
            row++;

            ws.Cell(row, 1).Value = $"Fecha: {venta.Fecha:dd/MM/yyyy}";
            row++;
            ws.Cell(row, 1).Value = $"Cliente: {venta.RazonSocialCliente}";
            row++;
            ws.Cell(row, 1).Value = $"Vendedor: {venta.Vendedor}";
            row++;
            ws.Cell(row, 1).Value = $"Sucursal: {venta.IDSucursal}";
            row++;
            ws.Cell(row, 1).Value = $"Método de pago: {venta.MetodoDePago}";
            row += 2;

            // ===== Encabezados de la tabla de detalles =====
            int headerRow = row;
            ws.Cell(headerRow, 1).Value = "Descripción";
            ws.Cell(headerRow, 2).Value = "Cant.";
            ws.Cell(headerRow, 3).Value = "Precio";
            ws.Cell(headerRow, 4).Value = "Total";

            var headerRange = ws.Range(headerRow, 1, headerRow, 4);
            headerRange.Style.Font.Bold = true;
            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
            headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            row++;

            // ===== Filas de detalle =====
            foreach (var det in venta.Detalles)
            {
                string nombre = det.Producto != null
                    ? det.Producto.Nombre
                    : $"Producto {det.IDProducto}";

                ws.Cell(row, 1).Value = nombre;
                ws.Cell(row, 2).Value = det.Cantidad;
                ws.Cell(row, 3).Value = det.PrecioUnitario;
                ws.Cell(row, 4).Value = det.Cantidad * det.PrecioUnitario;

                ws.Cell(row, 3).Style.NumberFormat.Format = "$ #,##0.00";
                ws.Cell(row, 4).Style.NumberFormat.Format = "$ #,##0.00";

                row++;
            }

            int totalRow = row + 1;

            // ===== Total =====
            ws.Cell(totalRow, 3).Value = "TOTAL:";
            ws.Cell(totalRow, 3).Style.Font.Bold = true;
            ws.Cell(totalRow, 4).Value = venta.Total;        // si ya lo calculás y guardás
            ws.Cell(totalRow, 4).Style.NumberFormat.Format = "$ #,##0.00";
            ws.Cell(totalRow, 4).Style.Font.Bold = true;

            // Bordes de la tabla
            var tableRange = ws.Range(headerRow, 1, row - 1, 4);
            tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

            // Ajustar ancho de columnas
            ws.Columns(1, 4).AdjustToContents();

            wb.SaveAs(rutaArchivo);
        }
    }
}