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
using Vista.Gestion_de_Productos;

namespace Vista._3_Modulo_Ventas
{
    public partial class FormABMVentas : Form
    {
        private int? iDSucursal;

        Controladora.ControladoraVentas controladoraVentas = Controladora.ControladoraVentas.Instancia;

        public FormABMVentas(int? iDSucursal)
        {
            InitializeComponent();

            this.iDSucursal = iDSucursal;

            lblSucursalID.Text = iDSucursal.ToString();

            CargarCmbClientes();

            CargarDgvSucursal();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormGestionVentas formGestionVentas = new FormGestionVentas();
            this.Hide();
            formGestionVentas.ShowDialog();
        }

        private void CargarDgvSucursal()
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvProductosSucursal.DataSource = controladora.FiltrarPorSucursales(iDSucursal);
        }

        private void CargarDgvCarrito(Producto unProducto)
        {
            dgvProductosSucursal.DataSource = unProducto;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int? idProducto = GetId();
            if (idProducto != null)
            {
                FormCantStockVenta formCantStockVenta = new FormCantStockVenta(idProducto, iDSucursal);
                formCantStockVenta.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificar");
            }

            // dgvProductosCompra.DataSource = ListaProductos;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private int? GetId()
        {
            if (dgvProductosSucursal.Rows.Count == 0)
                return null;

            if (dgvProductosSucursal.CurrentRow == null)
                return null;

            var valor = dgvProductosSucursal.CurrentRow.Cells[0].Value;

            if (valor == null)
                return null;

            if (int.TryParse(valor.ToString(), out int id))
                return id;

            return null;
        }


        private void CargarCmbClientes()
        {
            Controladora.ControladoraClientes controladoraClientes = Controladora.ControladoraClientes.Instancia;

            var clientes = controladoraClientes.ListarClientes(); 

            if(clientes != null)
            {
                cmbRazonSocial.DataSource = clientes;
                cmbRazonSocial.DisplayMember = "RazonSocial";
                cmbRazonSocial.ValueMember = "IDCliente";
            }
        }

        
    }
}
