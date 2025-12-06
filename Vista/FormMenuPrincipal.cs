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
using Vista._3_Modulo_Ventas;
using Vista._4_Modulo_Reportes_y_Consultas;
using Vista._5_Modulo_Vendedores;

namespace Vista
{
    public partial class FormMenuPrincipal : Form
    {
        #region Patron Singleton

        private static FormMenuPrincipal instancia;

        public static FormMenuPrincipal Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new FormMenuPrincipal();

                return instancia;
            }
        }

        #endregion  

        public FormMenuPrincipal()
        {
            InitializeComponent();

            btnGestionClientes.Enabled = false;
        }

        // Boton que lleva al formulario de gestion de productos
        private void btnGestionProductos_Click_1(object sender, EventArgs e)
        {
            FormModuloProductos formGestionProductos = new FormModuloProductos();
            this.Hide();
            formGestionProductos.ShowDialog();
        }

        // Boton que lleva al formulario de gestion de clientes
        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            this.Hide();
            formGestionClientes.ShowDialog();
        }

        // Boton que lleva al formulario de gestion de ventas
        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            FormGestionVentas formGestionVentas = new FormGestionVentas();
            this.Hide();
            formGestionVentas.ShowDialog();
        }

        // Boton que lleva al formulario de gestion de vendedores
        private void btnVendedores_Click(object sender, EventArgs e)
        {
            FormGestionVendedores formGestionVendedores = new FormGestionVendedores();
            this.Hide();
            formGestionVendedores.ShowDialog();
        }

        // Boton que lleva al formulario de reportes y consultas
        private void btnRepYCons_Click(object sender, EventArgs e)
        {
            FormReporteYConsultas formReporteYConsultas = new FormReporteYConsultas();
            this.Hide();
            formReporteYConsultas.ShowDialog();
        }

        // Boton que termina la ejecucion del programa
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
