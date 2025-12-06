using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVendedores
    {
        // Llamada al context 
        private Context context;

        public RepositorioVendedores()
        {
            context = new Context();
        }

        // Metodo que devuelve una lista de los vendedores
        public IReadOnlyCollection<Vendedor> ListarVendedores()
        {
            return context.Vendedores.ToList().AsReadOnly();
        }

        // Metodo que agrega un vendedor a la base de datos 
        public void AgregarVendedor(Vendedor vendedor)
        {
            context.Vendedores.Add(vendedor);
            context.SaveChanges();
        }

        // Metodo que modifica un vendedor de la base de datos 
        public void ModificarVendedor(Vendedor vendedor)
        {
            context.Vendedores.Update(vendedor);
            context.SaveChanges();
        }

        // Metodo que elimina un vendedor de la base de datos 
        public void EliminarVendedor(Vendedor vendedor)
        {
            context.Vendedores.Remove(vendedor);
            context.SaveChanges();
        }

        // Metodo que busca un vendedor en la base mediante su ID 
        public Vendedor BuscarVendedorID(int id)
        {
            return context.Vendedores.FirstOrDefault(c => c.IDVendedor == id);
        }

        // Metodo que busca un vendedor en la base mediante su DNI 
        public Vendedor BuscarVendedorDNI(int DNI)
        {
            return context.Vendedores.FirstOrDefault(c => c.DNI == DNI);
        }
    }
}
