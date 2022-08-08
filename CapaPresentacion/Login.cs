using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        CNUsuario objUsuario = new CNUsuario();
        public Login()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAcceder_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == String.Empty)
            {
                MessageBox.Show("Introduzca el Usuario!", "Farmacia Plus");
                tbUsuario.Focus();
                return;
            }
            if (tbContraseña.Text == String.Empty)
            {
                MessageBox.Show("Introduzca la Contraseña!", "Farmacia Plus");
                tbContraseña.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = objUsuario.Acceder(tbUsuario.Text, tbContraseña.Text);

            if (dt.Rows.Count > 0)
            {
                Menu fMenu = new Menu();
                fMenu.Show();
                tbUsuario.Text = "";
                tbContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario no autorizado!", "Farmacia Plus");
            }
        }
    }
}
