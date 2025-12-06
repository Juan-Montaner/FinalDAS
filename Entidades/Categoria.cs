using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        // Clave primaria autoincremental
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCategoria { get; set; }

        // Propiedades de la entidad
        public string Nombre { get; set; }
    }
}
