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

namespace Vista._5_Modulo_Vendedores
{
    public partial class FormGestionVendedores : Form
    {
        public FormGestionVendedores()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Refrescar()
        {
            Controladora.ControladoraVendedores controladora = Controladora.ControladoraVendedores.Instancia;
            dgvVendedores.DataSource = controladora.ListarVendedores();
            PintarEncabezados();
        }

        private void PintarEncabezados()
        {

            dgvVendedores.EnableHeadersVisualStyles = false;


            foreach (DataGridViewColumn col in dgvVendedores.Columns)
            {

                col.HeaderCell.Style.Font = new Font(dgvVendedores.Font, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.White;
                col.HeaderCell.Style.BackColor = Color.SteelBlue;


            }
            dgvVendedores.Refresh();
        }

        private int? GetId()
        {
            if (dgvVendedores.Rows.Count == 0)
                return null;

            if (dgvVendedores.CurrentRow == null)
                return null;

            var valor = dgvVendedores.CurrentRow.Cells[0].Value;

            if (valor == null)
                return null;

            if (int.TryParse(valor.ToString(), out int id))
                return id;

            return null;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormABMVendedores formABMVendedores = new FormABMVendedores();
            formABMVendedores.ShowDialog();
            this.Show();

            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                this.Hide();
                FormABMVendedores formABMVendedores = new FormABMVendedores((int)id);
                formABMVendedores.ShowDialog();
                this.Show();

                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para modificar");
            }
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Controladora.ControladoraVendedores controladora = Controladora.ControladoraVendedores.Instancia;
                controladora.EliminarVendedor((int)id);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
            }
            Refrescar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            this.Hide();
            formMenuPrincipal.ShowDialog();
        }
    }
}
