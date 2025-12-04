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

            return "VENTA nueva Agregada con Exito";
        }

        public string EliminarVenta(int id)
        {
            Venta venta = repositorioVentas.BuscarVentaID(id);

            if (venta == null)
            {
                return "Error al ELIMINAR La VENTA: La venta no existe";
            }

            repositorioVentas.EliminarVentas(venta);

            return "VENTA Eliminada con Exito";
        }

        

        public Venta BuscarVentaId(int id)
        {
            return repositorioVentas.BuscarVentaID(id);
        }

        public Venta BuscarVenta(DateTime fecha)
        {
            return repositorioVentas.BuscarVenta(fecha);
        }

        public List<Venta> ListarVentas()
        {
            return repositorioVentas.ListarVentas().ToList();
        }
    }
}
