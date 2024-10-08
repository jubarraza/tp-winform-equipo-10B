﻿using Dominio;
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
    public partial class frmArticulos : Form, IntPasodelistascs
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

        private void FormatoColumnas()
        {
            dataGridArticulo.Columns["CodArt"].Width = 60;
            dataGridArticulo.Columns["Precio"].DefaultCellStyle.Format = "$ 0,0.000##";
            dataGridArticulo.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridArticulo.Columns["Precio"].Width = 115;
            dataGridArticulo.Columns["Marca"].Width = 85;
            dataGridArticulo.Columns["Categoria"].Width = 85;
            dataGridArticulo.Columns["Nombre"].Width = 124;
        }
        private void OcultarColumna()
        {
            dataGridArticulo.Columns["Id"].Visible = false;
            dataGridArticulo.Columns["Descripcion"].Visible = false;
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listar();
                dataGridArticulo.DataSource = listaArticulos;
                FormatoColumnas();
                OcultarColumna();
                textBoxBusqueda.Text = string.Empty;
                toolTip.SetToolTip(buttonAgregar, "Agregar articulo");
                toolTip.SetToolTip(buttonModificar, "Editar articulo seleccionado");
                toolTip.SetToolTip(buttonEliminar, "Eliminar articulo seleccionado");
                toolTip.SetToolTip(buttonInformación, "Ampliar informacion de articulo\nAlt+Space");
                toolTip.SetToolTip(buttonFiltroAvanz, "Opciones de filtros avanzados");
                toolTip.SetToolTip(buttonBorrarFiltros, "Limpiar filtros aplicados");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void agregarArticulo()
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
            cargar();
        }

        private void informacionDetalladaArticulo()
        {
            Articulo seleccion;
            try
            {
                if (dataGridArticulo.CurrentRow is null)
                {
                    MessageBox.Show("No hay articulos seleccionados", "Seleccione un articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    seleccion = (Articulo)dataGridArticulo.CurrentRow.DataBoundItem;
                    frmInformacionArticulo info = new frmInformacionArticulo(seleccion);
                    info.ShowDialog();
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void modificarArticulo()
        {
            Articulo seleccion;
            try
            {
                if (dataGridArticulo.CurrentRow is null)
                {
                    MessageBox.Show("No hay articulos seleccionados", "Seleccione un articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    seleccion = (Articulo)dataGridArticulo.CurrentRow.DataBoundItem;

                    frmAltaArticulo Modificar = new frmAltaArticulo(seleccion);
                    Modificar.ShowDialog();
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void eliminarArticulo()
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            Articulo seleccion;
            try
            {
                if (dataGridArticulo.CurrentRow is null)
                {
                    MessageBox.Show("No hay articulos seleccionados", "Seleccione un articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el articulo? Se eliminara toda su informacion incluyendo las imagenes asociadas.", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccion = (Articulo)dataGridArticulo.CurrentRow.DataBoundItem;
                        artNegocio.Eliminar(seleccion.Id);
                        cargar();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            agregarArticulo();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modificarArticulo();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminarArticulo();
        }
        
        private void buttonInformación_Click(object sender, EventArgs e)
        {
            informacionDetalladaArticulo();
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
            FormatoColumnas();
            OcultarColumna();
        }

        private void buttonFiltroAvanz_Click(object sender, EventArgs e)
        {
            frmFiltroAvanzado FiltroAvanzado = new frmFiltroAvanzado(this);
            FiltroAvanzado.ShowDialog();
           
            

        }

        public void TrasladarLista(List<Articulo> articulos)
        {
            dataGridArticulo.DataSource = null;
            dataGridArticulo.DataSource = articulos;
            FormatoColumnas();
            OcultarColumna();
        }


        private void tsm_informacionDetalladaArticulo_Click(object sender, EventArgs e)
        {
            informacionDetalladaArticulo();
        }

        private void tsm_agregarArticulo_Click(object sender, EventArgs e)
        {
            agregarArticulo();
        }

        private void tsm_modificarArticulo_Click(object sender, EventArgs e)
        {
            modificarArticulo();
        }

        private void tsm_eliminarArticulo_Click(object sender, EventArgs e)
        {
            eliminarArticulo();
        }

        private void tsm_verMarcas_Click(object sender, EventArgs e)
        {
            frmMenuMarcas menuMarcas = new frmMenuMarcas();
            menuMarcas.ShowDialog();
        }

        private void tsm_agregarMarca_Click(object sender, EventArgs e)
        {
            frmAlta_Edicion_Marca alta = new frmAlta_Edicion_Marca();
            alta.ShowDialog();
        }

        private void tsm_verCategorias_Click(object sender, EventArgs e)
        {
            frmCategoria menuCategorias = new frmCategoria();
            menuCategorias.ShowDialog();
        }

        private void tsm_agregarCategorias_Click(object sender, EventArgs e)
        {
            frmAgregarModificarCategoria agregar = new frmAgregarModificarCategoria();
            agregar.ShowDialog();
        }

        private void tsm_sobreGestorDeProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La aplicacion \"Gestor de Productos\" fue realizada por el equipo 10B para la materia Programacion 3.\n\nSus integrantes son:\n - Julieta Barraza.\n - Damian Alejandro Sanchez Di Giovanni.\n - Jonatan Rodrigo Guzman.", "Acerca de...", MessageBoxButtons.OK);
        }

        private void tsm_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBorrarFiltros_Click(object sender, EventArgs e)
        {
            cargar();
        }


    }
}
