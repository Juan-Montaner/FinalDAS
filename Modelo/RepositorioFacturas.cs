using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioFacturas
    {
        // Llamada al context 
        private Context context;

        public RepositorioFacturas()
        {
            context = new Context();
        }

        // Metodo que devuelve una lista de las facturas
        public IReadOnlyCollection<Factura> ListarFacturas()
        {
            return context.Facturas.ToList().AsReadOnly();
        }

        // Metodo que agrega una factura a la base de datos 
        public void AgregarFactura(Factura factura)
        {
            context.Facturas.Add(factura);
            context.SaveChanges();
        }

        // Metodo que modifica una factura de la base de datos 
        public void ModificarFactura(Factura factura)
        {
            context.Facturas.Update(factura);
            context.SaveChanges();
        }

        // Metodo que elimina una factura de la base de datos 
        public void EliminarFactura(Factura factura)
        {
            context.Facturas.Remove(factura);
            context.SaveChanges();
        }

        // Metodo que busca una factura en la base mediante la razon social del cliente que la pago
        public Factura BuscarFactura(string RazonSocialCliente)
        {
            return context.Facturas.FirstOrDefault(c => c.RazonSocialCliente == RazonSocialCliente);
        }

        // Metodo que busca una factura en la base mediante su ID 
        public Factura BuscarFacturaID(int id)
        {
            return context.Facturas.FirstOrDefault(c => c.IDFactura == id);
        }
    }
}
