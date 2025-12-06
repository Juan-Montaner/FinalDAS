using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
    {
        // Declaracion repositorios  y controladoras en uso 
        private RepositorioCategorias repositorioCategoria = new RepositorioCategorias();
        private RepositorioProductos repositorioProductos = new RepositorioProductos(); 
        private static ControladoraCategorias instancia;

        #region Patron Singleton
        public static ControladoraCategorias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraCategorias();
                }

                return instancia;
            }
        }
        #endregion

        // Metodo que valida y llama al repositorio para agregar una categoria
        public string AgregarCategoria(string nombre)
        {
            Categoria categoria = repositorioCategoria.BuscarCategoria(nombre);
            
            // Validacion de que no exista esa categoria previamente
            if(categoria != null)
            {
                return "Error al AGREGAR CATEGORIA: La categoria ya existe";
            }

            // Validacion de que el campo del nombre de la categoria este completado
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "Error al AGREGAR CATEGORIA: Los campos no pueden estar vacios";
            }

            Categoria nuevaCategoria = new Categoria();

            nuevaCategoria.Nombre = nombre;

            repositorioCategoria.AgregarCategoria(nuevaCategoria);

            return "Categoria Agregada con Exito";
        }

        // Metodo que valida y llama al repositorio para eliminar una categoria
        public string EliminarCategoria(int id)
        {
            Categoria categoria = repositorioCategoria.BuscarCategoriaID(id);

            // Validacion de que exista la categoria que se quiere eliminar
            if (categoria == null)
            {
                return "Error al ELIMINAR LA CATEGORIA: La categoria no existe";
            }

            var tieneProductos = repositorioProductos.CategoriasConProductos(categoria.Nombre);

            // Validacion de que la categoria que se quiere eliminar no tenga productos relacionados a ella
            if(tieneProductos == null)
            {
                repositorioCategoria.EliminarCategoria(categoria);

                return "Categoria ELIMINADA con Exito";
            }
            else
            {
                return "La Categoria tiene productos cargados, no se puede eliminar";
            }

        }

        // Metodo que valida y llama al repositorio para modificar una categoria
        public string ModificarCategoria(int id, string nombre)
        {
            Categoria categoria = repositorioCategoria.BuscarCategoriaID(id);

            // Validacion de que exista la categoria que se quiere modificar
            if (categoria == null)
            {
                return "Error al MODIFICAR CATEGORIA: La categoria NO existe";
            }
            
            // Validacion de que el campo del nombre de la categoria este completado
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "Error al MODIFICAR CATEGORIA: Los campos no pueden estar vacios";
            }

            categoria.Nombre = nombre;

            repositorioCategoria.ModificarCategoria(categoria);

            return "Categoria Modificada con Exito";
        }

        // Metodo que devuelve una lista de las categorias disponibles 
        public List<Categoria> ListarCategorias()
        {
            return repositorioCategoria.ListarCategorias().ToList();
        }

        // Metodo que permite buscar las categorias mediante un ID 
        public Categoria BuscarCategoriaId(int id)
        {
            return repositorioCategoria.BuscarCategoriaID(id);
        }

        // Metodo booleano que devuelve true si hay 1 categoria o mas y false si hay 0  
        public bool ContadorDeCategorias()
        {
            int cantidad = repositorioCategoria.ListarCategorias().Count();
            return cantidad > 0;
        }
    }
}
