using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FProcVenta : Form
    {
        public FProcVenta()
        {
            InitializeComponent();
            DGDetalle.ColumnCount = 4;
            DGDetalle.Columns[0].Name = "ID Producto";
            DGDetalle.Columns[1].Name = "Producto";
            DGDetalle.Columns[2].Name = "Cantidad";
            DGDetalle.Columns[3].Name = "Precio";
            DGDetalle.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGDetalle.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGDetalle.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGDetalle.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        public static int vidmercancia = 0, vexistencia = 0, vcantidad = 0, vreorden = 0;
        public static string vmercancia;
        public static double vprecio;
        public static bool selecciono = false;
        public static string miconexion = "Data Source=HDX16T;Initial Catalog = DBSIGEM; Integrated Security = True;";

        private void BCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
        }

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            FBuscarProductos fBuscarSuplidor = new FBuscarProductos();
            fBuscarSuplidor.ShowDialog();
            if (Program.modificar) 
            {
                RecuperaDatos();
                TBCantidad.Focus();
            }
            else
            {
                Limpiar();
                BBuscarProducto.Focus();
            }

        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidproducto.ToString();
            CNProductos cNProductos = new CNProductos();
            DataTable dt = new DataTable();
            dt = cNProductos.ObtenerProducto(vparametro);
            foreach (DataRow row in dt.Rows)
            {
                TBCodigo.Text = row["IdMedicamentos"].ToString();
                TBProducto.Text = row["Nombre"].ToString();
                TBPrecio.Text = row["Precio"].ToString();
            }
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            TBEmpleado.Focus();
        }

        private void TBCantidad_Leave(object sender, EventArgs e)
        {
            if (TBCantidad.Text != string.Empty)
            {
                vcantidad = Convert.ToInt32(TBCantidad.Text);
                if (vcantidad < vexistencia)
                {
                    MessageBox.Show("No hay suficiente existencia de la mercancia indicada!");

                    TBProducto.Focus();
                }
                else
                {
                    vprecio = Convert.ToDouble(TBPrecio.Text);
                    TBImporte.Text = Convert.ToString(vcantidad * vprecio);
                }
            }
            else
            {
                MessageBox.Show("Debe indicar la cantidad vendida!");
                TBCantidad.Focus();
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TBNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del cliente!");
                TBNombre.Focus();
            }
            else if (TBApellido.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBApellido.Focus();
            }
            else if (TBVenta.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la dirección del cliente!");
                TBVenta.Focus();
            }
            else if (TBEmpleado.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la fecha del cliente!");
                TBEmpleado.Focus();
            }
            else if (DTFecha.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                DTFecha.Focus();
            }
            else if (TBCLiente.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBCLiente.Focus();
            }
            else if (TBCodigo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBCodigo.Focus();
            }
            else if (TBProducto.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBProducto.Focus();
            }
            else if (TBPrecio.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBPrecio.Focus();
            }
            else if (TBCantidad.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBCantidad.Focus();
            }
            else if (TBImporte.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente!");
                TBImporte.Focus();
            }
            else
            {
                CNFactura.Insertar(Convert.ToInt32(TBCLiente.Text), Convert.ToInt32(TBEmpleado.Text), DTFecha.Value);
                for (int i = 0; i < DGDetalle.Rows.Count; i++)
                {
                    CNDetalleFactura.Insertar(Convert.ToInt32(TBVenta.Text), Convert.ToInt32(DGDetalle.Rows[i].Cells["Producto"]), Convert.ToDecimal(DGDetalle.Rows[i].Cells["Cantidad"]), Convert.ToDecimal(DGDetalle.Rows[i].Cells["Precio"]));
                }
            }
                Limpiar();


        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            String[] Datos = new string[] {TBCodigo.Text, TBProducto.Text, TBCantidad.Text, TBPrecio.Text };
            DGDetalle.Rows.Add(Datos);
            DGDetalle.Refresh(); //Se refresca el DataGridView
            if (LTotal.Text == "_____________")
            {
                LTotal.Text = "0";
                int vTotal = Convert.ToInt32(LTotal.Text);
                vTotal += Convert.ToInt32(TBImporte.Text);
                LTotal.Text = Convert.ToString(vTotal);
            }
            else
            {
                int vTotal = Convert.ToInt32(LTotal.Text);
                vTotal += Convert.ToInt32(TBImporte.Text);
                LTotal.Text = Convert.ToString(vTotal);
            }

        }


        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Limpiar()
        {
            TBVenta.Text = string.Empty;
            TBEmpleado.Text = string.Empty;
            DTFecha.Value = System.DateTime.Now.Date;
            //de cliente
            TBCLiente.Text = string.Empty;
            TBNombre.Text = string.Empty;
            TBApellido.Text = string.Empty;
            //de mercancia
            TBProducto.Text = string.Empty;
            TBCodigo.Text = string.Empty;
            TBPrecio.Text = string.Empty;
            TBCantidad.Text = string.Empty;
            TBImporte.Text = string.Empty;
            // los labels
            LTotal.Text = "_____";
            //variables
            vidmercancia = 0; vexistencia = 0; vcantidad = 0;
            vmercancia = ""; vprecio = 0.00; vreorden = 0;
            selecciono = false;
        }

        private void MostrarMercancia()
        {
            SqlConnection mi_conexion = new SqlConnection(miconexion);
            try
            {
                SqlCommand miinstruccion = mi_conexion.CreateCommand();
                miinstruccion.CommandText = "Select IdMedicamentos, Nombre, Stock, Precio From Productos Where IdMecicamentos = "+Convert.ToInt32(vidmercancia);
                mi_conexion.Open();
                //creamos el objeto datareader
                SqlDataReader midatareader = miinstruccion.ExecuteReader();
                //Leer la fila devuelta usando el obejto SqlDataReader
                midatareader.Read();
                //Pasar los valores a las variables
                vmercancia = Convert.ToString(midatareader["Nombre"]);
                vexistencia = Convert.ToInt32(midatareader["Stock"]);
                vprecio = Convert.ToDouble(midatareader["Precio"]);
                //Mostrar los valores de las columnas contenidas en el Objeto
                //SqlDataReader
                TBCodigo.Text = Convert.ToString(midatareader["IdMedicamentos"]);
                TBProducto.Text = Convert.ToString(midatareader["Nombre"]);
                TBPrecio.Text = Convert.ToString(midatareader["Precio"]);
                TBCantidad.Text = Convert.ToString(midatareader["Stock"]);
                //Cerrar el Objeto SqlDataReader al terminar de usarlo
                MessageBox.Show("2");
                midatareader.Close();
                mi_conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al realizar la operación solicitada! ");
            }
        }

    }
}
