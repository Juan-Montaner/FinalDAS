using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDSucursal { get; set; }

        public string Direccion { get; set; }

        public double Telefono { get; set; }

        public string Mail { get; set; }

        public List<Producto> ListaProductos { get; set; }
    }
}
