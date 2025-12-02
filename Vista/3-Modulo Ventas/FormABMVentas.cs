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
        private int? id;
        public FormABMVentas(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void gbVentas_Enter(object sender, EventArgs e)
        {

        }
    }
}
