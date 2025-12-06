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
        // Delcaracion de controladoras en uso
        private int? iDSucursal;
        Controladora.ControladoraVentas controladoraVentas = Controladora.ControladoraVentas.Instancia;
        Controladora.ControladoraProductos controladoraProductos = Controladora.ControladoraProductos.Instancia;
        Controladora.ControladoraClientes controladoraClientes = Controladora.ControladoraClientes.Instancia;
        Controladora.ControladoraFacturas controladoraFacturas = Controladora.ControladoraFacturas.Instancia;

        // Declaracion de listas en uso
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
            CargarCmbVendedores();
            PintarEncabezadosSucursal();
            PintarEncabezadosCompra();

            // Inhabilitacion de botones para reducir errores en el uso del programa
            nudCantidad.Enabled = false;
            btnAgregarACarrito.Enabled = false;
            grpCarritoDeCompras.Enabled = false;
            grpProductos.Enabled = false;
        }

        // Detalles visuales Data Grid View
        private void PintarEncabezadosCompra()
        {

            dgvProductosCompra.EnableHeadersVisualStyles = false;


            foreach (DataGridViewColumn col in dgvProductosCompra.Columns)
            {

                col.HeaderCell.Style.Font = new Font(dgvProductosCompra.Font, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.White;
                col.HeaderCell.Style.BackColor = Color.SteelBlue;


            }
            dgvProductosCompra.Refresh();
        }

        // Detalles visuales Data Grid View
        private void PintarEncabezadosSucursal()
        {

            dgvProductosSucursal.EnableHeadersVisualStyles = false;


            foreach (DataGridViewColumn col in dgvProductosSucursal.Columns)
            {

                col.HeaderCell.Style.Font = new Font(dgvProductosSucursal.Font, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.White;
                col.HeaderCell.Style.BackColor = Color.SteelBlue;


            }
            dgvProductosSucursal.Refresh();
        }

        // Se limita la cantidad maxima de stock que se puede solicitar para comprar segun el stock del producto
        private void LimitarCantidad(int idProducto)
        {
            var producto = controladoraProductos.BuscarProductoId(idProducto);

            nudCantidad.Maximum = producto.Stock;
        }

        // Botn que permite volver al formulario de gestion de ventas
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionVentas formGestionVentas = new FormGestionVentas();
            this.Close();
            formGestionVentas.ShowDialog();
        }

        // Metodo que carga el Data Grid View con los products de la sucursal
        private void CargarDgvSucursal()
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvProductosSucursal.DataSource = controladora.FiltrarPorSucursales(iDSucursal);
            ProductoDisponibles = controladora.FiltrarPorSucursales(iDSucursal);
        }

        // Boton que agrega un producto seleccionado en el carrito
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

            PintarEncabezadosSucursal();
            PintarEncabezadosCompra();
            dgvProductosSucursal.Enabled = true;
            nudCantidad.Enabled = false;
            nudCantidad.Value = 0;
            btnAgregarACarrito.Enabled = false;
        }

        // Boton que finaliza la compra
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string razonSocial = cmbRazonSocial.Text;
            DateTime Fecha = dtpFechaVenta.Value;
            string vendedor = cmbVendedor.Text;
            int cantidadProductosTotales = 0;
            bool aptoParaComprar;

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
            else if (rbCuentaCorriente.Checked == true)
            {
                MetodoDePago = 4;
            }

            var cliente = controladoraClientes.BuscarCliente(razonSocial);

            if (cliente.TipoCliente == true && cantidadProductosTotales >= 150 || cliente.TipoCliente == false && cantidadProductosTotales < 150)
            {
                aptoParaComprar = true;
            }
            else
            {
                aptoParaComprar = false;
            }

            if (aptoParaComprar == true)
            {
                foreach (var detalle in productosVenta)
                {
                    var producto = controladoraProductos.BuscarProductoId(detalle.IDProducto);

                    producto.Stock = producto.Stock - detalle.Cantidad;
                    cantidadProductosTotales = detalle.Cantidad;
                    controladoraProductos.ModificarProducto(producto.IDProducto, producto.Nombre, producto.Descripcion, producto.Categoria, producto.IDSucursal, producto.Precio, producto.Stock);
                }
            }

            if (aptoParaComprar == true && productosVenta.Count > 0)
            {
                controladoraVentas.AgregarVentas(razonSocial, Fecha, productosVenta, (int)iDSucursal, vendedor, MetodoDePago, Total);

                var ventaRecien = controladoraVentas.BuscarVentaFecha(Fecha);

                controladoraFacturas.AgregarFacturas(razonSocial, Fecha, MetodoDePago, Total, ventaRecien.IDVenta);

                if (MetodoDePago == 4)
                {
                    cliente.CuentaCorriente = cliente.CuentaCorriente - this.Total;

                }

                controladoraClientes.ModificarCliente(cliente.IDCliente, cliente.RazonSocial, cliente.Telefono, cliente.Mail, cliente.TipoCliente, cliente.CuentaCorriente);

                MessageBox.Show("Venta realizada con exito.");

                this.Hide();
                FormGestionVentas formGestionVentas = new FormGestionVentas();
                this.Close();
                formGestionVentas.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cumple con los requisitos para realizar la compra, los clientes mayoristas deben comprar al menos 150 productos, Los clientes minoristas no pueden comprar 150 o más productos, No se puede tener el carrito Vacio.");
            }


        }

        // Metodo que calcula el total de la venta teniendo en cuenta el descuento por tipo de cliente
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

        // Metodo que obtiene el ID de el producto seleccionado en el Data Grid View de sucursal
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

        // Metodo que obtiene el ID de el producto seleccionado en el Data Grid View de carrito
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

        // Metodo que carga el Combo Box de clientes
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

        // Metodo que carga el Combo Box de vendedores
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

        // Boton que fija el producto seleccionado en el Data Grid View de productos de la sucursal
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

        // Control que permite poner la cantidad deseada de un producto para comprar
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad != null || nudCantidad.Value > 0)
            {
                btnAgregarACarrito.Enabled = true;
            }
            else
            {
                btnAgregarACarrito.Enabled = false;
            }
        }

        // Boton que elimina un producto seleccionado
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

                PintarEncabezadosSucursal();
                PintarEncabezadosCompra();
                CalcularTotal(Total);
            }

        }

        // Boton que permite comenzar una venta
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked || rbTarjeta.Checked || rbTransferencia.Checked || rbCuentaCorriente.Checked)
            {
                grpProductos.Enabled = true;
                grpCarritoDeCompras.Enabled = true;
                gbCuentaCorriente.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione un metodo de pago y complete el campo vendedor para continuar.");
                return;

            }
        }

        // Metodo que formatea el Data Grid View de los productos de la sucursal
        private void dgvProductosSucursal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductosSucursal.Columns[e.ColumnIndex].Name == "Stock" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int stock))
                {
                    var cell = dgvProductosSucursal.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cell.Style.Font = new Font(dgvProductosSucursal.Font, FontStyle.Bold);

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

        // Metodo que formatea el Data Grid View de los productos de el carrito de compras
        private void dgvProductosCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductosCompra.Columns[e.ColumnIndex].Name == "Stock" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int stock))
                {
                    var cell = dgvProductosCompra.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cell.Style.Font = new Font(dgvProductosCompra.Font, FontStyle.Bold);

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
