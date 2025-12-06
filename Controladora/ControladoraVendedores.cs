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
        // Declaracion repositorios  y controladoras en uso 
        private RepositorioVendedores repositorioVendedores = new RepositorioVendedores();
        private static ControladoraVendedores instancia;

        #region Patron Singleton
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
        #endregion

        // Metodo que valida y llama al repositorio para agregar un vendedor
        public string AgregarVendedor(string Nombre, int DNI)
        {
            Vendedor vendedor = repositorioVendedores.BuscarVendedorDNI(DNI);

            // Validacion de que no exista ese vendedor previamente
            if (vendedor != null)
            {
                return "Error al AGREGAR VENDEDOR: El vendedor ya existe";
            }

            // Validacion de que el campo del nombre este completado
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                return "Error al AGREGAR VENDEDOR: Los campos no pueden estar vacios";
            }

            Vendedor nuevoVendedor = new Vendedor();

            nuevoVendedor.Nombre = Nombre;
            nuevoVendedor.DNI = DNI;

            repositorioVendedores.AgregarVendedor(nuevoVendedor);

            return "Vendedor agregado con exito";
        }

        // Metodo que valida y llama al repositorio para eliminar un vendedor
        public string EliminarVendedor(int id)
        {
            Vendedor vendedor = repositorioVendedores.BuscarVendedorID(id);

            // Validacion de que exista el vendedor que se quiere eliminar
            if (vendedor == null)
            {
                return "Error al ELIMINAR el vendedor: El Vendedor no existe";
            }

            repositorioVendedores.EliminarVendedor(vendedor);

            return "Vendedor eliminado con exito";
        }

        // Metodo que valida y llama al repositorio para modificar un vendedor
        public string ModificarVendedor(int id, string nombre, int dni)
        {
            Vendedor vendedor = repositorioVendedores.BuscarVendedorID(id);

            // Validacion de que exista el vendedor que se quiere modificar
            if (vendedor == null)
            {
                return "Error al MODIFICAR EL VENDEDOR: El Vendedor no existe";
            }

            // Validacion de que el campo del nombre este completado
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "Error al MODIFICAR EL VENDEDOR: Los campos no pueden estar vacios";
            }

            vendedor.Nombre = nombre;
            vendedor.DNI = dni;

            repositorioVendedores.ModificarVendedor(vendedor);

            return "Vendedor modificado con exito";
        }

        // Metodo que permite buscar un vendedor mediante un ID 
        public Vendedor BuscarVendedorID(int id)
        {
            return repositorioVendedores.BuscarVendedorID(id);
        }

        // Metodo que devuelve una lista de los vendedores disponibles
        public List<Vendedor> ListarVendedores()
        {
            return repositorioVendedores.ListarVendedores().ToList();
        }
    }
}
