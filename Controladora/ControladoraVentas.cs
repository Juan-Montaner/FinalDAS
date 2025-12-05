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
        private RepositorioVentas repositorioVentas = new RepositorioVentas();
        private static ControladoraVentas instancia;

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

        public string AgregarVentas(string RazonSocialCliente, DateTime Fecha, List<DetalleVenta> ListaProductos, int IdSucursal, string Vendedor, int MetodoPago, decimal Total)
        {

            if (string.IsNullOrWhiteSpace(RazonSocialCliente) || int.IsNegative(IdSucursal) || int.IsNegative(MetodoPago) || string.IsNullOrWhiteSpace(Vendedor))
            {
                return "Error al AGREGAR Venta: Los campos no pueden estar vacios";
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
                det.Venta = nuevaVenta; // <-- CORRECCIÓN CLAVE
            }

            nuevaVenta.MetodoDePago = (Venta.MetodoPago)MetodoPago;

            repositorioVentas.AgregarVenta(nuevaVenta);

            return "Nueva VENTA agregada con exito";
        }

        public string EliminarVenta(int id)
        {
            Venta venta = repositorioVentas.BuscarVentaID(id);

            if (venta == null)
            {
                return "Error al ELIMINAR La VENTA: La venta no existe";
            }

            repositorioVentas.EliminarVentas(venta);

            return "VENTA eliminada con exito";
        }
        public Venta BuscarVentaId(int id)
        {
            return repositorioVentas.BuscarVentaID(id);
        }

        public Venta BuscarVentaFecha(DateTime fecha)
        {
            return repositorioVentas.BuscarVenta(fecha);
        }

        public List<Venta> ListarVentas()
        {
            return repositorioVentas.ListarVentas().ToList();
        }

        public List<Venta> FiltrarVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            var todasLasVentas = repositorioVentas.ListarVentas();
            var ventasFiltradas = todasLasVentas.Where(v => v.Fecha >= fechaInicio && v.Fecha <= fechaFin).ToList();
            return ventasFiltradas;
        }

        public List<Venta> FiltrarVentasRazonSocial(string razonSocial)
        {
            return repositorioVentas.FiltrarVentasRazonSocial(razonSocial);

        }

        public List<Producto> ProductosMasVendidos()
        {
            return repositorioVentas.ProductosMasVendidos();
        }

        public int CantidadVendidaProducto(int idProducto)
        {
            return repositorioVentas.CantidadVendidaProducto(idProducto);
        }

        public Venta BuscarVentaPorId(int idVenta)
        {
            return repositorioVentas.BuscarVentaIDDetalles(idVenta);
        }

        public List<Venta> FiltrarVentasPorPeriodo(DateTime tiempoInicio, DateTime tiempoHasta)
        {
            return repositorioVentas.FiltrarVentasPorPeriodo(tiempoInicio, tiempoHasta);
        }

        public List<Venta> FiltrarVentasPorSucursal(int idSucursal)
        {
            return repositorioVentas.FiltrarVentasPorSucursal(idSucursal);
        }

        public List<Venta> FiltrarVentasPorVendedor(string Nombre)
        {
            return repositorioVentas.FiltrarVentasPorVendedor(Nombre);
        }

        public List<Venta> FiltrarVentasPorProducto(int idProducto)
        {
            return repositorioVentas.FiltrarVentasPorProducto(idProducto);
        }

    }
}