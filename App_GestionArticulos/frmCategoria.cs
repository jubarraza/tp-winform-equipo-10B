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
using Negocio;

namespace App_GestionArticulos
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private List<Categoria> listaCategorias;
        private void Cargar()
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            try
            {
                listaCategorias = catNegocio.Listar();
                dgvCategorias.DataSource = listaCategorias;
                dgvCategorias.Columns["Id"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarModificarCategoria agregar = new frmAgregarModificarCategoria();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Categoria seleccion;
            seleccion = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAgregarModificarCategoria modificacion = new frmAgregarModificarCategoria(seleccion);
            modificacion.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            Categoria seleccion;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Eliminarlo? ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccion = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    bool validacion = catNegocio.validarEliminacion(seleccion.Id);
                    if (validacion) 
                    {
                        catNegocio.Eliminar(seleccion.Id);
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar la Categoria.\nError: la categoria se encuentra asignada en un Articulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    
                    
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

