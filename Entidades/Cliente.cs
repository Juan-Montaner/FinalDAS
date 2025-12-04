using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCliente { get; set; }

        public string RazonSocial { get; set; }

        public double Telefono { get; set; }


        public string Mail { get; set; }

        public bool TipoCliente { get; set; }

        public decimal CuentaCorriente { get; set; }
    }
}
