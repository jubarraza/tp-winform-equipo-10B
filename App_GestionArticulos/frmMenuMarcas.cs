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
using Negocio;

namespace App_GestionArticulos
{
    public partial class frmMenuMarcas : Form
    {
        private List<Marca> listaMarcas;

        public frmMenuMarcas()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                listaMarcas = negocio.Listar();
                dgv_Marcas.DataSource = listaMarcas;
                OcultarColumnasMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OcultarColumnasMarca()
        {
            dgv_Marcas.Columns["Id"].Visible = false;
        }

        private void frmMenuMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_AgregarMarca_Click(object sender, EventArgs e)
        {
            frmAlta_Edicion_Marca alta = new frmAlta_Edicion_Marca();
            alta.ShowDialog();
            Cargar();
        }

        private void btn_VolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
