using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista._3_Modulo_Ventas
{
    public partial class FormCantStockVenta : Form
    {
        private int? idProducto;
        private int? idSucursal;

        Controladora.ControladoraProductos controladoraProductos = Controladora.ControladoraProductos.Instancia;

        public FormCantStockVenta(int? idProducto, int? idSucursal)
        {
            InitializeComponent();

            this.idProducto = idProducto;
            this.idSucursal = idSucursal;

            LimitarCantidad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormABMVentas formABMVentas = new FormABMVentas(idSucursal);
            this.Close();
        }

        private void LimitarCantidad()
        {
            var producto = controladoraProductos.BuscarProductoId((int)idProducto);

            nudCantidad.Maximum = producto.Stock;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = controladoraProductos.ListarProductos().FirstOrDefault(p => p.IDProducto == idProducto);

            producto.Stock = Convert.ToInt32(nudCantidad.Value);

            FormABMVentas formABMVentas = new FormABMVentas(idSucursal);

        }
    }
}
