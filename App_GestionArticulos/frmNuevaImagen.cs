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
    public partial class frmNuevaImagen : Form
    {
        private Articulo articulo;

        private List<Imagen> listaImagenes;

        public Interfaz_TrasladoImagenes interfazImg;
        public frmNuevaImagen(Articulo art, List<Imagen> listaImg, Interfaz_TrasladoImagenes padre)
        {
            InitializeComponent();
            interfazImg = padre;
            this.articulo = art;
            if (listaImg != null)
            {
                this.listaImagenes = listaImg;
            }
            else
            {
                this.listaImagenes = new List<Imagen>();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocioImagen = new ImagenNegocio();
            Imagen img = new Imagen();

            try
            {
                if(txt_Url.Text != string.Empty)
                {
                    img.Articulo = articulo;
                    img.UrlImagen = txt_Url.Text;
                    negocioImagen.Agregar(img);

                    interfazImg.TrasladoImagen(img);
                    Close();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una URL valida.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txt_Url_TextChanged(object sender, EventArgs e)
        {
            if (txt_Url.Text.Length > 0)
            {
                buttonAceptar.Enabled = true;
            }
            if (txt_Url.Text.Length == 0)
            {
                buttonAceptar.Enabled = false;
            }
        }



        private void CargarImagen(string imagen)
        {
            try
            {
                pb_Imagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pb_Imagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWz9tftw9qculFH1gxieWkxL6rbRk_hrXTSg&s");
            }

        }

        private void txt_Url_Leave(object sender, EventArgs e)
        {
            CargarImagen(txt_Url.Text);
        }
    }
}
