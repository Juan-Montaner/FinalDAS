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
using Vista.Gestion_de_Productos;

namespace Vista._3_Modulo_Ventas
{
    public partial class FormGestionVentas : Form
    {
        public FormGestionVentas()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Refrescar()
        {
            Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
            dgvVentas.DataSource = controladora.ListarVentas();
        }

        private int? GetId()
        {
            if (Controladora.ControladoraVentas.Instancia.ListarVentas().Count != 0)
            {
                try
                {
                    return int.Parse(dgvVentas.Rows[dgvVentas.CurrentRow.Index].Cells[0].Value.ToString());
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
            FormABMVentas formABMVentas = new FormABMVentas();
            formABMVentas.ShowDialog();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FormABMVentas formABMVentas = new FormABMVentas(id);
                formABMVentas.ShowDialog();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una venta para modificar");
            }
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Controladora.ControladoraVentas controladora = Controladora.ControladoraVentas.Instancia;
                controladora.EliminarVenta((int)id);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una venta para eliminar");
            }
            Refrescar();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloVentas formModuloVentas = new FormModuloVentas();
            this.Hide();
            formModuloVentas.ShowDialog();
        }
    }
}
