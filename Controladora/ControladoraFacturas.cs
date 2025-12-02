using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraFacturas
    {
        private RepositorioFacturas repositorioFactura = new RepositorioFacturas();
        private static ControladoraFacturas instancia;

        public static ControladoraFacturas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraFacturas();
                }
                return instancia;
            }
        }

        public string AgregarFacturas(string RazonSocialCliente, DateTime Fecha, List<Producto> ListaProductos, int MetodoPago, long Total)
        {


            if (string.IsNullOrWhiteSpace(RazonSocialCliente) || int.IsNegative(MetodoPago))
            {
                return "Error al AGREGAR FACTURAS: Los campos no pueden estar vacios";
            }

            Factura nuevaFactura = new Factura();

            nuevaFactura.RazonSocialCliente = RazonSocialCliente;
            nuevaFactura.Fecha = Fecha;
            nuevaFactura.Productos = ListaProductos;
            
            nuevaFactura.Total = Total;

            repositorioFactura.AgregarFactura(nuevaFactura);

            return "Factura Nueva Agregada con Exito";
        }

        public string EliminarFactura(int id)
        {
            Factura factura = repositorioFactura.BuscarFacturaID(id);

            if (factura == null)
            {
                return "Error al ELIMINAR la Factura: El ID de factura no existe";
            }

            repositorioFactura.EliminarFactura(factura);

            return "Factura Eliminada con Exito";
        }

        public string ModificarFactura(int id, string RazonSocialCliente, DateTime Fecha, List<Producto> ListaProductos, int MetodoPago, long Total)
        {
            Factura factura = repositorioFactura.BuscarFacturaID(id);

            if (factura == null)
            {
                return "Error al MODIFICAR la Factura: La Factura NO existe";
            }

            if (string.IsNullOrWhiteSpace(RazonSocialCliente) || int.IsNegative(MetodoPago))
            {
                return "Error al MODIFICAR la Factura: Los campos no pueden estar vacios";
            }

            factura.RazonSocialCliente = RazonSocialCliente;
            factura.Fecha = Fecha;
            factura.Productos = ListaProductos;
            factura.Total = Total;

            repositorioFactura.ModificarFactura(factura);

            return "Factura Modificado con Exito";
        }

        public Factura BuscarFacturaId(int id)
        {
            return repositorioFactura.BuscarFacturaID(id);
        }


    }
}
