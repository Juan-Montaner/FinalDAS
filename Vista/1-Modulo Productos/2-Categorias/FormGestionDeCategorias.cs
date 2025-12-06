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

        // Metodo que refresca el Data Grid View
        private void Refrescar()
        {
            Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia;
            dgvGestionCategorias.DataSource = controladora.ListarCategorias();
            PintarEncabezados();
        }

        // Detalles visuales Data Grid View
        private void PintarEncabezados()
        {

            dgvGestionCategorias.EnableHeadersVisualStyles = false;


            foreach (DataGridViewColumn col in dgvGestionCategorias.Columns)
            {

                col.HeaderCell.Style.Font = new Font(dgvGestionCategorias.Font, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.White;
                col.HeaderCell.Style.BackColor = Color.SteelBlue;


            }
            dgvGestionCategorias.Refresh();
        }

        // Metodo que obtiene el ID de la categoria seleccionada en el Data Grid View
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

        // Boton que permite agregar una categoria 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormABMCategorias formABMCategorias = new FormABMCategorias();
            formABMCategorias.ShowDialog();
            this.Show();

            Refrescar();
        }

        // Boton que permite modificar una categoria 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                this.Hide();
                FormABMCategorias formABMCategorias = new FormABMCategorias(id);
                formABMCategorias.ShowDialog();
                this.Show();

                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificar");
            }
            Refrescar();
        }

        // Boton que permite eliminar una categoria 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia;
                string mensaje = controladora.EliminarCategoria((int)id);
                MessageBox.Show(mensaje);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para eliminar");
            }
            Refrescar();
        }

        // Boton que permite volver al menu principal 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloProductos formModuloProductos = new FormModuloProductos();
            this.Hide();
            formModuloProductos.ShowDialog();
        }


    }
}
