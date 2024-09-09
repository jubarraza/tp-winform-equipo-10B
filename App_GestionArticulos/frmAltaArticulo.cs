using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GestionArticulos
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null; 

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo Articulo)
        {
            InitializeComponent();
            this.articulo = Articulo;
            this.Text = "Modificar Articulo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                comboBoxCategoria.DataSource = categoriaNegocio.Listar();
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "Descripcion";
                comboBoxMarca.DataSource = marcaNegocio.Listar();
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Nombre";

                if(articulo != null)
                {
                    textBoxCodigo.Text = articulo.CodArt;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescrip.Text = articulo.Descripcion;
                    comboBoxMarca.SelectedValue = articulo.Marca.Id;
                    comboBoxCategoria.SelectedValue = articulo.Categoria.Id;
                    textBoxPrecio.Text = articulo.Precio.ToString();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.CodArt = textBoxCodigo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescrip.Text;
                articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                articulo.Precio = float.Parse(textBoxPrecio.Text);
                

                if(articulo.Id != 0 )
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Modificado con Exito");
                }
                else
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Agregado con exito");
                }
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
