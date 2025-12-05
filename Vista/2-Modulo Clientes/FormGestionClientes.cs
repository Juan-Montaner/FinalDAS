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

namespace Vista._2_Modulo_Clientes
{
    public partial class FormGestionClientes : Form
    {
        public FormGestionClientes()
        {
            InitializeComponent();
            Refrescar();

        }

        private void Refrescar()
        {
            Controladora.ControladoraClientes controladora = Controladora.ControladoraClientes.Instancia;
            dgvClientes.DataSource = controladora.ListarClientes();
        }

        private int? GetId()
        {
            if (dgvClientes.Rows.Count == 0)
                return null;

            if (dgvClientes.CurrentRow == null)
                return null;

            var valor = dgvClientes.CurrentRow.Cells[0].Value;

            if (valor == null)
                return null;

            if (int.TryParse(valor.ToString(), out int id))
                return id;

            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormABMClientes formABMClientes = new FormABMClientes();
            formABMClientes.ShowDialog();
            this.Show();

            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                this.Hide();
                FormABMClientes formABMClientes = new FormABMClientes(id);
                formABMClientes.ShowDialog();
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
                Controladora.ControladoraClientes controladora = Controladora.ControladoraClientes.Instancia;
                controladora.EliminarCliente((int)id);
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

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                this.Hide();
                FormHistorialCompras formHistorialCompras = new FormHistorialCompras(id);
                formHistorialCompras.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para modificar");
            }
            Refrescar();

        }
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                this.Hide();
                FormModificarSaldo formModificarSaldo = new FormModificarSaldo(id);
                formModificarSaldo.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para modificar su saldo");
            }

            Refrescar();
        }


    }
}
