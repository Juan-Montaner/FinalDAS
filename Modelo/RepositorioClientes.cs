using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioClientes
    {
        //Repo
        private Context context;

        public RepositorioClientes()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Cliente> ListarCLiente()
        {
            return context.Clientes.ToList().AsReadOnly();
        }

        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void ModificarCliente(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        public void EliminarCliente(Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }

        public Cliente BuscarCliente(string RazonSocial)
        {
            return context.Clientes.FirstOrDefault(c => c.RazonSocial == RazonSocial);
        }

        public Cliente BuscarClienteID(int id)
        {
            return context.Clientes.FirstOrDefault(c => c.IDCliente == id);
        }

    }
}
