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
        // Llamada al context 
        private Context context;

        public RepositorioVentas()
        {
            context = new Context();
        }

        // Metodo que devuelve una lista de las ventas
        public IReadOnlyCollection<Venta> ListarVentas()
        {
            return context.Ventas.ToList().AsReadOnly();
        }

        // Metodo que agrega una venta a la base de datos 
        public void AgregarVenta(Venta venta)
        {
            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        // Metodo que elimina una venta de la base de datos 
        public void EliminarVentas(Venta venta)
        {
            context.Ventas.Remove(venta);
            context.SaveChanges();
        }

        // Metodo que busca una venta en la base mediante su ID 
        public Venta BuscarVentaID(int id)
        {
            return context.Ventas.FirstOrDefault(c => c.IDVenta == id);
        }

        // Metodo que busca una venta en la base mediante su fecha de emision
        public Venta BuscarVenta(DateTime fecha)
        {
            return context.Ventas.FirstOrDefault(c => c.Fecha == fecha);
        }

        // Metodo que filtra las ventas por la razon social del cliente que compro
        public List<Venta> FiltrarVentasRazonSocial(string razonSocial)
        {
            return context.Ventas.Where(v => v.RazonSocialCliente == razonSocial).ToList(); ;
        }

        // Metodo que devuelve una lista de los productos mas vendidos 
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

        // Metodo que devuelve la cantidad vendida de un producto en especifico utilizando su ID
        public int CantidadVendidaProducto(int idProducto)
        {
            return context.DetallesVentas.Where(d => d.IDProducto == idProducto).Sum(d => d.Cantidad);
        }

        // Metodo que busca una venta con sus detalles mediante su ID 
        public Venta BuscarVentaIDDetalles(int idVenta)
        {
            return context.Ventas.Include(v => v.Detalles).ThenInclude(d => d.Producto).FirstOrDefault(v => v.IDVenta == idVenta);
        }

        // Metodo que filtra las ventas por un periodo de tiempo 
        public List<Venta> FiltrarVentasPorPeriodo(DateTime inicio, DateTime fin)
        {
            return context.Ventas.Where(c => c.Fecha.Date >= inicio.Date && c.Fecha.Date <= fin.Date).ToList();
        }

        // Metodo que filtra las ventas por sucursal 
        public List<Venta> FiltrarVentasPorSucursal(int idSucursal)
        {
            return context.Ventas.Where(c => c.IDSucursal == idSucursal).ToList();
        }

        // Metodo que filtra las ventas por vendedor 
        public List<Venta> FiltrarVentasPorVendedor(string Nombre)
        {
            return context.Ventas.Where(c => c.Vendedor == Nombre).ToList();
        }

        // Metodo que filtra las ventas por producto 
        public List<Venta> FiltrarVentasPorProducto(int idProducto)
        {
            return context.DetallesVentas.Where(d => d.IDProducto == idProducto).Select(d => d.Venta).Distinct().ToList();
        }
    }
}
