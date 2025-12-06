using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteMayorista : Cliente
    {
        // Propiedades de la entidad
        public ClienteMayorista()
        {
            Descuento = 0.10m; // Descuento aplicado a clientes mayoristas
            TipoCliente = true; 
        }

        public decimal Descuento {  get; set; }
    }
}
