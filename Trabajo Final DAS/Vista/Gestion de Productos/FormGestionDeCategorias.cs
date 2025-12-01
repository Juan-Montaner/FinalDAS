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
    public partial class FormGestionDeCategorias : Form
    {
        public FormGestionDeCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormABMCategorias formABMCategorias = new FormABMCategorias();
            formABMCategorias.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormABMCategorias formABMCategorias = new FormABMCategorias();
            formABMCategorias.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloProductos formModuloProductos = new FormModuloProductos();
            this.Hide();
            formModuloProductos.ShowDialog();
        }
    }
}
