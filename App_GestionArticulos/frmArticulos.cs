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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();    
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                dataGridArticulo.DataSource = articuloNegocio.listar();
                dataGridArticulo.Columns["Id"].Visible = false;
                //dataGridArticulo.Columns["IdMarca"].Visible = false;
                //dataGridArticulo.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccion;
            seleccion = (Articulo)dataGridArticulo.CurrentRow.DataBoundItem;

            frmAltaArticulo Modificar = new frmAltaArticulo(seleccion);
            Modificar.ShowDialog();
            cargar();
        }
    }
}
