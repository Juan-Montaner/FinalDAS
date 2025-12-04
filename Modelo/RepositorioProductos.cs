using Entidades;
using System;
using System.Collections;
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

        public Producto BuscarProducto(string nombre)
        {
            return context.Productos.FirstOrDefault(c => c.Nombre == nombre);
        }

        public Producto BuscarProductoID(int id)
        {
            return context.Productos.FirstOrDefault(c => c.IDProducto == id);
        }

        public Producto CategoriasConProductos(string categoria)
        {
            return context.Productos.FirstOrDefault(p => p.Categoria == categoria); 
        }
    }
}
