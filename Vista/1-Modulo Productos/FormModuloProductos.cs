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

namespace Vista
{
    public partial class FormModuloProductos : Form
    {
        #region Patron Singleton

        private static FormModuloProductos instancia;

        public static FormModuloProductos Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new FormModuloProductos();

                return instancia;
            }
        }

        #endregion

        public FormModuloProductos()
        {
            InitializeComponent();
        }

        // Boton que lleva al formulario de gestion de productos
        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            FormGestionDeProductos formGestionDeProductos = new FormGestionDeProductos();
            this.Hide();
            formGestionDeProductos.ShowDialog();
        }

        // Boton que lleva al formulario de gestion de categorias
        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {
            FormGestionDeCategorias formGestionDeCategorias = new FormGestionDeCategorias();
            this.Hide();
            formGestionDeCategorias.ShowDialog();
        }

        // Boton que lleva al formulario de gestion de sucursales
        private void btnGestionarSucursales_Click(object sender, EventArgs e)
        {
            FormGestionDeSucursales formGestionDeSucursales = new FormGestionDeSucursales();
            this.Hide();
            formGestionDeSucursales.ShowDialog();
        }

        // Boton que lleva al menu principal
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            this.Hide();
            formMenuPrincipal.ShowDialog();
        }
    }
}
