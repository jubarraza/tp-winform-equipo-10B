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
using Dominio;

namespace App_GestionArticulos
{
    public partial class frmInformacionArticulo : Form
    {
        private List<Imagen> listaImagenes;
        public frmInformacionArticulo()
        {
            InitializeComponent();
        }

        private void frmInformacionArticulo_Load(object sender, EventArgs e)
        {

            Cargar();
        }

        private void Cargar()
        {
            ImagenNegocio negocioImagen = new ImagenNegocio();

            try
            {
                listaImagenes = negocioImagen.Listar();
                dgv_InfoArticulo.DataSource = listaImagenes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
