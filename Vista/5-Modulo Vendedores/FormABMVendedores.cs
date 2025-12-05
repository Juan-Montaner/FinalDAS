using Entidades;
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
    public partial class FormABMVendedores : Form
    {
        private int? Id;
        public FormABMVendedores(int? id = null)
        {
            InitializeComponent();
            this.Id = id;

            if (id != null)
            {
                CargarDatos();
                gbVendedores.Text = "Modificar Vendedor";
            }
            else
            {
                gbVendedores.Text = "Agregar Vendedor";
            }
        }

        private void CargarDatos()
        {
            Controladora.ControladoraVendedores controladora = Controladora.ControladoraVendedores.Instancia;

            var vendedor = controladora.BuscarVendedorID((int)Id);

            if (Id != null)
            {
                txtNombre.Text = vendedor.Nombre;
                txtDNI.Text = vendedor.DNI.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraVendedores controladora = Controladora.ControladoraVendedores.Instancia;

            try
            {
                if (Id == null)
                {
                    try
                    {
                        string Nombre = txtNombre.Text;
                        int DNI = int.Parse(txtDNI.Text);


                        string resultado = controladora.AgregarVendedor(Nombre, DNI);

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
                        string Nombre = txtNombre.Text;
                        int DNI = int.Parse(txtDNI.Text);

                        string resultado = controladora.ModificarVendedor((int)Id, Nombre, DNI);

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
            FormGestionVendedores formGestionVendedores = new FormGestionVendedores();
            this.Close();
            formGestionVendedores.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormGestionVendedores formGestionVendedores = new FormGestionVendedores();
            this.Hide();
            formGestionVendedores.ShowDialog();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite dígitos y la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacio y Backspace
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
