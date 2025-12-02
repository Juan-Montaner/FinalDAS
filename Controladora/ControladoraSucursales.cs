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
        private RepositorioSucursales repositorioSucursal= new RepositorioSucursales();
        private static ControladoraSucursales instancia;

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

        public string AgregarSucursal(string direccion, string mail, double telefono)
        {
            Sucursal sucursal = repositorioSucursal.BuscarSucursal(direccion);

            if (sucursal != null)
            {
                return "Error al AGREGAR Sucursal: La Sucursal ya existe";
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                return "Error al AGREGAR Sucursal: Los campos no pueden estar vacios";
            }

            Sucursal nuevaSucursal = new Sucursal();

            nuevaSucursal.Direccion = direccion;
            nuevaSucursal.Mail = mail;
            nuevaSucursal.Telefono = telefono;

            repositorioSucursal.AgregarSucursal(nuevaSucursal);

            return "SUCURSAL Agregada con Exito";
        }

        public string EliminarSucursal(int id)
        {
            Sucursal sucursal = repositorioSucursal.BuscarSucursalID(id);

            if (sucursal == null)
            {
                return "Error al ELIMINAR LA Sucursal: La categoria no existe";
            }

            repositorioSucursal.EliminarSucursal(sucursal);

            return "Sucursal Eliminada con Exito";
        }

        public string ModificarSucursal(int id, string direccion, string mail, double telefono)
        {
            Sucursal sucursal = repositorioSucursal.BuscarSucursalID(id);

            if (sucursal == null)
            {
                return "Error al MODIFICAR LA SUCURSAL: La sucursal NO existe";
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                return "Error al MODIFICAR LA SUCURSAL: Los campos no pueden estar vacios";
            }

            sucursal.Direccion = direccion;
            sucursal.Mail = mail;
            sucursal.Telefono = telefono;

            repositorioSucursal.ModificarSucursal(sucursal);

            return "Sucursal Modificada con Exito";
        }

        public Sucursal BuscarSucursalId(int id)
        {
            return repositorioSucursal.BuscarSucursalID(id);
        }

        public List<Sucursal> ListarProductos()
        {
            return repositorioSucursal.ListarSucursal().ToList();
        }

        public List<Sucursal> ListarSucursales()
        {
            return repositorioSucursal.ListarSucursal().ToList();
        }


    }
}
