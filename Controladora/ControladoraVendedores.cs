using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVendedores
    {
        private RepositorioVendedores repositorioVendedores = new RepositorioVendedores();
        private static ControladoraVendedores instancia;

        public static ControladoraVendedores Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraVendedores();
                }
                return instancia;
            }
        }

        public string AgregarVendedor(string Nombre, int DNI)
        {
            Vendedor vendedor = repositorioVendedores.BuscarVendedorDNI(DNI);

            if (vendedor != null)
            {
                return "Error al AGREGAR VENDEDOR: El vendedor ya existe";
            }

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                return "Error al AGREGAR VENDEDOR: Los campos no pueden estar vacios";
            }

            Vendedor nuevoVendedor = new Vendedor();

            nuevoVendedor.Nombre = Nombre;
            nuevoVendedor.DNI = DNI;

            repositorioVendedores.AgregarVendedor(nuevoVendedor);

            return "Vendedor agregar con exito";
        }

        public string EliminarVendedor(int id)
        {
            Vendedor vendedor = repositorioVendedores.BuscarVendedorID(id);

            if (vendedor == null)
            {
                return "Error al ELIMINAR el vendedor: no existe";
            }

            repositorioVendedores.EliminarVendedor(vendedor);

            return "Vendedor eliminado con exito";
        }

        public string ModificarVendedor(int id, string nombre, int dni)
        {
            Vendedor vendedor = repositorioVendedores.BuscarVendedorID(id);

            if (vendedor == null)
            {
                return "Error al MODIFICAR EL VENDEDOR: La sucursal NO existe";
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "Error al MODIFICAR EL VENDEDOR: Los campos no pueden estar vacios";
            }

            vendedor.Nombre = nombre;
            vendedor.DNI = dni;

            repositorioVendedores.ModificarVendedor(vendedor);

            return "Vendedor modificado con exito";
        }

        public Vendedor BuscarVendedorID(int id)
        {
            return repositorioVendedores.BuscarVendedorID(id);
        }

        public List<Vendedor> ListarVendedores()
        {
            return repositorioVendedores.ListarVendedores().ToList();
        }

    }
}
