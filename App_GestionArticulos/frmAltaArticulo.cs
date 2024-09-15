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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_GestionArticulos
{
    public partial class frmAltaArticulo : Form, Interfaz_TrasladoImagenes
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

        private void ConfiguracionToolTip()
        {
            toolTip_am.SetToolTip(textBoxCodigo, "* Obligatorio\nCodigo alfanumerico hasta 50 caracteres.");
            toolTip_am.SetToolTip(textBoxNombre, "* Obligatorio. Hasta 50 caracteres.");
            toolTip_am.SetToolTip(textBoxDescrip, "* Obligatorio.Hasta 150 caracteres.");
            toolTip_am.SetToolTip(txt_Url, "Opcional\nIngrese una URL valida hasta 1000 caracteres.");
            toolTip_am.SetToolTip(comboBoxMarca, "* Obligatorio.");
            toolTip_am.SetToolTip(comboBoxCategoria, "* Obligatorio.");
            toolTip_am.SetToolTip(textBoxPrecio, "* Obligatorio\nAcepta numeros decimales (separados con coma).");
            toolTip_am.SetToolTip(buttonAceptar, "Guardar.");
            toolTip_am.SetToolTip(buttonCancelar, "Cancelar.");
            toolTip_am.SetToolTip(btn_BorrarImg, "Eliminar imagen actual.");
            toolTip_am.SetToolTip(btn_AgregarImagenes, "Agregar nueva imagen.");

            toolTip_am.AutoPopDelay = 5000; // visible por 5 segundos
            toolTip_am.InitialDelay = 100;  // aparece a los 0.1 segundos
            toolTip_am.IsBalloon = true;    // tooltip con forma de burbuja

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
                ConfiguracionToolTip();

                if (articulo != null)
                {

                    textBoxCodigo.Text = articulo.CodArt;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescrip.Text = articulo.Descripcion;
                    comboBoxMarca.SelectedValue = articulo.Marca.Id;
                    comboBoxCategoria.SelectedValue = articulo.Categoria.Id;
                    textBoxPrecio.Text = articulo.Precio.ToString("0.0##");

                    listaImagenes = imagenNegocio.BuscarImagenes(articulo.Id);

                    if(!(listaImagenes is null))
                    {
                        txt_Url.Text = listaImagenes[indiceImagen].UrlImagen;
                        btn_AgregarImagenes.Visible = true;
                        btn_BorrarImg.Visible = true;
                    }
                    else
                    {
                        txt_Url.Text = string.Empty;
                        btn_AgregarImagenes.Visible = true;
                        btn_BorrarImg.Visible = false;
                    }

                    CargarImagenes(listaImagenes);

                }
                else
                {
                    btn_AgregarImagenes.Visible = false;
                    btn_BorrarImg.Visible= false;
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
                    MessageBox.Show("Debe completar todos los campos obligatorios \n(marcados con *)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void CargarImagenes(List<Imagen> listaRecibida)
        {
            ImagenNegocio negocioImagen = new ImagenNegocio();
            listaSeleccion = new List<Imagen>();

            try
            {
                listaSeleccion = listaRecibida;

                if (!(listaSeleccion is null))
                {
                    pb_Imagen.Load(listaSeleccion[indiceImagen].UrlImagen);
                    txt_Url.Text = listaSeleccion[indiceImagen].UrlImagen;
                    btn_BorrarImg.Visible = true;
                    ActualizarBotones();

                }
                else
                {
                    pb_Imagen.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
                    txt_Url.Text = string.Empty;
                    DesactivarBotones();
                }


            }
            catch (WebException webex)
            {
                ExcepcionWeb();
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
                btn_BorrarImg.Visible = true;
            }
            catch (Exception ex)
            {
                pb_Imagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWz9tftw9qculFH1gxieWkxL6rbRk_hrXTSg&s");
                btn_BorrarImg.Visible = false;
            }

        }

        private void txt_Url_Leave(object sender, EventArgs e)
        {
            CargarImagen(txt_Url.Text);
        }

        private void ExcepcionWeb()
        {

            pb_Imagen.Load("https://static.vecteezy.com/system/resources/previews/005/720/408/non_2x/crossed-image-icon-picture-not-available-delete-picture-symbol-free-vector.jpg");
            txt_Url.Text = listaSeleccion[indiceImagen].UrlImagen;
            btn_AgregarImagenes.Visible = true;
            btn_BorrarImg.Visible = true;
            if (!(listaSeleccion.Count > 0))
            {
                DesactivarBotones();
            }
            else
            {
                ActualizarBotones();
            }

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceImagen > 0)
                {
                    indiceImagen--;
                    pb_Imagen.Load(listaSeleccion[indiceImagen].UrlImagen);
                    txt_Url.Text = listaSeleccion[indiceImagen].UrlImagen;
                }
                ActualizarBotones();
            }
            catch (WebException)
            {
                ExcepcionWeb();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_Adelante_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceImagen < listaSeleccion.Count - 1)
                {
                    indiceImagen++;
                    pb_Imagen.Load(listaSeleccion[indiceImagen].UrlImagen);
                    txt_Url.Text = listaSeleccion[indiceImagen].UrlImagen;
                }
                ActualizarBotones();
            }
            catch (WebException)
            {
                ExcepcionWeb();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
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
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaSeleccion = imagenNegocio.BuscarImagenes(articulo.Id);
            frmNuevaImagen agregarImagen = new frmNuevaImagen(articulo, listaSeleccion, this);
            agregarImagen.ShowDialog();
            
        }

        public void TrasladoImagen(Imagen imagen)
        {
            try
            {
                if (listaSeleccion is null)
                {
                    listaSeleccion = new List<Imagen>();
                }

                listaSeleccion.Add(imagen);
                CargarImagenes(listaSeleccion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_BorrarImg_Click(object sender, EventArgs e)
        {
            Imagen img = new Imagen();
            ImagenNegocio negocioImg = new ImagenNegocio();
            try
            {
                if (listaSeleccion is null) 
                { 
                    btn_BorrarImg.Visible = false;
                }
                else
                {
                    img = listaSeleccion[indiceImagen];
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar la imagen?", "Eliminar imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(resultado == DialogResult.Yes)
                    {
                        negocioImg.Eliminar(img);
                        listaSeleccion = negocioImg.BuscarImagenes(img.Articulo.Id);
                    }
                    else
                    {
                        return;
                    }
                    
                }
                indiceImagen = 0;
                CargarImagenes(listaSeleccion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
