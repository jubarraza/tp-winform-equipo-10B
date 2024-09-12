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
            btnAceptar.Enabled = false;
        }

        public frmAgregarModificarCategoria(Categoria aux)
        {
            InitializeComponent();
            this.categoria = aux;
            btnAceptar.Enabled = false;
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
                bool valido = catNegocio.validarIngreso(categoria);

                if (valido) 
                {
                    if (categoria.Id != 0)
                    {
                        catNegocio.Modificar(categoria);
                        MessageBox.Show("Categoria modificada con Exito.", "Modificacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        catNegocio.Agregar(categoria);
                        MessageBox.Show("Categoria agregada con Exito", "Categoria creada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Categoria Ya Existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void frmAgregarModificarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            try
            {
                if (categoria != null)
                {
                    txtCategoria.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Length > 0)
            {
                btnAceptar.Enabled = true;
            }
            if (txtCategoria.Text.Length == 0)
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
