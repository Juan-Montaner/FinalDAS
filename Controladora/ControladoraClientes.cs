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
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(RazonSocial) ||
                string.IsNullOrWhiteSpace(mail))
            {
                return "Error: Los campos no pueden estar vacíos.";
            }

            // Validación del número de teléfono
            if (telefono < 0 )
            {
                return "Error: El teléfono no puede ser negativo.";
            }

            // Validar duplicado
            Cliente clienteExistente = repositorioCliente.BuscarCliente(RazonSocial);
            if (clienteExistente != null)
            {
                return "Error: Ya existe un cliente con esa Razón Social.";
            }

            // Crear cliente según tipo
            if (tipo == true) // Mayorista
            {
                ClienteMayorista nuevoCliente = new ClienteMayorista
                {
                    RazonSocial = RazonSocial,
                    Mail = mail,
                    Telefono = telefono,
                    TipoCliente = true,
                    CuentaCorriente = 0
                };

                repositorioCliente.AgregarCliente(nuevoCliente);
            }
            else // Minorista
            {
                ClienteMinorista nuevoCliente = new ClienteMinorista
                {
                    RazonSocial = RazonSocial,
                    Mail = mail,
                    Telefono = telefono,
                    TipoCliente = false,
                    CuentaCorriente = 0
                };

                repositorioCliente.AgregarCliente(nuevoCliente);
            }

            return "Cliente agregado con éxito.";
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

        public string ModificarCliente(int id, string razonSocial, double telefono, string mail, bool tipo, decimal cuentaCorriente)
        {
            

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(razonSocial) ||
                string.IsNullOrWhiteSpace(mail))
            {
                return "Error: Los campos no pueden estar vacíos.";
            }

            // Validación del número de teléfono
            if (telefono < 0)
            {
                return "Error: El teléfono no puede ser negativo.";
            }

            // Validar duplicado
            Cliente cliente = repositorioCliente.BuscarCliente(razonSocial);
            if (cliente != null && cliente.IDCliente != id)
            {
                return "Error: Ya existe un cliente con esa Razón Social.";
            }

            cliente.RazonSocial = razonSocial;
            cliente.Mail = mail;
            cliente.Telefono = telefono;
            cliente.TipoCliente = tipo;
            cliente.CuentaCorriente = cuentaCorriente;

            repositorioCliente.ModificarCliente(cliente);

            return "Cliente Modificado con Exito";
        }
        
        public Cliente BuscarClienteId(int id)
        {
            return repositorioCliente.BuscarClienteID(id);
        }

        public Cliente BuscarCliente(string RazonSocial)
        {
            return repositorioCliente.BuscarCliente(RazonSocial);
        }

        public List<Cliente> ListarClientes()
        {
            return repositorioCliente.ListarCLiente().ToList();
        }

    }
}

