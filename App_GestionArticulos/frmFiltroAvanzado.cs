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
                comboBoxCategoria.DataSource = categoria.Listar();
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            String marca = comboBoxMarca.SelectedItem.ToString();
            string categoria = comboBoxCategoria.SelectedItem.ToString();
            string precio;
            bool lectura = true;

         
          

            

            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (object.ReferenceEquals(null, comboBoxPrecio.SelectedItem))
                {
                    precio = "0";
                }
                else
                {
                    precio = comboBoxPrecio.SelectedItem.ToString();
                }



                string consulta = "select AR.Id, AR.Codigo, AR.Nombre, AR.Descripcion, MA.Id as IdMarca, MA.Descripcion" +
                    " as Marca, CA.Id as IdCategoria, CA.Descripcion as Categoria, AR.Precio from ARTICULOS as AR left join " +
                    "MARCAS as MA on AR.IdMarca = MA.Id left join CATEGORIAS as CA on AR.IdCategoria = CA.Id where ";


                if (precio != "0")
                {
                    switch (precio)
                    {
                        case "Mayor a":
                            precio = "Precio > " + textBoxPrecio1.Text;
                            break;
                        case "Menor a":
                            precio = "Precio < " + textBoxPrecio1.Text;
                            break;
                        case "Entre":
                            precio = "Precio >= " + textBoxPrecio1.Text + " And Precio <= " + textBoxPrecio2.Text;                          break;
                    }
                }


                if (!string.IsNullOrEmpty(marca) && !string.IsNullOrEmpty(categoria))
                {
                    if (precio != "0")
                    {
                        consulta += "MA.Descripcion like '" + marca + "' and CA.Descripcion like '" + categoria + "' and " + precio;
                    }
                    else
                    {
                        consulta += "MA.Descripcion like '" + marca + "' and CA.Descripcion like '" + categoria + "'";
                    }
                }
                else if (string.IsNullOrEmpty(marca) && !string.IsNullOrEmpty(categoria))
                {
                    if (precio != "0")
                    {
                        consulta += "CA.Descripcion like '" + categoria + "' and " + precio;
                    }
                    else
                    {
                        consulta += "CA.Descripcion like '" + categoria + "'";
                    }
                }

                datos.SetearConsulta(consulta);
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
                    if (!(datos.Lector["Marca"] is DBNull))
                    {
                        articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                        articulo.Marca.Nombre = (string)datos.Lector["Marca"];
                    }
                    else
                    {
                        articulo.Marca.Nombre = "S/D";
                    }

                    articulo.Categoria = new Categoria();

                    if (!(datos.Lector["Categoria"] is DBNull))
                    {

                        articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    else
                    {
                        articulo.Categoria.Descripcion = "S/D";
                    }

                    articulo.Precio = (float)datos.Lector.GetDecimal(8);

                    articulos.Add(articulo);
                }


                if (lectura)
                {
                    DialogResult respuesta =
                    MessageBox.Show("No se encontraron resultados", "Mensaje");
                    return;
                }

                IntPasodelistascs.TrasladarLista(articulos);
                this.Close();
               

              

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
