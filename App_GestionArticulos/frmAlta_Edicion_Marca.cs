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
    public partial class frmAlta_Edicion_Marca : Form
    {
        private Marca marca = null;
        public frmAlta_Edicion_Marca()
        {
            InitializeComponent();
        }

        public frmAlta_Edicion_Marca(Marca aux)
        {
            InitializeComponent();
            this.marca = aux;
            Text = "Modificar Marca";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();

            try
            {
                if(marca == null)
                    marca = new Marca();

                marca.Nombre = txt_NombreMarca.Text;
                bool valido = negocioMarca.validarIngreso(marca);

                if (valido)
                {
                    
                    if (marca.Id != 0)
                    {
                        negocioMarca.Modificar(marca);
                        MessageBox.Show("Marca modificada con Exito.", "Modificacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    }
                    else
                    {
                        negocioMarca.Agregar(marca);
                        MessageBox.Show("Marca agregada con Exito", "Alta realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show("Marca Ya Existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void frmAlta_Edicion_Marca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();

            try
            {
                if(marca != null)
                {
                    txt_NombreMarca.Text = marca.Nombre;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
