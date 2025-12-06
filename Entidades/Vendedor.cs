using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        // Clave primaria autoincremental
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDVendedor { get; set; }

        // Propiedades de la entidad
        public string Nombre { get; set; }
        public int DNI { get; set; }
    }
}
