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
        private RepositorioProductos repositorioProductos = new RepositorioProductos();
        private static ControladoraProductos instancia;

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

        public string AgregarProducto(string nombre, string descripcion, string categoria, decimal precio, int stock)
        {
            Producto producto = repositorioProductos.BuscarProducto(nombre);

            if (producto != null)
            {
                return "Error al AGREGAR PRODUCTRO: El producto ya existe";
            }

            // NO PUDE HACER LO DE LA CATEGORIA QUE SE AGREGUE SI O SI, FALTARIA AGREGARLO
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || decimal.IsNegative(precio) || int.IsNegative(stock))
            {
                return "Error al AGREGAR Producto: Los campos no pueden estar vacios";
            }



            Producto nuevoProducto = new Producto();

            nuevoProducto.Nombre = nombre;
            nuevoProducto.Descripcion = descripcion;
            nuevoProducto.Categoria = categoria;
            nuevoProducto.Precio = precio;
            nuevoProducto.Stock =  stock;

            repositorioProductos.AgregarProducto(nuevoProducto);

            return "Producto Agregado con Exito";
        }

        public string EliminarProducto(int id)
        {
            Producto producto = repositorioProductos.BuscarProductoID(id);

            if (producto == null)
            {
                return "Error al ELIMINAR EL PRODUCTO: El Producto no existe";
            }

            repositorioProductos.EliminarProducto(producto);

            return "Producto ELIMINADO con Exito";
        }

        public string ModificarProducto(int id, string nombre, string descripcion, string categoria, decimal precio, int stock)
        {
            Producto producto = repositorioProductos.BuscarProductoID(id);

            if (producto == null)
            {
                return "Error al MODIFICAR EL PRODUCTO: El Producto NO existe";
            }

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || decimal.IsNegative(precio) || int.IsNegative(stock))
            {
                return "Error al Modificar El PRODUCTO: Los campos no pueden estar vacios";
            }

            producto.Nombre = nombre;
            producto.Descripcion = descripcion;
            producto.Categoria = categoria;
            producto.Precio = precio;
            producto.Stock = stock;


            repositorioProductos.ModificarProducto(producto);

            return "Producto Modificada con Exito";
        }

        public List<Producto> ListarProductos()
        {
            return repositorioProductos.ListarProducto().ToList();
        }

        public Producto BuscarProductoId(int id)
        {
            return repositorioProductos.BuscarProductoID(id);
        }


    }
}
