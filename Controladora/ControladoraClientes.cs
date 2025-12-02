using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraClientes
    {
        private RepositorioClientes repositorioCliente = new RepositorioClientes();
        private static ControladoraClientes instancia;

        public static ControladoraClientes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraClientes();
                }
                return instancia;
            }
        }

        public string AgregarCliente(string RazonSocial, string mail, double telefono, bool tipo)
        {
            Cliente cliente = repositorioCliente.BuscarCliente(telefono);

            if (cliente != null)
            {
                return "Error al AGREGAR Cliente: El Cliente ya existe";
            }

            if (string.IsNullOrWhiteSpace(RazonSocial) || double.IsNegative(telefono) || string.IsNullOrWhiteSpace(mail))
            {
                return "Error al AGREGAR Cliente: Los campos no pueden estar vacios";
            }

            if (tipo == true)
            {
                ClienteMayorista nuevoCliente = new ClienteMayorista();

                nuevoCliente.RazonSocial = RazonSocial;
                nuevoCliente.Mail = mail;
                nuevoCliente.Telefono = telefono;
                nuevoCliente.ListaCompras = new List<Factura>();
                nuevoCliente.TipoCliente = tipo;
                repositorioCliente.AgregarCliente(nuevoCliente);
            }
            else
            {
                ClienteMinorista nuevoCliente = new ClienteMinorista();

                nuevoCliente.RazonSocial = RazonSocial;
                nuevoCliente.Mail = mail;
                nuevoCliente.Telefono = telefono;
                nuevoCliente.ListaCompras = new List<Factura>();
                nuevoCliente.TipoCliente = tipo;
                repositorioCliente.AgregarCliente(nuevoCliente);
            }

            return "Cliente Nuevo Agregado con Exito";
        }

        public string EliminarCliente(int id)
        {
            Cliente cliente = repositorioCliente.BuscarClienteID(id);

            if (cliente == null)
            {
                return "Error al ELIMINAR el Cliente: El ID de cliente no existe";
            }

            repositorioCliente.EliminarCliente(cliente);

            return "Cliente Eliminado con Exito";
        }

        public string ModificarCliente(int id, string direccion, string mail, double telefono, bool tipo)
        {
            Cliente cliente = repositorioCliente.BuscarClienteID(id);

            if (cliente == null)
            {
                return "Error al MODIFICAR el Cliente: El cliente NO existe";
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                return "Error al MODIFICAR el CLIENTE: Los campos no pueden estar vacios";
            }

            cliente.RazonSocial = direccion;
            cliente.Mail = mail;
            cliente.Telefono = telefono;
            cliente.TipoCliente = tipo;
            

            repositorioCliente.ModificarCliente(cliente);

            return "Cliente Modificado con Exito";
        }

        public Cliente BuscarClienteId(int id)
        {
            return repositorioCliente.BuscarClienteID(id);
        }

        public List<Cliente> ListarClientes()
        {
            return repositorioCliente.ListarCLiente().ToList();
        }

    }
}

