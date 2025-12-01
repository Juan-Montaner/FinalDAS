using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int IDCliente { get; set; }

        public string RazonSocial { get; set; }

        public double Telefono { get; set; }

        public string Mail { get; set; }

        public List<Factura> ListaCompras { get; set; }
    }
}
