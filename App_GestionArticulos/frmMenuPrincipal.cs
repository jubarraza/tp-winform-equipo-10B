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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_MenuMarcas_Click(object sender, EventArgs e)
        {
            frmMenuMarcas menuMarcas = new frmMenuMarcas();
            menuMarcas.ShowDialog();
        }

        private void btn_MenuArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos frmArticulos = new frmArticulos();
            frmArticulos.ShowDialog();
            
        }

        private void btn_MenuCategorias_Click(object sender, EventArgs e)
        {
            frmCategoria menuCategorias = new frmCategoria();
            menuCategorias.ShowDialog();
        }
    }
}
