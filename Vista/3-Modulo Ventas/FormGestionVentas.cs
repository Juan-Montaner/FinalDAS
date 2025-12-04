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
            cmbSucursales.SelectedIndexChanged -= cmbSucursales_SelectedIndexChanged;
            CargarComboBox();
            cmbSucursales.SelectedIndexChanged += cmbSucursales_SelectedIndexChanged;
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

        private void CargarComboBox()
        {
            Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;

            var sucursales = controladora.ListarSucursales();

            if (sucursales != null)
            {
                cmbSucursales.DataSource = sucursales;
                cmbSucursales.DisplayMember = "Direccion";
                cmbSucursales.ValueMember = "IDSucursal";
            }
        }

        private void FiltrarVentas()
        {
            if (cmbSucursales.SelectedValue == null)
                return;

            if (!(cmbSucursales.SelectedValue is int))
                return;

            int idSucursal = (int)cmbSucursales.SelectedValue;

            var controladora = Controladora.ControladoraVentas.Instancia;
            var ventas = controladora.ListarVentas().Where(p => p.IDSucursal == idSucursal).ToList();

            dgvVentas.DataSource = ventas;
        }

        private int? IDSucursal()
        {
            if (cmbSucursales.SelectedItem == null)
                return null;

            if (cmbSucursales.SelectedValue == null)
                return null;

            int id;

            if (int.TryParse(cmbSucursales.SelectedValue.ToString(), out id))
                return id;

            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int? idSucursal = IDSucursal();

            if (idSucursal == null)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            var controladora = Controladora.ControladoraSucursales.Instancia;
            var sucursal = controladora.ListarSucursales().FirstOrDefault(s => s.IDSucursal == idSucursal);

            if (sucursal == null)
            {
                MessageBox.Show("Sucursal no encontrada.");
                return;
            }

            this.Hide();
            FormABMVentas formABMVentas = new FormABMVentas(idSucursal);
            formABMVentas.ShowDialog();
            this.Show();

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
            FormMenuPrincipal FormMenuPrincipal = new FormMenuPrincipal();
            this.Hide();
            FormMenuPrincipal.ShowDialog();
        }

        private void cmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarVentas();

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
