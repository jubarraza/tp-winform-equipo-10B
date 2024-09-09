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

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria agregar = new frmAgregarCategoria();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccion;
            seleccion = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAgregarCategoria modificacion = new frmAgregarCategoria(seleccion);
            modificacion.ShowDialog();
            Cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            Categoria seleccion;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Eliminarlo? ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccion = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    catNegocio.Eliminar(seleccion.Id);
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
