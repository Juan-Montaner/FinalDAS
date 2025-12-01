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
        private Context context;

        public RepositorioCategorias()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Categoria> ListarCategorias()
        {
            return context.Categorias.ToList().AsReadOnly();
        }

        public void AgregarCategoria(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
        }

        public void ModificarCategoria(Categoria categoria)
        {
            context.Categorias.Update(categoria);
            context.SaveChanges();
        }

        public void EliminarCategoria(Categoria categoria)
        {
            context.Categorias.Remove(categoria);
            context.SaveChanges();
        }

        public Categoria BuscarCategoria(string nombre)
        {
            return context.Categorias.FirstOrDefault(c => c.Nombre == nombre);
        }

        public Categoria BuscarCategoriaID(int id)
        {
            return context.Categorias.FirstOrDefault(c => c.IDCategoria == id);
        }
    }
}
