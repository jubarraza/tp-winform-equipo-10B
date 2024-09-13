using Dominio;
using Negocio;
using System;
using System.Collections;
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
    public partial class frmFiltroAvanzado : Form
    {

        public IntPasodelistascs IntPasodelistascs;

        private bool marcaSeleccionada = false;
        private bool categoriaSeleccionada = false;
        private bool opcionPrecioSeleccionada = false;
        private bool precioCargado = false;

        public frmFiltroAvanzado(IntPasodelistascs formInicio)
        {
            IntPasodelistascs = formInicio;
            InitializeComponent();
        }

        private void frmFiltroAvanzado_Load(object sender, EventArgs e)
        {

            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                comboBoxMarca.DataSource = marca.Listar();
                comboBoxMarca.SelectedIndex = -1;
                comboBoxCategoria.DataSource = categoria.Listar();
                comboBoxCategoria.SelectedIndex = -1;
                comboBoxPrecio.Items.Add("Mayor a");
                comboBoxPrecio.Items.Add("Menor a");
                comboBoxPrecio.Items.Add("Entre");
                textBoxPrecio2.Visible = false;
                labelHasta.Visible = false;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void comboBoxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPrecio.SelectedItem.ToString() == "Entre")
            {
                textBoxPrecio2.Visible = true;
                labelDesde.Text = "Desde:";
                labelHasta.Visible = true;
                labelHasta.Text = "Hasta:";
            }
            else
            {
                textBoxPrecio2.Visible = false;
                labelDesde.Text = "Importe:";
                labelHasta.Visible = false;
            }
        }

        private void ValidacionDeBusqueda()
        {
            try
            {
                if (comboBoxMarca.SelectedIndex != -1)
                {
                    //buscamos por marca en particular
                    marcaSeleccionada = true;

                }
                else
                {
                    //tiene que buscar por todas las marcas.
                    marcaSeleccionada = false;
                }

                if (comboBoxCategoria.SelectedIndex != -1)
                {

                    //buscamos por marca en particular
                    categoriaSeleccionada = true;
                }
                else
                {
                    //tiene que buscar por todas las categorias.
                    categoriaSeleccionada = false;
                }

                if (comboBoxPrecio.SelectedIndex == -1 && textBoxPrecio1.Text == string.Empty)
                {
                    opcionPrecioSeleccionada = false;
                    precioCargado = false;
                    //tiene que buscar por lo que este sleeccionado en alguno de los combobox.
                    //Si no hay ninguno distinto de index -1, arrojar message box pidiendo al menos un campo.
                    if (comboBoxMarca.SelectedIndex == -1 && comboBoxCategoria.SelectedIndex == -1)
                    {
                        MessageBox.Show("Se debe seleccionar al menos una opcion de busqueda");
                    }
                }
                else if (comboBoxPrecio.SelectedIndex == -1 && textBoxPrecio1.Text != string.Empty)
                {
                    opcionPrecioSeleccionada = false;
                    precioCargado = true;
                    //arrojar messagebox pidiendo completar el combo box de precio.
                    MessageBox.Show("Se debe seleccionar un criterio para la busqueda de precio");
                }
                else if (comboBoxPrecio.SelectedIndex != -1 && textBoxPrecio1.Text != string.Empty)
                {
                    //buscamos por precio
                    opcionPrecioSeleccionada = true;
                    precioCargado = true;

                }
                else
                {
                    opcionPrecioSeleccionada = true;
                    precioCargado = false;
                    //tiene seleccionado la opcion de precio pero no completo el text box
                    MessageBox.Show("Se debe completar un valor para el precio");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private string ValidacionCriterioPrecio(string criterio) 
        {
            string consulta;

            if(criterio == "Mayor a")
            {
                consulta = "a.Precio > CAST(@PrecioBuscado AS MONEY)";
            }
            else if(criterio == "Menor a")
            {
                consulta = "a.Precio < CAST(@PrecioBuscado AS MONEY)";
            }
            else
            {
                if(textBoxPrecio2 != null)
                {
                    consulta = "a.Precio BETWEEN CAST(@PrecioBuscado AS MONEY) AND CAST(@PrecioHasta AS MONEY)";
                }
                else
                {
                    consulta = "";
                    MessageBox.Show("Se necesita agregar un valor en el campo \"Hasta\". Intentelo nuevamente", "Atencion", MessageBoxButtons.OK);
                }
            }


            return consulta;
        
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string criterioPrecio;
            string consultaSQL;
            string inicioConsulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdMarca as IdMarca, m.Descripcion as NombreMarca, a.IdCategoria as IdCategoria, c.Descripcion as NombreCategoria, a.Precio FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE ";

            List<Articulo> listaArticulosFiltrados = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            
            bool lectura = true;

            try
            {
                ValidacionDeBusqueda();

                if(marcaSeleccionada && opcionPrecioSeleccionada == false && precioCargado == false)
                {
                    if (categoriaSeleccionada)
                    {
                        //solo busca por marca y categoria
                        consultaSQL = inicioConsulta + "m.Id = @IdMarca AND (a.IdCategoria = @IdCategoria OR a.IdCategoria IS NULL)";
                        datos.SetearParametro("@IdMarca",((Marca)comboBoxMarca.SelectedItem).Id);
                        datos.SetearParametro("@IdCategoria", ((Categoria)comboBoxCategoria.SelectedItem).Id);
                    }
                    else
                    {
                        //solo por marca
                        consultaSQL = inicioConsulta + "m.Id = @IdMarca";
                        datos.SetearParametro("@IdMarca", ((Marca)comboBoxMarca.SelectedItem).Id);
                    }
                }
                else if(marcaSeleccionada && opcionPrecioSeleccionada && precioCargado)
                {
                    if (categoriaSeleccionada)
                    {
                        //consulta completa por los 3 parametro
                        criterioPrecio = comboBoxPrecio.SelectedItem.ToString();
                        string consultaPrecio = ValidacionCriterioPrecio(comboBoxPrecio.SelectedItem.ToString());
                        consultaSQL = inicioConsulta + "m.Id = @IdMarca AND c.Id = @IdCategoria AND " + consultaPrecio;
                        datos.SetearParametro("@IdMarca", ((Marca)comboBoxMarca.SelectedItem).Id);
                        datos.SetearParametro("@IdCategoria", ((Categoria)comboBoxCategoria.SelectedItem).Id);
                        datos.SetearParametro("@PrecioBuscado", textBoxPrecio1.Text);
                        datos.SetearParametro("@PrecioHasta", textBoxPrecio2.Text);
                    }
                    else
                    {
                        //busca por marca y precio
                        string consultaPrecio = ValidacionCriterioPrecio(comboBoxPrecio.SelectedItem.ToString());
                        consultaSQL = inicioConsulta + "m.Id = @IdMarca AND " + consultaPrecio;
                        datos.SetearParametro("@IdMarca", ((Marca)comboBoxMarca.SelectedItem).Id);
                        datos.SetearParametro("@PrecioBuscado", textBoxPrecio1.Text);
                        datos.SetearParametro("@PrecioHasta", textBoxPrecio2.Text);
                    }
                }
                else if(marcaSeleccionada == false && opcionPrecioSeleccionada && precioCargado)
                {
                    if (categoriaSeleccionada == false)
                    {
                        //Solo busca por precio (combo box + text box)
                        criterioPrecio = comboBoxPrecio.SelectedItem.ToString();
                        string consultaPrecio = ValidacionCriterioPrecio(comboBoxPrecio.SelectedItem.ToString());
                        consultaSQL = inicioConsulta + consultaPrecio;
                        datos.SetearParametro("@PrecioBuscado", textBoxPrecio1.Text);
                        datos.SetearParametro("@PrecioHasta", textBoxPrecio2.Text);
                    }
                    else
                    {
                        //busca por categoria y por precio.
                        criterioPrecio = comboBoxPrecio.SelectedItem.ToString();
                        string consultaPrecio = ValidacionCriterioPrecio(comboBoxPrecio.SelectedItem.ToString());
                        consultaSQL = inicioConsulta + "c.Id = @IdCategoria AND " + consultaPrecio;
                        datos.SetearParametro("@IdCategoria", ((Categoria)comboBoxCategoria.SelectedItem).Id);
                        datos.SetearParametro("@PrecioBuscado", textBoxPrecio1.Text);
                        datos.SetearParametro("@PrecioHasta", textBoxPrecio2.Text);
                    }
                }
                else if(categoriaSeleccionada && marcaSeleccionada == false  && opcionPrecioSeleccionada == false && precioCargado == false)
                {
                    //busca solo por categoria
                    consultaSQL = inicioConsulta + "c.Id = @IdCategoria";
                    datos.SetearParametro("@IdCategoria", ((Categoria)comboBoxCategoria.SelectedItem).Id);
                }
                else
                {
                    consultaSQL = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdMarca as IdMarca, m.Descripcion as NombreMarca, a.IdCategoria as IdCategoria, c.Descripcion as NombreCategoria, a.Precio FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id";
                }


                datos.SetearConsulta(consultaSQL);
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    lectura = false;
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.CodArt = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    
                    articulo.Marca = new Marca();
                    if (!(datos.Lector["IdMarca"] is DBNull))
                    {
                        articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                        articulo.Marca.Nombre = (string)datos.Lector["NombreMarca"];
                    }
                    else
                    {
                        articulo.Marca.Id = 0;
                        articulo.Marca.Nombre = "S/D";
                    }

                    
                    articulo.Categoria = new Categoria();
                    int aux = (int)datos.Lector["IdCategoria"];
                    if (datos.Lector["NombreCategoria"] is DBNull)
                    {
                        articulo.Categoria.Id = 0;
                        articulo.Categoria.Descripcion = "S/D";
                    }
                    else
                    {
                        articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        articulo.Categoria.Descripcion = (string)datos.Lector["NombreCategoria"];
                    }

                    articulo.Precio = (float)datos.Lector.GetDecimal(8);

                    listaArticulosFiltrados.Add(articulo);
                }


                if (lectura)
                {
                    MessageBox.Show("No hay resultados que coincidan con la busqueda.", "Aviso", MessageBoxButtons.OK);
                }

                IntPasodelistascs.TrasladarLista(listaArticulosFiltrados);
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
