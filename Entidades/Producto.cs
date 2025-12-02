using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }

        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}
