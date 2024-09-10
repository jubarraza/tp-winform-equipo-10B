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
using System.Net;

namespace App_GestionArticulos
{
    public partial class frmInformacionArticulo : Form
    {
        private List<Imagen> listaImagenes;
        public frmInformacionArticulo(Articulo seleccion)
        {
            InitializeComponent();
            Cargar(seleccion);
        }



        private void frmInformacionArticulo_Load(object sender, EventArgs e)
        {

           
        }

        private void Cargar(Articulo seleccion)
        {
            ImagenNegocio negocioImagen = new ImagenNegocio();

            try
            {
                listaImagenes = negocioImagen.Listar();
                //dgv_InfoArticulo.DataSource = listaImagenes;
                lbl_Articulo.Text = seleccion.CodArt + " - " + seleccion.Nombre;
                lbl_Desc.Text = seleccion.Descripcion;
                lbl_Marca.Text = seleccion.Marca.Nombre;
                lbl_Cat.Text = seleccion.Categoria.Descripcion;
                lbl_Precio.Text = "$ " + seleccion.Precio.ToString();
                CargarImagenes(seleccion.Id);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        public void CargarImagenes(int idseleccion)
        {
            ImagenNegocio negocioImagen = new ImagenNegocio();
            List<Imagen> listaSeleccion = new List<Imagen>();

            try
            {
                listaImagenes = negocioImagen.Listar();

                foreach (Imagen img in listaImagenes)
                {
                    if (img.Articulo.Id == idseleccion)
                    {
                        listaSeleccion.Add(img);
                    }
                }

                if (listaSeleccion.Count > 0)
                {
                    pb_Imagenes.Load(listaSeleccion[0].UrlImagen);
                }
                else
                {
                    pb_Imagenes.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
                }


            }
            catch (WebException webex) 
            {
                pb_Imagenes.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {


        }


    }
}
