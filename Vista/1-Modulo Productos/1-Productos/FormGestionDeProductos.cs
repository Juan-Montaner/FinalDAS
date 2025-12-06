using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Gestion_de_Productos
{
    public partial class FormGestionDeProductos : Form
    {
        public FormGestionDeProductos()
        {
            InitializeComponent();
            Refrescar();
            CargarCategorias();
            CargarSucursales();
        }

        // Metodo que refresca el Data Grid View
        private void Refrescar()
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvGestionProductos.DataSource = controladora.ListarProductos();
            PintarEncabezados();
            AjustarColumnas();
        }

        #region Detalles visuales dgv
        private void PintarEncabezados()
        {

            dgvGestionProductos.EnableHeadersVisualStyles = false;


            foreach (DataGridViewColumn col in dgvGestionProductos.Columns)
            {

                col.HeaderCell.Style.Font = new Font(dgvGestionProductos.Font, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.White;
                col.HeaderCell.Style.BackColor = Color.SteelBlue;


            }
            dgvGestionProductos.Refresh();
        }

        private void AjustarColumnas()
        {
            if (dgvGestionProductos.Columns.Count == 0)
                return;

            dgvGestionProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGestionProductos.AllowUserToResizeColumns = false;
            dgvGestionProductos.AllowUserToResizeRows = false;

            // Función local para evitar NRE
            void SetWidth(string colName, int width)
            {
                var col = dgvGestionProductos.Columns[colName];
                if (col != null)
                    col.Width = width;
            }

            void AlignRight(string colName)
            {
                var col = dgvGestionProductos.Columns[colName];
                if (col != null)
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            SetWidth("IDProducto", 80);
            SetWidth("Nombre", 120);
            SetWidth("Descripcion", 150);
            SetWidth("Categoria", 80);
            SetWidth("Precio", 80);
            SetWidth("IDSucursal", 90);
            SetWidth("Stock", 70);

            AlignRight("Precio");
            AlignRight("Stock");
        }

        #endregion

        // Metodo que carga las sucursales en el Combo Box 
        private void CargarSucursales()
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

        // Metodo que carga las categorias en el Combo Box 
        private void CargarCategorias()
        {
            Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia;

            var categorias = controladora.ListarCategorias();

            if (categorias != null)
            {
                cmbCategorias.DataSource = categorias;
                cmbCategorias.DisplayMember = "Nombre";

            }

        }

        // Metodo que obtiene el ID de el producto seleccionado en el Data Grid View
        private int? GetId()
        {
            if (dgvGestionProductos.Rows.Count == 0)
                return null;

            if (dgvGestionProductos.CurrentRow == null)
                return null;

            var valor = dgvGestionProductos.CurrentRow.Cells[0].Value;

            if (valor == null)
                return null;

            if (int.TryParse(valor.ToString(), out int id))
                return id;

            return null;
        }

        // Boton que permite agregar un producto 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var controladoraCate = Controladora.ControladoraCategorias.Instancia;

            if (!controladoraCate.ContadorDeCategorias())
            {
                MessageBox.Show("Debe crear al menos una categoría antes de agregar productos.");
                return;
            }

            var controladoraSucu = Controladora.ControladoraSucursales.Instancia;

            if (!controladoraSucu.ContadorDeSucursales())
            {
                MessageBox.Show("Debe crear al menos una Sucursal antes de agregar productos.");
                return;
            }

            this.Hide();
            FormABMProductos formABMProductos = new FormABMProductos();
            formABMProductos.ShowDialog();
            this.Show();

            Refrescar();
        }

        // Boton que permite modificar un producto 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                this.Hide();
                FormABMProductos formABMProductos = new FormABMProductos(id);
                formABMProductos.ShowDialog();
                this.Show();

                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificar");
            }
            Refrescar();
        }

        // Boton que permite eliminar un producto 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
                controladora.EliminarProducto((int)id);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar");
            }
            Refrescar();
        }

        // Boton que permite volver al menu principal 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloProductos formModuloProductos = new FormModuloProductos();
            this.Hide();
            formModuloProductos.ShowDialog();
        }

        // Boton que permite filtrar los productos por categoria
        private void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvGestionProductos.DataSource = controladora.FiltrarPorCategoria(cmbCategorias.Text);
        }

        // Boton que permite filtrar los productos por sucursal
        private void btnFiltrarSucursal_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvGestionProductos.DataSource = controladora.FiltrarPorSucursales(Convert.ToInt32(cmbSucursales.SelectedValue));
        }

        // Boton que elimina el filtro seleccionado
        private void btnDesfiltrar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        // Boton que filtra segun los productos mas vendidos
        private void btnMasVendidos_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
            dgvGestionProductos.DataSource = controladora.ProductosMasVendidos();
        }

        // Boton que muestra la cantidad vendida de un producto seleccionado
        private void btnCantidadVendida_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id == null)
            {
                MessageBox.Show("Seleccione un producto para consultar la cantidad vendida.");
                return;
            }

            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;

            int cantidad = controladora.CantidadVendidaProducto((int)id);

            MessageBox.Show($"Cantidad vendida del producto seleccionado: {cantidad}");
        }

        // Colores Data Grid View
        private void dgvGestionProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGestionProductos.Columns[e.ColumnIndex].Name == "Stock" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int stock))
                {
                    var cell = dgvGestionProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cell.Style.Font = new Font(dgvGestionProductos.Font, FontStyle.Bold);

                    if (stock == 0)
                    {
                        cell.Style.ForeColor = Color.White;
                        cell.Style.BackColor = Color.Red;     
                    }
                    else if (stock > 0 && stock <= 20)
                    {
                        cell.Style.ForeColor = Color.White;
                        cell.Style.BackColor = Color.Orange;     
                    }
                }
            }
        }
    }
}
