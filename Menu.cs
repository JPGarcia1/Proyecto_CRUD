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
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
        }

        private void wToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrProductos productos = new FrProductos();
            this.Hide();
            productos.ShowDialog();
        }
    }
}
