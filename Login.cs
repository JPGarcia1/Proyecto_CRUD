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
    public partial class Login : Form
    {
        string usuario = "jeank";
        string contraseña = "12345";
        public Login()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                MessageBox.Show("SI");
                FrMenu menu = new FrMenu();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("USI");
            }
        }
    }
}