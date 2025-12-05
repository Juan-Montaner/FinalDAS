using Entidades;
using Microsoft.Identity.Client.Extensibility;
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
    public partial class FormABMClientes : Form
    {
        private int? Id;
        public FormABMClientes(int? id = null)
        {
            InitializeComponent();

            rbnMinorista.Checked = true;

            this.Id = id;

            if (id != null)
            {
                CargarDatos();
                gbClientes.Text = "Modificar Cliente";
            }
            else
            {
                gbClientes.Text = "Agregar Cliente";
            }
        }

        private void CargarDatos()
        {
            Controladora.ControladoraClientes controladora = Controladora.ControladoraClientes.Instancia;

            var cliente = controladora.BuscarClienteId((int)Id);

            if (Id != null)
            {
                txtRazonSocial.Text = cliente.RazonSocial;
                txtTelefono.Text = cliente.Telefono.ToString();
                txtMail.Text = cliente.Mail;

                if (cliente is ClienteMayorista)
                {
                    rbnMayorista.Checked = true;
                }
                else if (cliente is ClienteMinorista)
                {
                    rbnMinorista.Checked = true;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraClientes controladora = Controladora.ControladoraClientes.Instancia;

            try
            {
                if (Id == null)
                {
                    try
                    {
                        string Razon = txtRazonSocial.Text;
                        string Mail = txtMail.Text;
                        double Telefono = Convert.ToDouble(txtTelefono.Text);
                        bool Tipo;

                        if (rbnMayorista.Checked == true)
                        {
                            Tipo = true;
                        }
                        else
                        {
                            Tipo = false;
                        }
                        decimal CuentaCorriente = 0;

                        string resultado = controladora.AgregarCliente(Razon, Mail, Telefono, Tipo);

                        if (resultado.StartsWith("Error"))
                        {
                            MessageBox.Show(resultado);
                            return;
                        }

                    }
                    catch (FormatException Ex)
                    {
                        MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
                    }
                }
                else
                {
                    try
                    {
                        var clienteAntiguo = controladora.BuscarClienteId((int)Id);
                        string Razon = txtRazonSocial.Text;
                        string Mail = txtMail.Text;
                        double Telefono = Convert.ToDouble(txtTelefono.Text);
                        bool Tipo;

                        if (rbnMayorista.Checked == true)
                        {
                            Tipo = true;
                        }
                        else
                        {
                            Tipo = false;
                        }

                        string resultado = controladora.ModificarCliente((int)Id, Razon, Telefono, Mail, Tipo, clienteAntiguo.CuentaCorriente);

                        if (resultado.StartsWith("Error"))
                        {
                            MessageBox.Show(resultado);
                            return;
                        }

                    }
                    catch (FormatException Ex)
                    {
                        MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
                    }
                }
            }
            catch (FormatException Ex)
            {
                MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
            }

            this.Hide();
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            this.Close();
            formGestionClientes.ShowDialog();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
