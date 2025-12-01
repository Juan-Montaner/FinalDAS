using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Gestion_de_Productos
{
    public partial class FormGestionDeProductos : Form
    {
        public FormGestionDeProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormABMProductos formABMProductos = new FormABMProductos();
            formABMProductos.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormABMProductos formABMProductos = new FormABMProductos();
            formABMProductos.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloProductos formModuloProductos = new FormModuloProductos();
            this.Hide();
            formModuloProductos.ShowDialog();
        }
    }
}
