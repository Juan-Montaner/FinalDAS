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

        public string AgregarVentas(string RazonSocialCliente, DateTime Fecha, List<Producto> ListaProductos, int IdSucursal, string Vendedor, int MetodoPago, long Total)
        {

            if (string.IsNullOrWhiteSpace(RazonSocialCliente) || int.IsNegative(IdSucursal) || int.IsNegative(MetodoPago) || string.IsNullOrWhiteSpace(Vendedor))
            {
                return "Error al AGREGAR Venta: Los campos no pueden estar vacios";
            }

            Venta nuevaVenta = new Venta();

            nuevaVenta.RazonSocialCliente = RazonSocialCliente;
            nuevaVenta.Fecha = Fecha;
            nuevaVenta.Productos = ListaProductos;
            nuevaVenta.IDSucursal = IdSucursal;
            nuevaVenta.Vendedor = Vendedor;
            nuevaVenta.Total = Total;

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

        public string ModificarVenta(int id, string RazonSocialCliente, DateTime Fecha, List<Producto> ListaProductos, int IdSucursal, string Vendedor, int MetodoPago, long Total)
        {
            Venta venta = repositorioVentas.BuscarVentaID(id);

            if (venta == null)
            {
                return "Error al MODIFICAR LA VENTA: La VENTA NO existe";
            }

            if (string.IsNullOrWhiteSpace(RazonSocialCliente) || int.IsNegative(IdSucursal) || int.IsNegative(MetodoPago) || string.IsNullOrWhiteSpace(Vendedor))
            {
                return "Error al MODIFICAR LA VENTA: Los campos no pueden estar vacios";
            }

            venta.RazonSocialCliente = RazonSocialCliente;
            venta.Fecha = Fecha;
            venta.Productos = ListaProductos;
            venta.IDSucursal = IdSucursal;
            venta.Vendedor = Vendedor;
            venta.Total = Total;

            repositorioVentas.ModificarVenta(venta);

            return "Venta Modificada con Exito";
        }

        public Venta BuscarVentaId(int id)
        {
            return repositorioVentas.BuscarVentaID(id);
        }

    }
}
