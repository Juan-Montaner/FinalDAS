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
        // Llamada al context 
        private Context context;

        public RepositorioClientes()
        {
            context = new Context();
        }

        // Metodo que devuelve una lista de los clientes
        public IReadOnlyCollection<Cliente> ListarCLiente()
        {
            return context.Clientes.ToList().AsReadOnly();
        }

        // Metodo que agrega un cliente a la base de datos 
        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        // Metodo que modifica un cliente de la base de datos 
        public void ModificarCliente(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        // Metodo que elimina un cliente de la base de datos 
        public void EliminarCliente(Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }

        // Metodo que busca un cliente en la base mediante su razon social 
        public Cliente BuscarCliente(string RazonSocial)
        {
            return context.Clientes.FirstOrDefault(c => c.RazonSocial == RazonSocial);
        }

        // Metodo que busca un cliente en la base mediante su ID 
        public Cliente BuscarClienteID(int id)
        {
            return context.Clientes.FirstOrDefault(c => c.IDCliente == id);
        }
    }
}
