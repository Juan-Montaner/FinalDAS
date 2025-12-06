using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraSucursales
    {
        // Declaracion repositorios  y controladoras en uso 
        private RepositorioSucursales repositorioSucursal = new RepositorioSucursales();
        private static ControladoraSucursales instancia;

        #region Patron Singleton
        public static ControladoraSucursales Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraSucursales();
                }
                return instancia;
            }
        }
        #endregion

        // Metodo que valida y llama al repositorio para agregar una sucursal
        public string AgregarSucursal(string direccion, string mail, double telefono)
        {
            Sucursal sucursal = repositorioSucursal.BuscarSucursal(direccion);

            // Validacion de que no exista esa sucursal previamente
            if (sucursal != null)
            {
                return "Error al AGREGAR Sucursal: La Sucursal ya existe";
            }

            // Validacion de que los campos esten completados
            if (string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(mail))
            {
                return "Error al AGREGAR Sucursal: Los campos no pueden estar vacios";
            }

            // Validacion de que el telefono no sea negativo
            if (telefono < 0)
            {
                return "Error: El teléfono no puede ser negativo.";
            }

            Sucursal nuevaSucursal = new Sucursal();

            nuevaSucursal.Direccion = direccion;
            nuevaSucursal.Mail = mail;
            nuevaSucursal.Telefono = telefono;

            repositorioSucursal.AgregarSucursal(nuevaSucursal);

            return "SUCURSAL Agregada con Exito";
        }

        // Metodo que valida y llama al repositorio para eliminar una sucursal
        public string EliminarSucursal(int id)
        {
            Sucursal sucursal = repositorioSucursal.BuscarSucursalID(id);

            // Validacion de que exista la sucursal que se quiere eliminar
            if (sucursal == null)
            {
                return "Error al ELIMINAR LA Sucursal: La Sucursal no existe";
            }

            repositorioSucursal.EliminarSucursal(sucursal);

            return "Sucursal Eliminada con Exito";
        }

        // Metodo que valida y llama al repositorio para modificar una sucursal
        public string ModificarSucursal(int id, string direccion, string mail, double telefono)
        {
            Sucursal sucursal = repositorioSucursal.BuscarSucursalID(id);

            // Validacion de que exista la sucursal que se quiere modificar
            if (sucursal == null)
            {
                return "Error al MODIFICAR LA SUCURSAL: La sucursal NO existe";
            }

            // Validacion de que los campos esten completados
            if (string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(mail))
            {
                return "Error al AGREGAR Sucursal: Los campos no pueden estar vacios";
            }

            // Validacion de que el telefono no sea negativo
            if (telefono < 0)
            {
                return "Error: El teléfono no puede ser negativo.";
            }

            sucursal.Direccion = direccion;
            sucursal.Mail = mail;
            sucursal.Telefono = telefono;

            repositorioSucursal.ModificarSucursal(sucursal);

            return "Sucursal Modificada con Exito";
        }

        // Metodo que permite buscar una sucursal mediante un ID 
        public Sucursal BuscarSucursalId(int id)
        {
            return repositorioSucursal.BuscarSucursalID(id);
        }

        // Metodo que devuelve una lista de los productos disponibles
        public List<Producto> ListarProductos()
        {
            return repositorioSucursal.ListarProductos().ToList();
        }

        // Metodo que devuelve una lista de las sucursales disponibles
        public List<Sucursal> ListarSucursales()
        {
            return repositorioSucursal.ListarSucursal().ToList();
        }

        // Metodo booleano que devuelve true si hay 1 sucursal o mas y false si hay 0  
        public bool ContadorDeSucursales()
        {
            int cantidad = repositorioSucursal.ListarSucursal().Count();
            return cantidad > 0;
        }
    }
}
