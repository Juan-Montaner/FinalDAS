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
        // Declaracion de controladoras en uso 
        private int? Id;
        Controladora.ControladoraVentas controladoraVentas = Controladora.ControladoraVentas.Instancia;
        Controladora.ControladoraClientes controladoraClientes = Controladora.ControladoraClientes.Instancia;

        public FormHistorialCompras(int? id = null)
        {
            InitializeComponent();

            this.Id = id;

            CargarHistoral();
            PintarEncabezados();
        }

        // Detalles visuales Data Grid View
        private void PintarEncabezados()
        {

            dgvHistorial.EnableHeadersVisualStyles = false;


            foreach (DataGridViewColumn col in dgvHistorial.Columns)
            {

                col.HeaderCell.Style.Font = new Font(dgvHistorial.Font, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.White;
                col.HeaderCell.Style.BackColor = Color.SteelBlue;


            }
            dgvHistorial.Refresh();
        }

        // Metodo que carga el historial de compras el cliente en un Data Grid View
        private void CargarHistoral()
        {
            if (Id != null)
            {
                var cliente = controladoraClientes.BuscarClienteId(Id.Value);

                dgvHistorial.DataSource = controladoraVentas.FiltrarVentasRazonSocial(cliente.RazonSocial);
            }
        }

        // Boton que permite volver al formulario de ABM clientes
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            this.Close();
            formGestionClientes.ShowDialog();
        }
    }
}
