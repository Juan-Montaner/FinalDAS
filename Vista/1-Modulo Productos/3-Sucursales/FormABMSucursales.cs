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
    public partial class FormABMSucursales : Form
    {
        private int? Id;
        public FormABMSucursales(int? id = null)
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
            Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;

            var sucursal = controladora.BuscarSucursalId((int)Id);

            if (Id != null)
            {
                txtDireccion.Text = sucursal.Direccion;
                txtMail.Text = sucursal.Mail;
                txtTelefono.Text = sucursal.Telefono.ToString();
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraSucursales controladora = Controladora.ControladoraSucursales.Instancia;

            try
            {
                if (Id == null)
                {
                    try
                    {
                        string Direccion = txtDireccion.Text;
                        string Mail = txtMail.Text;
                        double Telefono = double.Parse(txtTelefono.Text);

                        controladora.AgregarSucursal(Direccion, Mail, Telefono);
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
                        string Direccion = txtDireccion.Text;
                        string Mail = txtMail.Text;
                        double Telefono = double.Parse(txtTelefono.Text);

                        controladora.ModificarSucursal(id, Direccion, Mail, Telefono);
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
    }
    
}
