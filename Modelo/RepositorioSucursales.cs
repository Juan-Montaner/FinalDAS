using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioSucursales
    {
        private Context context;

        public RepositorioSucursales()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Sucursal> ListarSucursal()
        {
            return context.Sucursales.ToList().AsReadOnly();
        }

        public void AgregarSucursal(Sucursal sucursal)
        {
            context.Sucursales.Add(sucursal);
            context.SaveChanges();
        }

        public void ModificarSucursal(Sucursal sucursal)
        {
            context.Sucursales.Update(sucursal);
            context.SaveChanges();
        }

        public void EliminarSucursal(Sucursal sucursal)
        {
            context.Sucursales.Remove(sucursal);
            context.SaveChanges();
        }

        public Sucursal BuscarSucursal(string direccion)
        {
            return context.Sucursales.FirstOrDefault(c => c.Direccion == direccion);
        }

        public Sucursal BuscarSucursalID(int id)
        {
            return context.Sucursales.FirstOrDefault(c => c.IDSucursal == id);
        }

    }
}
