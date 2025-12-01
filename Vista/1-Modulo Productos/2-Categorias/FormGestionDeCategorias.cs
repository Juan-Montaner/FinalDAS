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
            Refrescar();
        }

        private void Refrescar()
        {
            Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia;
            dgvGestionCategorias.DataSource = controladora.ListarCategorias();
        }

        private int? GetId()
        {
            if (Controladora.ControladoraCategorias.Instancia.ListarCategorias().Count != 0)
            {
                try
                {
                    return int.Parse(dgvGestionCategorias.Rows[dgvGestionCategorias.CurrentRow.Index].Cells[0].Value.ToString());
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormABMCategorias formABMCategorias = new FormABMCategorias();
            formABMCategorias.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FormABMCategorias formABMCategorias = new FormABMCategorias(id);
                formABMCategorias.Show();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificar");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia
                controladora.EliminarCategoria((int)id);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificar");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloProductos formModuloProductos = new FormModuloProductos();
            this.Hide();
            formModuloProductos.ShowDialog();
        }

        
    }
}
