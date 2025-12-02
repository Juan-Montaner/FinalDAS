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
    public partial class FormModuloClientes : Form
    {
        public FormModuloClientes()
        {
            InitializeComponent();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            this.Hide();
            formGestionClientes.ShowDialog();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            this.Hide();
            formMenuPrincipal.ShowDialog();
        }
    }
}
