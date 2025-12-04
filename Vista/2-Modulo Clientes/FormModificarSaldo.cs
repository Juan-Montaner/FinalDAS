using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista._2_Modulo_Clientes
{
    public partial class FormModificarSaldo : Form
    {
        private int? Id;

        public FormModificarSaldo(int? id = null)
        {
            InitializeComponent();

            this.Id = id;

            if (id != null)
            {
                CargarSaldo();
            }
        }

        private void CargarSaldo()
        {
            Controladora.ControladoraClientes controladora = Controladora.ControladoraClientes.Instancia;

            var cliente = controladora.BuscarClienteId((int)Id);

            lblSaldoActual.Text = cliente.CuentaCorriente.ToString();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraClientes controladora = Controladora.ControladoraClientes.Instancia;

            var cliente = controladora.BuscarClienteId((int)Id);

            cliente.CuentaCorriente = cliente.CuentaCorriente + decimal.Parse(txtSaldo.Text);

            controladora.ModificarCliente(cliente.IDCliente, cliente.RazonSocial, cliente.Telefono, cliente.Mail, cliente.TipoCliente, cliente.CuentaCorriente);
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir borrar
            if (e.KeyChar == (char)Keys.Back)
                return;

    // Bloquear letras y espacios
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
              return;
            }

    // Todo lo demás (números + caracteres especiales) se permite
        }

    }
}
