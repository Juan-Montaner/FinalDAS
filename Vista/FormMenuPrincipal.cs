using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista._2_Modulo_Clientes;

namespace Vista
{
    public partial class FormMenuPrincipal : Form
    {
        #region Patron Singleton

        private static FormMenuPrincipal instancia;

        public static FormMenuPrincipal Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new FormMenuPrincipal();

                return instancia;
            }
        }

        #endregion  

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        /*
        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            this.Hide();
            formGestionClientes.ShowDialog();
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            FormGestionVentas formGestionVentas = new FormGestionVentas();
            this.Hide();
            formGestionVentas.ShowDialog();
        }

        private void btnRepYCons_Click(object sender, EventArgs e)
        {
            FormReportesyConsultas formReportesyConsultas = new FormReportesyConsultas();
            this.Hide();
            formReportesyConsultas.ShowDialog();
        }
        */

        private void btnGestionProductos_Click_1(object sender, EventArgs e)
        {
            FormModuloProductos formGestionProductos = new FormModuloProductos();
            this.Hide();
            formGestionProductos.ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            FormModuloClientes formModuloClientes = new FormModuloClientes();
            this.Hide();
            formModuloClientes.ShowDialog();
        }
    }
}
