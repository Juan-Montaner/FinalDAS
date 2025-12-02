using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDFactura { get; set; }
        public string RazonSocialCliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<Producto> Productos { get; set; }

        public enum MetodoPago
        {
            Efectivo = 1,
            Tarjeta = 2,
            Transferencia = 3
        }
        public long Total { get; set; }
    }
}
