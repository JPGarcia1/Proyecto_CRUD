using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CRUD
{
    public partial class FrProductos : Form
    {
        public FrProductos()
        {
            InitializeComponent();
        }
        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarProducto.Visible = true;
            PnlConsultarProducto.Visible = false;
            PnlModificarProducto.Visible = false;
            PnlEliminar.Visible = false;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarProducto.Visible = false;
            PnlConsultarProducto.Visible = true;
            PnlModificarProducto.Visible = false;
            PnlEliminar.Visible = false;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarProducto.Visible = false;
            PnlConsultarProducto.Visible = false;
            PnlModificarProducto.Visible = true;
            PnlEliminar.Visible = false;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlIngresarProducto.Visible = false;
            PnlConsultarProducto.Visible = false;
            PnlModificarProducto.Visible = false;
            PnlEliminar.Visible = true;
        }
    }
}