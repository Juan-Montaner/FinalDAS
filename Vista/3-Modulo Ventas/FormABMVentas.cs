using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Vista.Gestion_de_Productos;

namespace Vista._3_Modulo_Ventas
{
    public partial class FormABMVentas : Form
    {
        private int? iDSucursal;
        Controladora.ControladoraVentas controladoraVentas = Controladora.ControladoraVentas.Instancia;
        Controladora.ControladoraProductos controladoraProductos = Controladora.ControladoraProductos.Instancia;
        Controladora.ControladoraClientes controladoraClientes = Controladora.ControladoraClientes.Instancia;
        Controladora.ControladoraFacturas controladoraFacturas = Controladora.ControladoraFacturas.Instancia;


        private List<Producto> productosCarrito = new List<Producto>();
        private List<Producto> ProductoDisponibles = new List<Producto>();
        private List<DetalleVenta> productosVenta = new List<DetalleVenta>();
        private Venta venta = new Venta();

        private decimal Total;

        public FormABMVentas(int? iDSucursal, decimal Total = 0)
        {
            InitializeComponent();

            this.iDSucursal = iDSucursal;
            this.Total = Total;


            lblSucursalID.Text = iDSucursal.ToString();
            CargarDgvSucursal();
            CargarCmbClientes();

            nudCantidad.Enabled = false;
            btnAgregarACarrito.Enabled = false;

            grpCarritoDeCompras.Enabled = false;
            grpProductos.Enabled = false;
        }

        private void LimitarCantidad(int idProducto)
        {
            var producto = controladoraProductos.BuscarProductoId(idProducto);

            nudCantidad.Maximum = producto.Stock;
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
            ProductoDisponibles = controladora.FiltrarPorSucursales(iDSucursal);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int? idProducto = GetId();
            if (idProducto != null)
            {
                var producto = controladoraProductos.BuscarProductoId((int)idProducto);

                if (producto != null)
                {
                    int cantidad = (int)nudCantidad.Value;
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0.");
                        return;
                    }

                    var productoCarrito = controladoraProductos.AgregarProductoCarrito(producto, cantidad);

                    var detalle = new DetalleVenta
                    {
                        IDProducto = productoCarrito.IDProducto,
                        Cantidad = cantidad,
                        PrecioUnitario = productoCarrito.Precio,
                        IDVenta = venta.IDVenta,
                    };

                    productosVenta.Add(detalle);
                    productosCarrito.Add(productoCarrito);
                    dgvProductosCompra.DataSource = null;
                    dgvProductosCompra.DataSource = productosCarrito;
                    ProductoDisponibles.Remove(producto);
                    dgvProductosSucursal.DataSource = null;
                    dgvProductosSucursal.DataSource = ProductoDisponibles;

                    CalcularTotal(Total);
                    
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificar");
            }

            dgvProductosSucursal.Enabled = true;
            nudCantidad.Enabled = false;
            nudCantidad.Value = 0;
            btnAgregarACarrito.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string razonSocial = cmbRazonSocial.Text;
            DateTime Fecha = dtpFechaVenta.Value;
            string vendedor = txtVendedor.Text;

            int MetodoDePago = 0;
            if (rbEfectivo.Checked == true)
            {
                MetodoDePago = 1;
            }
            else if (rbTarjeta.Checked == true)
            {
                MetodoDePago = 2;
            }
            else if (rbTransferencia.Checked == true)
            {
                MetodoDePago = 3;
            }

            foreach (var detalle in productosVenta)
            {
                var producto = controladoraProductos.BuscarProductoId(detalle.IDProducto);

                
                producto.Stock = producto.Stock - detalle.Cantidad;

                controladoraProductos.ModificarProducto(producto.IDProducto, producto.Nombre, producto.Descripcion, producto.Categoria, producto.IDSucursal, producto.Precio, producto.Stock);
            }

            controladoraVentas.AgregarVentas(razonSocial, Fecha, productosVenta, (int)iDSucursal, vendedor, MetodoDePago, Total);

            var ventaRecien = controladoraVentas.BuscarVenta(Fecha);

            controladoraFacturas.AgregarFacturas(razonSocial, Fecha, MetodoDePago, Total, ventaRecien.IDVenta);

            MessageBox.Show("Venta realizada con exito.");
            this.Close();
        }

        private void CalcularTotal(decimal Total)
        {
            var cliente = controladoraClientes.BuscarCliente(cmbRazonSocial.Text);

            this.Total = 0;  // Reinicio el total REAL de la clase

            foreach (var det in productosVenta)
            {
                this.Total += det.Cantidad * det.PrecioUnitario;
            }

            if (cliente.TipoCliente == true)
            {
                this.Total = this.Total * (1 - 0.10m); 
            }
            else
            {
                this.Total = this.Total * (1 - 0.025m); 

            }
            lblTotal.Text = "$ " + this.Total.ToString("0.00");

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


        private int? GetIdCarritoDeCompras()
        {
            if (dgvProductosCompra.Rows.Count == 0)
                return null;

            if (dgvProductosCompra.CurrentRow == null)
                return null;

            var valor = dgvProductosCompra.CurrentRow.Cells[0].Value;

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

            if (clientes != null)
            {
                cmbRazonSocial.DataSource = clientes;
                cmbRazonSocial.DisplayMember = "RazonSocial";
                cmbRazonSocial.ValueMember = "IDCliente";
            }
        }



        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int? idProducto = GetId();

            var producto = controladoraProductos.BuscarProductoId((int)idProducto);

            if (idProducto != null && producto.Stock > 0)
            {
                LimitarCantidad((int)idProducto);
                dgvProductosSucursal.Enabled = false;
                nudCantidad.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR: Seleccione un producto y asegurese de que tenga stock");
            }

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad != null || nudCantidad.Value == 0)
            {
                btnAgregarACarrito.Enabled = true;
            }
            else
            {
                btnAgregarACarrito.Enabled = false;
            }
        }

        private void dtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvProductosCompra.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto del carrito.");
                return;
            }

            int? idProducto = GetIdCarritoDeCompras();
            if (idProducto != null)
            {
                var producto = controladoraProductos.BuscarProductoId((int)idProducto);

                if (producto != null)
                {
                    Producto productoSeleccionado = (Producto)dgvProductosCompra.CurrentRow.DataBoundItem;
                    productosCarrito.Remove(productoSeleccionado);
                    dgvProductosCompra.DataSource = null;
                    dgvProductosCompra.DataSource = productosCarrito;
                    ProductoDisponibles.Add(producto);
                    dgvProductosSucursal.DataSource = null;
                    dgvProductosSucursal.DataSource = ProductoDisponibles;

                    foreach (var detalle in productosVenta.ToList())
                    {
                        if (detalle.IDProducto == producto.IDProducto && detalle.IDVenta == venta.IDVenta)
                        {
                            productosVenta.Remove(detalle);
                        }
                    }
                }

                CalcularTotal(Total);
            }

        }

        

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked || rbTarjeta.Checked || rbTransferencia.Checked && txtVendedor.Text.Length > 0)
            {
                grpProductos.Enabled = true;
                grpCarritoDeCompras.Enabled = true;
                groupBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione un metodo de pago y complete el campo vendedor para continuar.");
                return;

            }
        }
    }
}
