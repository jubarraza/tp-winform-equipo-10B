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
    public partial class frmFiltroAvanzado : Form
    {
        public frmFiltroAvanzado()
        {
            InitializeComponent();
        }

        private void frmFiltroAvanzado_Load(object sender, EventArgs e)
        {

            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                comboBoxMarca.DataSource = marca.Listar();
                comboBoxCategoria.DataSource = categoria.Listar();
                comboBoxPrecio.Items.Add("Mayor a");
                comboBoxPrecio.Items.Add("Menor a");
                comboBoxPrecio.Items.Add("Entre");
                textBoxPrecio2.Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void comboBoxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPrecio.SelectedItem.ToString() == "Entre")
            {
                textBoxPrecio2.Visible = true;
            }
            else
            {
                textBoxPrecio2.Visible = false;
            }
        }
    }
}
