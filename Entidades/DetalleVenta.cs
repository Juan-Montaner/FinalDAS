using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        // Clave primaria autoincremental
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDDetalleVenta { get; set; }

        // Propiedades de la entidad

        // Clave foranea 
        [ForeignKey("Venta")]
        public int IDVenta { get; set; }
        public Venta Venta { get; set; }

        // Clave foranea 
        [ForeignKey("Producto")]
        public int IDProducto { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
