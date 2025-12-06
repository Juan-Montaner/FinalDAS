using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioSucursales
    {
        // Llamada al context 
        private Context context;

        public RepositorioSucursales()
        {
            context = new Context();
        }

        // Metodo que devuelve una lista de las sucursales
        public IReadOnlyCollection<Sucursal> ListarSucursal()
        {
            return context.Sucursales.ToList().AsReadOnly();
        }

        // Metodo que devuelve una lista de los productos que posee esa sucursal
        public IReadOnlyCollection<Producto> ListarProductos()
        {
            return context.Productos.ToList().AsReadOnly();
        }

        // Metodo que agrega una sucursal a la base de datos 
        public void AgregarSucursal(Sucursal sucursal)
        {
            context.Sucursales.Add(sucursal);
            context.SaveChanges();
        }

        // Metodo que modifica una sucursal de la base de datos 
        public void ModificarSucursal(Sucursal sucursal)
        {
            context.Sucursales.Update(sucursal);
            context.SaveChanges();
        }

        // Metodo que elimina una sucursal de la base de datos 
        public void EliminarSucursal(Sucursal sucursal)
        {
            context.Sucursales.Remove(sucursal);
            context.SaveChanges();
        }

        // Metodo que busca una sucursal en la base mediante su direccion 
        public Sucursal BuscarSucursal(string direccion)
        {
            return context.Sucursales.FirstOrDefault(c => c.Direccion == direccion);
        }

        // Metodo que busca una sucursal en la base mediante su ID 
        public Sucursal BuscarSucursalID(int id)
        {
            return context.Sucursales.FirstOrDefault(c => c.IDSucursal == id);
        }
    }
}
