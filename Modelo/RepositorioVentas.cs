using Entidades;
using Microsoft.EntityFrameworkCore;
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

        public List<Producto> ProductosMasVendidos()
        {
            var grouped = context.DetallesVentas.GroupBy(d => d.IDProducto).Select(g => new
            {
                IDProducto = g.Key,
                CantidadVendida = g.Sum(x => x.Cantidad)
            }).OrderByDescending(x => x.CantidadVendida);

            var productos = grouped.Join(context.Productos, g => g.IDProducto, p => p.IDProducto, (g, p) => p).ToList();

            return productos;
        }

        public int CantidadVendidaProducto(int idProducto)
        {
            return context.DetallesVentas.Where(d => d.IDProducto == idProducto).Sum(d => d.Cantidad);
        }

        public Venta BuscarVentaIDDetalles(int idVenta)
        {
            return context.Ventas.Include(v => v.Detalles).ThenInclude(d => d.Producto).FirstOrDefault(v => v.IDVenta == idVenta);
        }

        public List<Venta> FiltrarVentasPorPeriodo(DateTime inicio, DateTime fin)
        {
            return context.Ventas.Where(c => c.Fecha.Date >= inicio.Date && c.Fecha.Date <= fin.Date).ToList();
        }


        public List<Venta> FiltrarVentasPorSucursal(int idSucursal)
        {
            return context.Ventas.Where(c => c.IDSucursal == idSucursal).ToList();
        }

        public List<Venta> FiltrarVentasPorVendedor(string Nombre)
        {
            return context.Ventas.Where(c => c.Vendedor == Nombre).ToList();
        }

        public List<Venta> FiltrarVentasPorProducto(int idProducto)
        {
            return context.DetallesVentas.Where(d => d.IDProducto == idProducto).Select(d => d.Venta).Distinct().ToList();
        }

    }
}