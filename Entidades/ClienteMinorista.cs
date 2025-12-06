using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteMinorista : Cliente
    {
        // Propiedades de la entidad
        public ClienteMinorista()
        {
            Descuento = 0.025m; // Descuento aplicado a clientes minoristas
            TipoCliente = false;
        }

        public decimal Descuento { get; set; }
    }
}
