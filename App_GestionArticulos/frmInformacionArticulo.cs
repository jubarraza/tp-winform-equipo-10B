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
        private List<Imagen> listaSeleccion;
        private int indiceImagen = 0;
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
            listaSeleccion = new List<Imagen>();

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
                    pb_Imagenes.Load(listaSeleccion[indiceImagen].UrlImagen);
                    ActualizarBotones();
                    
                }
                else
                {
                    pb_Imagenes.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
                    DesactivarBotones();
                }


            }
            catch (WebException webex) 
            {
                pb_Imagenes.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
                DesactivarBotones();    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            if (indiceImagen > 0)
            {
                indiceImagen--;
                pb_Imagenes.Load(listaSeleccion[indiceImagen].UrlImagen);
            }
            ActualizarBotones();

        }

        private void btn_Adelante_Click(object sender, EventArgs e)
        {
            
            if (indiceImagen < listaSeleccion.Count - 1)
            {
                indiceImagen++;
                pb_Imagenes.Load(listaSeleccion[indiceImagen].UrlImagen);
            }
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            if(indiceImagen > 0)
            {
                btn_Atras.Enabled = true;
            }
            if(indiceImagen == 0)
            {
                btn_Atras.Enabled = false;
            }

            if(indiceImagen < listaSeleccion.Count - 1)
            {
                btn_Adelante.Enabled = true;
            }
            if (indiceImagen == listaSeleccion.Count - 1)
            {
                btn_Adelante.Enabled = false;
            }
             
        }

        private void DesactivarBotones()
        {
            btn_Adelante.Enabled = false;
            btn_Atras.Enabled = false;
        }
    }
}
