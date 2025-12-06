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

        // Metodo que refresca el Data Grid View
        private void Refrescar()
        {
            Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;
            dgvGestionSucursales.DataSource = controladora.ListarSucursales();
            PintarEncabezados();
        }

        // Detalles visuales Data Grid View
        private void PintarEncabezados()
        {

            dgvGestionSucursales.EnableHeadersVisualStyles = false;


            foreach (DataGridViewColumn col in dgvGestionSucursales.Columns)
            {

                col.HeaderCell.Style.Font = new Font(dgvGestionSucursales.Font, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.White;
                col.HeaderCell.Style.BackColor = Color.SteelBlue;


            }
            dgvGestionSucursales.Refresh();
        }

        // Metodo que obtiene el ID de la sucursal seleccionada en el Data Grid View
        private int? GetId()
        {
            if (dgvGestionSucursales.Rows.Count == 0)
                return null;

            if (dgvGestionSucursales.CurrentRow == null)
                return null;

            var valor = dgvGestionSucursales.CurrentRow.Cells[0].Value;

            if (valor == null)
                return null;

            if (int.TryParse(valor.ToString(), out int id))
                return id;

            return null;
        }

        // Boton que permite agregar una sucursal
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormABMSucursales formABMSucursales = new FormABMSucursales();
            formABMSucursales.ShowDialog();
            this.Show();

            Refrescar();
        }

        // Boton que permite modificar una sucursal
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                this.Hide();
                FormABMSucursales formABMSucursales = new FormABMSucursales(id);
                formABMSucursales.ShowDialog();
                this.Show();

                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal para modificar");
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

        // Boton que permite eliminar una sucursal
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
