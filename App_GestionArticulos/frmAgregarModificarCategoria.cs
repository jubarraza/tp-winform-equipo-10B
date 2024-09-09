using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GestionArticulos
{
    public partial class frmAgregarModificarCategoria : Form
    {
        private Categoria categoria = null;
        public frmAgregarModificarCategoria()
        {
            InitializeComponent();
        }

        public frmAgregarModificarCategoria(Categoria aux)
        {
            InitializeComponent();
            this.categoria = aux;
            Text = "Modificar Categoria";
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.Descripcion = txtCategoria.Text;

                if (categoria.Id != 0)
                {
                    catNegocio.Modificar(categoria);
                    MessageBox.Show("Modificado con Exito");
                }
                else
                {
                    catNegocio.Agregar(categoria);
                    MessageBox.Show("Agregado con Exito");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
    }
}
