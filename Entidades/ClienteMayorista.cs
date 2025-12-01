using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteMayorista : Cliente
    {
        public ClienteMayorista()
        {
            Descuento = 0.10m;
        }
        public decimal Descuento {  get; set; }
    }
}
