using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVentas
    {
        // Declaracion repositorios  y controladoras en uso 
        private RepositorioVentas repositorioVentas = new RepositorioVentas();
        private static ControladoraVentas instancia;

        #region Patron Singleton
        public static ControladoraVentas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraVentas();
                }
                return instancia;
            }
        }
        #endregion

        // Metodo que valida y llama al repositorio para agregar una venta
        public string AgregarVentas(string RazonSocialCliente, DateTime Fecha, List<DetalleVenta> ListaProductos, int IdSucursal, string Vendedor, int MetodoPago, decimal Total)
        {

            // Validacion de que los campos esten completados y que los valores no sean negativos
            if (string.IsNullOrWhiteSpace(RazonSocialCliente) || int.IsNegative(IdSucursal) || int.IsNegative(MetodoPago) || string.IsNullOrWhiteSpace(Vendedor))
            {
                return "Error al AGREGAR la venta: Los campos no pueden estar vacios";
            }

            Venta nuevaVenta = new Venta();

            nuevaVenta.RazonSocialCliente = RazonSocialCliente;
            nuevaVenta.Fecha = Fecha;
            nuevaVenta.IDSucursal = IdSucursal;
            nuevaVenta.Vendedor = Vendedor;
            nuevaVenta.Total = Total;

            nuevaVenta.Detalles = ListaProductos;

            foreach (var det in nuevaVenta.Detalles)
            {
                det.Venta = nuevaVenta;
            }

            nuevaVenta.MetodoDePago = (Venta.MetodoPago)MetodoPago;

            repositorioVentas.AgregarVenta(nuevaVenta);

            return "Venta agregada con exito";
        }

        // Metodo que valida y llama al repositorio para eliminar una venta
        public string EliminarVenta(int id)
        {
            Venta venta = repositorioVentas.BuscarVentaID(id);

            // Validacion de que exista la venta que se quiere eliminar
            if (venta == null)
            {
                return "Error al ELIMINAR la venta: La venta no existe";
            }

            repositorioVentas.EliminarVentas(venta);

            return "Venta eliminada con exito";
        }

        // Metodo que permite buscar una venta mediante un ID 
        public Venta BuscarVentaId(int id)
        {
            return repositorioVentas.BuscarVentaID(id);
        }

        // Metodo que permite buscar una venta mediante una fecha
        public Venta BuscarVentaFecha(DateTime fecha)
        {
            return repositorioVentas.BuscarVenta(fecha);
        }

        // Metodo que devuelve una lista de las ventas disponibles
        public List<Venta> ListarVentas()
        {
            return repositorioVentas.ListarVentas().ToList();
        }

        // Metodo que permite filtrar las ventas por un rango de fechas
        public List<Venta> FiltrarVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            var todasLasVentas = repositorioVentas.ListarVentas();
            var ventasFiltradas = todasLasVentas.Where(v => v.Fecha >= fechaInicio && v.Fecha <= fechaFin).ToList();
            return ventasFiltradas;
        }

        // Metodo que permite filtrar las ventas por razon social
        public List<Venta> FiltrarVentasRazonSocial(string razonSocial)
        {
            return repositorioVentas.FiltrarVentasRazonSocial(razonSocial);

        }

        // Metodo que devuelve una lista de los productos mas vendidos
        public List<Producto> ProductosMasVendidos()
        {
            return repositorioVentas.ProductosMasVendidos();
        }

        // Metodo que devuelve la cantidad vendida de un producto
        public int CantidadVendidaProducto(int idProducto)
        {
            return repositorioVentas.CantidadVendidaProducto(idProducto);
        }

        // Metodo que permite buscar una venta por ID con sus detalles
        public Venta BuscarVentaIDDetallesBuscarDatId(int idVenta)
        {
            return repositorioVentas.BuscarVentaIDDetalles(idVenta);
        }

        // Metodo que permite filtrar las ventas por periodo de tiempo
        public List<Venta> FiltrarVentasPorPeriodo(DateTime tiempoInicio, DateTime tiempoHasta)
        {
            return repositorioVentas.FiltrarVentasPorPeriodo(tiempoInicio, tiempoHasta);
        }

        // Metodo que permite filtrar las ventas por sucursal
        public List<Venta> FiltrarVentasPorSucursal(int idSucursal)
        {
            return repositorioVentas.FiltrarVentasPorSucursal(idSucursal);
        }

        // Metodo que permite filtrar las ventas por vendedor
        public List<Venta> FiltrarVentasPorVendedor(string Nombre)
        {
            return repositorioVentas.FiltrarVentasPorVendedor(Nombre);
        }

        // Metodo que permite filtrar las ventas por producto
        public List<Venta> FiltrarVentasPorProducto(int idProducto)
        {
            return repositorioVentas.FiltrarVentasPorProducto(idProducto);
        }
    }
}
