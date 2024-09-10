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

        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();    
        }

        private void OcultarColumna()
        {
            dataGridArticulo.Columns["Id"].Visible = false;
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listar();
                dataGridArticulo.DataSource = listaArticulos;
                OcultarColumna();

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

        private void buttonInformación_Click(object sender, EventArgs e)
        {
            Articulo seleccion;
            seleccion = (Articulo)dataGridArticulo.CurrentRow.DataBoundItem;

            frmInformacionArticulo info = new frmInformacionArticulo(seleccion);
            info.ShowDialog();
            cargar();
        }


        private void textBoxBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            string filtro = textBoxBusqueda.Text;

            if (filtro != "")
            {
                listafiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listafiltrada = listaArticulos;
            }

            dataGridArticulo.DataSource = null;
            dataGridArticulo.DataSource = listafiltrada;
            OcultarColumna();
        }
    }
}
