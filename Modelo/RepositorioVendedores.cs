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
        private Context context;

        public RepositorioVendedores()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Vendedor> ListarVendedores()
        {
            return context.Vendedores.ToList().AsReadOnly();
        }

        public void AgregarVendedor(Vendedor vendedor)
        {
            context.Vendedores.Add(vendedor);
            context.SaveChanges();
        }

        public void ModificarVendedor(Vendedor vendedor)
        {
            context.Vendedores.Update(vendedor);
            context.SaveChanges();
        }

        public void EliminarVendedor(Vendedor vendedor)
        {
            context.Vendedores.Remove(vendedor);
            context.SaveChanges();
        }

        public Vendedor BuscarVendedorID(int id)
        {
            return context.Vendedores.FirstOrDefault(c => c.IDVendedor == id);
        }

        public Vendedor BuscarVendedorDNI(int DNI)
        {
            return context.Vendedores.FirstOrDefault(c => c.DNI == DNI);
        }
    }
}
