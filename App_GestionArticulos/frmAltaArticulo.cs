using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GestionArticulos
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo;
        private List<Imagen> listaImagenes;
        private int indiceImagen = 0;

        private List<Imagen> listaSeleccion;

        public frmAltaArticulo()
        {
            InitializeComponent();
            DesactivarBotones();
            
        }

        public frmAltaArticulo(Articulo Articulo)
        {
            InitializeComponent();
            this.articulo = Articulo;
            this.Text = "Modificar Articulo";
            
        }

        private void CargarComboBox()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                CargarComboBox();

                if (articulo != null)
                {

                    textBoxCodigo.Text = articulo.CodArt;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescrip.Text = articulo.Descripcion;
                    comboBoxMarca.SelectedValue = articulo.Marca.Id;
                    comboBoxCategoria.SelectedValue = articulo.Categoria.Id;
                    textBoxPrecio.Text = articulo.Precio.ToString();

                    listaImagenes = imagenNegocio.BuscarImagenes(articulo.Id);
                    if(!(listaImagenes is null))
                    {
                        txt_Url.Text = listaImagenes[indiceImagen].UrlImagen;
                        btn_AgregarImagenes.Visible = true;
                    }
                    else
                    {
                        txt_Url.Text = string.Empty;
                        btn_AgregarImagenes.Visible = false;
                    }

                    CargarImagenes(articulo.Id);

                }
                else
                {
                    btn_AgregarImagenes.Enabled = false;
                    btn_AgregarImagenes.Visible = false;
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

        private bool numeroDecimal(string cadena)
        {

            foreach(char caract in cadena)
            {
                if ((char.IsNumber(caract)) || char.IsDigit(','))
                {
                    return true;
                }
            }
            return false;
        }

        private bool validacionCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(textBoxCodigo.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDescrip.Text) ||
                    comboBoxMarca.SelectedItem == null ||
                    comboBoxCategoria.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(textBoxPrecio.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio negocioImg = new ImagenNegocio();

            try
            {
                if (!validacionCamposObligatorios())
                {
                    MessageBox.Show("Todos los campos deben estar completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!(numeroDecimal(textBoxPrecio.Text)))
                {
                    MessageBox.Show("El precio debe ser un número válido (usar coma para decimales)", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                Imagen img = new Imagen();
                img.Articulo = new Articulo();

                articulo.CodArt = textBoxCodigo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescrip.Text;
                articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                articulo.Precio = float.Parse(textBoxPrecio.Text);
                string nuevaUrlImagen = txt_Url.Text;
                img.Articulo = articulo;

                if (articulo.Id != 0 ) //articulo existente (modificacion)
                {
                    negocio.Modificar(articulo);
                    if (negocioImg.BuscarImagen(articulo.Id, indiceImagen) != null) 
                    {
                        img = negocioImg.BuscarImagen(articulo.Id, indiceImagen);
                        if (!img.UrlImagen.Equals(nuevaUrlImagen))
                        {
                            img.UrlImagen = nuevaUrlImagen;
                            negocioImg.Modificar(img);
                        }
                    
                    }
                    else
                    {
                        img.UrlImagen = nuevaUrlImagen;
                        negocioImg.Agregar(img);
                    }

                    MessageBox.Show("Articulo modificado con Exito.", "Modificacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else //articulo nuevo
                {
                    
                    int id = negocio.Agregar(articulo);
                    img.Articulo.Id = id;
                    if(txt_Url.Text != string.Empty)
                    {
                        img.UrlImagen = txt_Url.Text;
                        negocioImg.Agregar(img);
                    }
                    
                    MessageBox.Show("Articulo agregado con Exito", "Alta realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                this.Close();
            }
            catch (Exception)
            {

                throw;
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
                    pb_Imagen.Load(listaSeleccion[indiceImagen].UrlImagen);
                    ActualizarBotones();

                }
                else
                {
                    pb_Imagen.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
                    DesactivarBotones();
                }


            }
            catch (WebException webex)
            {
                pb_Imagen.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
                DesactivarBotones();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
            try
            {
                CargarImagen(txt_Url.Text);
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
                pb_Imagen.Load(listaSeleccion[indiceImagen].UrlImagen);
                txt_Url.Text = listaSeleccion[indiceImagen].UrlImagen;
            }
            ActualizarBotones();
        }

        private void btn_Adelante_Click(object sender, EventArgs e)
        {

            if (indiceImagen < listaSeleccion.Count - 1)
            {
                indiceImagen++;
                pb_Imagen.Load(listaSeleccion[indiceImagen].UrlImagen);
                txt_Url.Text = listaSeleccion[indiceImagen].UrlImagen;
            }
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            if (indiceImagen > 0)
            {
                btn_Atras.Enabled = true;
            }
            if (indiceImagen == 0)
            {
                btn_Atras.Enabled = false;
            }

            if (indiceImagen < listaSeleccion.Count - 1)
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

        private void lbl_AgregarImagenes_Click(object sender, EventArgs e)
        {

        }
    }
}
