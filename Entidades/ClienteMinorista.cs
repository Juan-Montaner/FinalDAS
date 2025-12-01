using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteMinorista : Cliente
    {
        public ClienteMinorista()
        {
            Descuento = 0.025m;
        }

        public decimal Descuento { get; set; }
    }
}
