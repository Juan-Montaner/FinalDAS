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
        private RepositorioCategorias repositorioCategoria = new RepositorioCategorias();
        private static ControladoraCategorias instancia;

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

        public string AgregarCategoria(string nombre)
        {
            Categoria categoria = repositorioCategoria.BuscarCategoria(nombre);
            
            if(categoria != null)
            {
                return "Error al AGREGAR CATEGORIA: La categoria ya existe";
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "Error al AGREGAR CATEGORIA: Los campos no pueden estar vacios";
            }

            Categoria nuevaCategoria = new Categoria();

            nuevaCategoria.Nombre = nombre;

            repositorioCategoria.AgregarCategoria(nuevaCategoria);

            return "Categoria Agregada con Exito";
        }

        public string EliminarCategoria(int id)
        {
            Categoria categoria = repositorioCategoria.BuscarCategoriaID(id);

            if (categoria == null)
            {
                return "Error al ELIMINAR LA CATEGORIA: La categoria no existe";
            }

            repositorioCategoria.EliminarCategoria(categoria);

            return "Categoria ELIMINADA con Exito";
        }

        public string ModificarCategoria(int id, string nombre)
        {
            Categoria categoria = repositorioCategoria.BuscarCategoriaID(id);

            if (categoria == null)
            {
                return "Error al MODIFICAR CATEGORIA: La categoria NO existe";
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "Error al MODIFICAR CATEGORIA: Los campos no pueden estar vacios";
            }

            categoria.Nombre = nombre;

            repositorioCategoria.ModificarCategoria(categoria);

            return "Categoria Modificada con Exito";
        }

        public List<Categoria> ListarCategorias()
        {
            return repositorioCategoria.ListarCategorias().ToList();
        }

        public Categoria BuscarCategoriaId(int id)
        {
            return repositorioCategoria.BuscarCategoriaID(id);
        }


    }
}
