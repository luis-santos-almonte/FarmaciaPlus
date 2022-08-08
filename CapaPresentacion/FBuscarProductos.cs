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
    public partial class FBuscarProductos : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        CNProductos cNProductos = new CNProductos();

        private void FBuscarProductos_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidproducto = 0;
            MostrarDatos();
            TBBuscar.Focus();
        }

        private void FBuscarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                 "Mensaje de SIGEMP",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void MostrarDatos()
        {
            valorparametro = TBBuscar.Text.Trim();
            if (cNProductos.ObtenerProducto(valorparametro) != null)
            {
                DGVDatos.DataSource = cNProductos.ObtenerProducto(valorparametro);
                DGVDatos.Columns[0].Width = 80;
                DGVDatos.Columns[1].Width = 200;
                DGVDatos.Columns[2].Width = 225;
                DGVDatos.Columns[3].Width = 100;
                DGVDatos.Columns[4].Width = 125;
                DGVDatos.Columns[5].Width = 125; 
 
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVDatos.Refresh(); //Se refresca el DataGridView

        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
                indice = DGVDatos.CurrentRow.Index;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
            {
                Program.modificar = true;
                Program.vidproducto = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
            }
            Close();

        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice = indice - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if(indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            BAceptar_Click(sender, e);
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (TBBuscar.Text != String.Empty)
            {
                vtieneparametro = 1;
                valorparametro = "%" + TBBuscar.Text.Trim() + "%";
                //valorparametro = tbBuscar.Text.Trim();
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }
            MostrarDatos();
        }

        public FBuscarProductos()
        {
            InitializeComponent();
        }
    }
}
