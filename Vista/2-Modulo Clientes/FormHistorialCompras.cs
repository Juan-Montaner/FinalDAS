using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista._2_Modulo_Clientes
{
    public partial class FormHistorialCompras : Form
    {
        private int? Id;
        Controladora.ControladoraVentas controladoraVentas = Controladora.ControladoraVentas.Instancia;
        Controladora.ControladoraClientes controladoraClientes = Controladora.ControladoraClientes.Instancia;
        public FormHistorialCompras(int? id = null)
        {
            InitializeComponent();

            this.Id = id;

            CargarHistoral();
        }

        private void CargarHistoral()
        {
            if (Id != null)
            {
                var cliente = controladoraClientes.BuscarClienteId(Id.Value);

                dgvHistorial.DataSource = controladoraVentas.FiltrarVentasRazonSocial(cliente.RazonSocial);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            this.Close();
            formGestionClientes.ShowDialog();
        }
    }
}
