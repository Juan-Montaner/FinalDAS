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
    public partial class FormGestionDeSucursales : Form
    {
        public FormGestionDeSucursales()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Refrescar()
        {
            Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;
            dgvGestionProductos.DataSource = controladora.ListarSucursales();
        }
        private int? GetId()
        {
            if (dgvGestionProductos.Rows.Count == 0)
                return null;

            if (dgvGestionProductos.CurrentRow == null)
                return null;

            var valor = dgvGestionProductos.CurrentRow.Cells[0].Value;

            if (valor == null)
                return null;

            if (int.TryParse(valor.ToString(), out int id))
                return id;

            return null;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormABMSucursales formABMSucursales = new FormABMSucursales();
            formABMSucursales.ShowDialog();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FormABMSucursales formABMSucursales = new FormABMSucursales(id);
                formABMSucursales.ShowDialog();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal para modificar");
            }
            Refrescar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormModuloProductos formModuloProductos = new FormModuloProductos();
            this.Hide();
            formModuloProductos.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;
                controladora.EliminarSucursal((int)id);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal para eliminar");
            }
            Refrescar();
        }

    }
}
