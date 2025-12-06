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
        // Clave primaria autoincremental
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDFactura { get; set; }

        // Propiedades de la entidad
        
        // Clave foranea
        [ForeignKey("Venta")]
        public int IDVenta { get; set; }
        public string RazonSocialCliente { get; set; }
        public DateTime Fecha { get; set; }
        public MetodoPago MetodoDePago { get; set; }
        public enum MetodoPago
        {
            Efectivo = 1,
            Tarjeta = 2,
            Transferencia = 3,
            CuentaCorriente = 4
        }
        public decimal Total { get; set; }
    }
}
