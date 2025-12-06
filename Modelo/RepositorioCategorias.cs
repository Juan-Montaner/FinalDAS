using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCategorias
    {
        // Llamada al context 
        private Context context;

        public RepositorioCategorias()
        {
            context = new Context();
        }

        // Metodo que devuelve una lista de las categorias
        public IReadOnlyCollection<Categoria> ListarCategorias()
        {
            return context.Categorias.ToList().AsReadOnly();
        }

        // Metodo que agrega una categoria a la base de datos 
        public void AgregarCategoria(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
        }

        // Metodo que modifica una categoria de la base de datos 
        public void ModificarCategoria(Categoria categoria)
        {
            context.Categorias.Update(categoria);
            context.SaveChanges();
        }

        // Metodo que modifica una categoria de la base de datos 
        public void EliminarCategoria(Categoria categoria)
        {
            context.Categorias.Remove(categoria);
            context.SaveChanges();
        }

        // Metodo que busca una categoria en la base mediante su nombre 
        public Categoria BuscarCategoria(string nombre)
        {
            return context.Categorias.FirstOrDefault(c => c.Nombre == nombre);
        }

        // Metodo que busca una categoria en la base mediante su ID 
        public Categoria BuscarCategoriaID(int id)
        {
            return context.Categorias.FirstOrDefault(c => c.IDCategoria == id);
        }
    }
}
