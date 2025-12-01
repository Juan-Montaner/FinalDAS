using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioProductos
    {

        private Context context;

        public RepositorioProductos()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Producto> ListarProducto()
        {
            return context.Productos.ToList().AsReadOnly();
        }

        public void AgregarProducto(Producto producto)
        {
            context.Productos.Add(producto);
            context.SaveChanges();
        }

        public void ModificarProducto(Producto producto)
        {
            context.Productos.Update(producto);
            context.SaveChanges();
        }

        public void EliminarProducto(Producto producto)
        {
            context.Productos.Remove(producto);
            context.SaveChanges();
        }

    }
}
