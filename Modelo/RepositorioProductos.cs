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
        // Llamada al context 
        private Context context;

        public RepositorioProductos()
        {
            context = new Context();
        }

        // Metodo que devuelve una lista de los productos
        public IReadOnlyCollection<Producto> ListarProducto()
        {
            return context.Productos.ToList().AsReadOnly();
        }

        // Metodo que agrega un producto a la base de datos 
        public void AgregarProducto(Producto producto)
        {
            context.Productos.Add(producto);
            context.SaveChanges();
        }

        // Metodo que modifica un producto de la base de datos 
        public void ModificarProducto(Producto producto)
        {
            context.Productos.Update(producto);
            context.SaveChanges();
        }

        // Metodo que elimina un producto de la base de datos 
        public void EliminarProducto(Producto producto)
        {
            context.Productos.Remove(producto);
            context.SaveChanges();
        }

        // Metodo que busca un producto en la base mediante su nombre 
        public Producto BuscarProducto(string nombre)
        {
            return context.Productos.FirstOrDefault(c => c.Nombre == nombre);
        }

        // Metodo que busca un producto en la base mediante su ID 
        public Producto BuscarProductoID(int id)
        {
            return context.Productos.FirstOrDefault(c => c.IDProducto == id);
        }

        // Metodo que busca productos mediante su categoria 
        public Producto CategoriasConProductos(string categoria)
        {
            return context.Productos.FirstOrDefault(p => p.Categoria == categoria);
        }
    }
}
