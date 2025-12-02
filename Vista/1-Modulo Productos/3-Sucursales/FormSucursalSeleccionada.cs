using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Gestion_de_Productos;

namespace Vista._1_Modulo_Productos._3_Sucursales
{
    public partial class FormSucursalSeleccionada : Form
    {
        public FormSucursalSeleccionada()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Refrescar()
        {
            Controladora.ControladoraProductos controladora = Controladora.ControladoraProductos.Instancia;
            dgvProductosSucursal.DataSource = controladora.ListarProductos();
        }
        private int? GetId()
        {
            if (dgvProductosSucursal.Rows.Count == 0)
                return null;

            if (dgvProductosSucursal.CurrentRow == null)
                return null;

            var valor = dgvProductosSucursal.CurrentRow.Cells[0].Value;

            if (valor == null)
                return null;

            if (int.TryParse(valor.ToString(), out int id))
                return id;

            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormABMProductos formABMProductos = new FormABMProductos();
            formABMProductos.ShowDialog();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //int? id = GetId();
            //if (id != null)
            //{
            //    FormGestionProductosSucursal formGestionProductosSucursal = new FormGestionProductosSucursal(id);
            //    formGestionProductosSucursal.ShowDialog();
            //    Refrescar();
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una categoria para modificar");
            //}
            //Refrescar();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
