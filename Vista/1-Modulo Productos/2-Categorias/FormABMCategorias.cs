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

namespace Vista.Gestion_de_Productos
{
    public partial class FormABMCategorias : Form
    {
        private int? Id;
        public FormABMCategorias(int? id = null)
        {
            InitializeComponent();
            this.Id = id;

            if (id != null)
            {
                CargarDatos();
                grpAbm.Text = "Modificar Categoria";

            }
            else
            {
                grpAbm.Text = "Agregar Categoria";
            }
        }

        // Metodo que carga los datos para modificarlos
        private void CargarDatos() 
        { 
            Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia;

            var categoria = controladora.BuscarCategoriaId((int)Id);

            if (Id != null)
            {
                txtNombre.Text = categoria.Nombre;
            }
        }

        // Boton que permite volver al menu de gestion de categorias 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton que agrega o modifica una categoria
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraCategorias controladora = Controladora.ControladoraCategorias.Instancia;

            try
            {
                if (Id == null)
                {
                    try
                    {

                        grpAbm.Text = "Agregar Categoria";

                        string Nombre = txtNombre.Text;

                        controladora.AgregarCategoria(Nombre);
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
                        grpAbm.Text = "Modificar Categoria";
                        int id = Id.Value;
                        string Nombre = txtNombre.Text;

                        controladora.ModificarCategoria(id, Nombre);
                    }
                    catch (FormatException Ex)
                    {
                        MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");

                    }
                }
            }
            catch(FormatException Ex) 
            {
                MessageBox.Show("Error en el Formato de los datos -- Intente NUEVAMENTE");
            }

            this.Hide();
            FormGestionDeCategorias formGestionDeCategorias = new FormGestionDeCategorias();
            this.Close();
            formGestionDeCategorias.ShowDialog();
        }
    }
}
