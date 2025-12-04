using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDVenta { get; set; }
        public string RazonSocialCliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleVenta> Detalles { get; set; }         
        public int IDSucursal { get; set; }        
        public string Vendedor { get; set; }
        public MetodoPago MetodoDePago { get; set; }
        public enum MetodoPago
        {
            Efectivo = 1,
            Tarjeta = 2,
            Transferencia = 3
        }
        public decimal Total { get; set; }

    }
}
