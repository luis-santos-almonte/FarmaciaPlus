using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocios;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class MantCliente : Form
    {
        public string valorparametro = "", mensaje = "";
        public MantCliente()
        {
            InitializeComponent();
        }
        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MantCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto te hará salir del formulario! \n Seguro que desea hacerlo?",
                                "Mensaje de Farmacia PLUS",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        public void LimpiarObjetos()
        {
            TBIDCliente.Clear();
            TBNombre.Clear();
            TBApellido.Clear();
            TBDireccion.Clear();
            CBEstado.SelectedItem = 0;
        }        
        public void HabilitarControles(bool valor)
        {
            TBIDCliente.ReadOnly = valor;
            TBNombre.Enabled = valor;
            TBApellido.Enabled =valor;
            TBDireccion.Enabled = valor;
            DTFechaIngreso.Enabled = valor;
            CBEstado.Enabled = valor;

            if (Program.nuevo)
                CBEstado.SelectedItem = 0;
        }
        public void HabilitarBotones()
        {
            if (Program.nuevo|| Program.modificar)
            {
                HabilitarControles(true);
                BNuevo.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                BBuscar.Enabled = false;
                BCancelar.Enabled = true;
            }
            else
            {
                HabilitarControles(false);
                BNuevo.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = false;
                BBuscar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if(TBNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del cliente!");
                TBNombre.Focus();
            }
            else if(TBApellido.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBApellido.Focus();
            }
            else if (TBDireccion.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la dirección del cliente!");
                TBDireccion.Focus();
            }
            else if (DTFechaIngreso.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la fecha del cliente!");
                DTFechaIngreso.Focus();
            }
            else if (CBEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                CBEstado.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    mensaje = CNCliente.Insertar(TBNombre.Text, TBApellido.Text, TBDireccion.Text, DTFechaIngreso.Value, CBEstado.Text);
                }
                else
                {
                    mensaje = CNCliente.Actualizar(Program.vidcliente, TBNombre.Text, TBApellido.Text, TBDireccion.Text, DTFechaIngreso.Value, CBEstado.Text);
                }
            }
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones();
            LimpiarObjetos();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!TBIDCliente.Equals(""))
            {
                Program.modificar = true;
                HabilitarBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Suplidor para poder modificar sus datos!");
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones();
            LimpiarObjetos();
        }

        private void MantCliente_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones();
        }

        private void MantCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (Program.modificar)
            {
                Program.vidcliente = Convert.ToInt32(TBIDCliente.Text);
                RecuperarDatos();
                BEditar_Click(sender, e);
            }
            else
            {
                LimpiarObjetos();
                BBuscar.Focus();
            }
        }
        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitarBotones();
            TBNombre.Focus();
        }
        public void RecuperarDatos()
        {
            string vparametro = Program.vidcliente.ToString();
            CNCliente cncliente = new CNCliente();
            DataTable dt = new DataTable();
            dt = cncliente.ObtenerCliente(vparametro);

            foreach (DataRow row in dt.Rows)
            {
                TBIDCliente.Text = row["IdCliente"].ToString();
                TBNombre.Text = row["Nombre"].ToString();
                TBApellido.Text = row["Apellido"].ToString();
                TBDireccion.Text = row["Direccion"].ToString();
                DTFechaIngreso.Text = row["Fecha"].ToString();
                CBEstado.Text = row["Estado"].ToString();

            }
        } 

    }
}
