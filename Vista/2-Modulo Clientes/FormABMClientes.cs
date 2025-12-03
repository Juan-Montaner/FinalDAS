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

            this.Id = id;

            if (id != null)
            {
                CargarDatos();
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
                        double Telefono = double.Parse(txtTelefono.Text);
                        bool Tipo;
                        if (rbnMayorista.Checked == true)
                        {
                            Tipo = true; // mayorista
                        }
                        else
                        {
                            Tipo = false; // minorista
                        }

                            controladora.AgregarCliente(Razon, Mail, Telefono, Tipo);
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        int id = Id.Value;
                        string Razon = txtRazonSocial.Text;
                        string Mail = txtMail.Text;
                        double Telefono = double.Parse(txtTelefono.Text);
                        bool Tipo;
                        if (rbnMayorista.Checked == true)
                        {
                            Tipo = true;
                        }
                        else
                        {
                            Tipo = false;
                        }

                        controladora.ModificarCliente(id, Razon, Mail, Telefono, Tipo);
                    }
                    catch
                    {

                    }
                }
            }
            catch (FormatException Ex)
            {
                MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
            }

            this.Close();
        }
        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
