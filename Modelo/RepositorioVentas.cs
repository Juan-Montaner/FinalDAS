using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVentas
    {
        private Context context;

        public RepositorioVentas()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Venta> ListarVentas()
        {
            return context.Ventas.ToList().AsReadOnly();
        }

        public void AgregarVenta(Venta venta)
        {
            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        public void EliminarVentas(Venta venta)
        {
            context.Ventas.Remove(venta);
            context.SaveChanges();
        }

        public Venta BuscarVentaID(int id)
        {
            return context.Ventas.FirstOrDefault(c => c.IDVenta == id);
        }

        public Venta BuscarVenta(DateTime fecha)
        {
            return context.Ventas.FirstOrDefault(c => c.Fecha == fecha);
        }

        public List<Venta> FiltrarVentasRazonSocial(string razonSocial)
        {
            return context.Ventas.Where(v => v.RazonSocialCliente == razonSocial).ToList(); ;
        }

    }
}
