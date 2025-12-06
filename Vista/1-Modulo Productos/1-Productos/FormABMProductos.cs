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
    public partial class FormABMProductos : Form
    {
        private int? Id;
        public FormABMProductos(int? id = null)
        {
            InitializeComponent();
            this.Id = id;
            CargarCategorias();
            CargarSucursales();

            if (id != null)
            {
                CargarDatos();
                grpAgregarMod.Text = "Modificar Producto";
            }
            else
            {
                grpAgregarMod.Text = "Agregar Producto";
            }
        }

        // Metodo que carga los datos para modificarlos
        private void CargarDatos()
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;

            var producto = controladora.BuscarProductoId((int)Id);

            if (Id != null)
            {
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                cmbCategoria.Text = producto.Categoria;
                cmbSucursal.Text = producto.IDSucursal.ToString();
                numUdStock.Value = producto.Stock;
            }
        }

        // Metodo que carga las sucursales en el Combo Box 
        private void CargarSucursales()
        {
            Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;

            var sucursales = controladora.ListarSucursales();

            if (sucursales != null)
            {
                cmbSucursal.DataSource = sucursales;
                cmbSucursal.DisplayMember = "Direccion";
                cmbSucursal.ValueMember = "IDSucursal";
            }

        }

        // Metodo que carga las categorias en el Combo Box 
        private void CargarCategorias()
        {
            Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia;

            var categorias = controladora.ListarCategorias();

            if (categorias != null)
            {
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";

            }

        }

        // Boton que permite volver al menu de gestion de productos 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton que agrega o modifica un producto
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;

            try
            {
                if (Id == null)
                {
                    try
                    {
                        string Nombre = txtNombre.Text;
                        string Descripcion = txtDescripcion.Text;
                        decimal Precio = decimal.Parse(txtPrecio.Text);
                        string Categoria = cmbCategoria.Text.ToString();
                        int IDSucursal = (int)cmbSucursal.SelectedValue;
                        int Stock = Convert.ToInt32(numUdStock.Value);

                        controladora.AgregarProducto(Nombre, Descripcion, Categoria, IDSucursal, Precio, Stock);
                    }
                    catch (FormatException Ex)
                    {
                        MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
                    }
                }
                else
                {
                    try
                    {
                        int id = Id.Value;
                        string Nombre = txtNombre.Text;
                        string Descripcion = txtDescripcion.Text;
                        decimal Precio = decimal.Parse(txtPrecio.Text);
                        string Categoria = cmbCategoria.SelectedIndex.ToString();
                        int IDSucursal = (int)cmbSucursal.SelectedValue;
                        int Stock = Convert.ToInt32(numUdStock.Value);

                        controladora.ModificarProducto(id, Nombre, Descripcion, Categoria, IDSucursal, Precio, Stock);
                    }
                    catch (FormatException Ex)
                    {
                        MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
                    }
                }
            }
            catch (FormatException Ex)
            {
                MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
            }

            this.Hide();
            FormGestionDeProductos formGestionDeProductos = new FormGestionDeProductos();
            this.Close();
            formGestionDeProductos.ShowDialog();
        }

        // Solo permite dígitos y la tecla Backspace
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }

}
