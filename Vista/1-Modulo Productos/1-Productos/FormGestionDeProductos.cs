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

        private void Refrescar()
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvGestionProductos.DataSource = controladora.ListarProductos();
        }

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

            FormABMProductos formABMProductos = new FormABMProductos();
            formABMProductos.ShowDialog();

            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FormABMProductos formABMProductos = new FormABMProductos(id);
                formABMProductos.ShowDialog();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificar");
            }
            Refrescar();
        }
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloProductos formModuloProductos = new FormModuloProductos();
            this.Hide();
            formModuloProductos.ShowDialog();
        }

        private void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvGestionProductos.DataSource = controladora.FiltrarPorCategoria(cmbCategorias.Text);

        }

        private void btnFiltrarSucursal_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvGestionProductos.DataSource = controladora.FiltrarPorSucursales(Convert.ToInt32(cmbSucursales.SelectedValue));
        }
    }
}
