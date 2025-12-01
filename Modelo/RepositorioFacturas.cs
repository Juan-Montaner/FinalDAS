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
        private Context context;

        public RepositorioFacturas()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Factura> ListarFacturas()
        {
            return context.Facturas.ToList().AsReadOnly();
        }

        public void AgregarFactura(Factura factura)
        {
            context.Facturas.Add(factura);
            context.SaveChanges();
        }

        public void ModificarFactura(Factura factura)
        {
            context.Facturas.Update(factura);
            context.SaveChanges();
        }

        public void EliminarFactura(Factura factura)
        {
            context.Facturas.Remove(factura);
            context.SaveChanges();
        }

    }
}
