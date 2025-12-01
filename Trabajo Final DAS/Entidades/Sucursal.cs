using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {

        public int IDSucursal { get; set; }

        public string Direccion { get; set; }

        public List<Producto> ListaProductos { get; set; }
    }
}
