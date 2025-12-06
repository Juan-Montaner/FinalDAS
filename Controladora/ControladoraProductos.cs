using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {
        // Declaracion repositorios  y controladoras en uso 
        private RepositorioProductos repositorioProductos = new RepositorioProductos();
        private RepositorioSucursales repositorioSucursales = new RepositorioSucursales();
        private static ControladoraProductos instancia;

        #region Patron Singleton
        public static ControladoraProductos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraProductos();
                }
                return instancia;
            }
        }
        #endregion

        // Metodo que valida y llama al repositorio para agregar un producto
        public string AgregarProducto(string nombre, string descripcion, string categoria, int idsucursal, decimal precio, int stock)
        {
            Producto producto = repositorioProductos.BuscarProducto(nombre);

            // Validacion de que no exista ese producto previamente
            if (producto != null)
            {
                return "Error al AGREGAR PRODUCTO: El producto ya existe";
            }

            // Validacion de que los campos esten completados y que los valores no sean negativos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || decimal.IsNegative(precio) || int.IsNegative(stock))
            {
                return "Error al AGREGAR Producto: Los campos no pueden estar vacios";
            }

            Producto nuevoProducto = new Producto();

            nuevoProducto.Nombre = nombre;
            nuevoProducto.Descripcion = descripcion;
            nuevoProducto.Categoria = categoria;
            nuevoProducto.IDSucursal = idsucursal;
            nuevoProducto.Precio = precio;
            nuevoProducto.Stock = stock;

            repositorioProductos.AgregarProducto(nuevoProducto);

            return "Producto Agregado con Exito";
        }

        // Metodo que valida y llama al repositorio para eliminar un producto
        public string EliminarProducto(int id)
        {
            Producto producto = repositorioProductos.BuscarProductoID(id);

            // Validacion de que exista el producto que se quiere eliminar
            if (producto == null)
            {
                return "Error al ELIMINAR EL PRODUCTO: El Producto no existe";
            }

            repositorioProductos.EliminarProducto(producto);

            return "Producto Eliminado con Exito";
        }

        // Metodo que valida y llama al repositorio para modificar un producto
        public string ModificarProducto(int id, string nombre, string descripcion, string categoria, int idsucursal, decimal precio, int stock)
        {
            Producto producto = repositorioProductos.BuscarProductoID(id);

            // Validacion de que exista el producto que se quiere modificar
            if (producto == null)
            {
                return "Error al MODIFICAR EL PRODUCTO: El Producto no existe";
            }

            // Validacion de que los campos esten completados y que los valores no sean negativos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || decimal.IsNegative(precio) || int.IsNegative(stock))
            {
                return "Error al MODIFICAR El PRODUCTO: Los campos no pueden estar vacios";
            }

            producto.Nombre = nombre;
            producto.Descripcion = descripcion;
            producto.Categoria = categoria;
            producto.IDSucursal = idsucursal;
            producto.Precio = precio;
            producto.Stock = stock;

            repositorioProductos.ModificarProducto(producto);

            return "Producto Modificado con Exito";
        }

        // Metodo que devuelve una lista de los productos disponibles
        public List<Producto> ListarProductos()
        {
            return repositorioProductos.ListarProducto().ToList();
        }

        // Metodo que permite buscar un producto mediante un ID 
        public Producto BuscarProductoId(int id)
        {
            return repositorioProductos.BuscarProductoID(id);
        }

        // Metodo que permite filtrar los productos por categoria
        public List<Producto> FiltrarPorCategoria(string categoria)
        {
            return repositorioProductos.ListarProducto().Where(c => c.Categoria == categoria).ToList();
        }

        // Metodo que permite filtrar los productos por sucursal
        public List<Producto> FiltrarPorSucursales(int? IdSucursal)
        {
            return repositorioProductos.ListarProducto().Where(c => c.IDSucursal == IdSucursal).ToList();
        }

        // Metodo que permite agregar un producto al carrito
        public Producto AgregarProductoCarrito(Producto producto, int cantidad)
        {
            Producto nuevoProductoCarrito = new Producto();

            nuevoProductoCarrito.IDProducto = producto.IDProducto;
            nuevoProductoCarrito.Nombre = producto.Nombre;
            nuevoProductoCarrito.Descripcion = producto.Descripcion;
            nuevoProductoCarrito.Categoria = producto.Categoria;
            nuevoProductoCarrito.IDSucursal = producto.IDSucursal;
            nuevoProductoCarrito.Precio = producto.Precio;
            nuevoProductoCarrito.Stock = cantidad;

            return nuevoProductoCarrito;
        }
    }
}
