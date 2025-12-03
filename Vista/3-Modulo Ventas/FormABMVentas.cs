using Entidades;
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
    public partial class FormABMVentas : Form
    {
        private int iDSucursal;
        public FormABMVentas(int? iDSucursal = null)
        {
            InitializeComponent();

            if (iDSucursal == null)
            {
                this.Close();
            }

            this.iDSucursal = iDSucursal.Value;

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormGestionVentas formGestionVentas = new FormGestionVentas();
            this.Hide();
            formGestionVentas.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
