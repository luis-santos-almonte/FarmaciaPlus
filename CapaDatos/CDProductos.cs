using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
    public class CDProductos
    {
        private int dID_Medicamentos;
        private string dNombre, dDescripcion, dTipo_Venta, dEstado;
        private decimal dStock, dPrecio;
        public CDProductos()
        {

        }

        public CDProductos(int idmedic, string pnombre,
        string pdescripcion, decimal pstock, decimal pprecio, string ptipo, string pestado)
        {

        }

        public int ID
        {
            get { return dID_Medicamentos; }
            set { dID_Medicamentos = value; }
        }
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        public decimal Stock
        {
            get { return dStock; }
            set { dStock = value; }
        }
        public decimal Precio
        {
            get { return dPrecio; }
            set { dPrecio = value; }
        }
        public string Tipo_Venta
        {
            get { return dTipo_Venta; }
            set { dTipo_Venta = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        public string Insertar(CDProductos objProductos)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("ProductoInsertar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@pnombre", objProductos.Nombre);
                Comando.Parameters.AddWithValue("@pdescripcion", objProductos.Descripcion);
                Comando.Parameters.AddWithValue("@pstock", objProductos.Stock);
                Comando.Parameters.AddWithValue("@pprecio", objProductos.Precio);
                Comando.Parameters.AddWithValue("@ptipo", objProductos.Tipo_Venta);
                Comando.Parameters.AddWithValue("@pestado", objProductos.Estado);

                mensaje = Comando.ExecuteNonQuery() == 1 ? "Inserción de datos completa." :
                    "Error al insertar los datos.";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return mensaje;
        }
        public string Actualizar(CDProductos objProductos)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("ProductoActualizar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@pnombre", objProductos.Nombre);
                Comando.Parameters.AddWithValue("@pdescripcion", objProductos.Descripcion);
                Comando.Parameters.AddWithValue("@pstock", objProductos.Stock);
                Comando.Parameters.AddWithValue("@pprecio", objProductos.Precio);
                Comando.Parameters.AddWithValue("@ptipo", objProductos.Tipo_Venta);
                Comando.Parameters.AddWithValue("@pestado", objProductos.Estado);

                mensaje = Comando.ExecuteNonQuery() == 1 ? "Actualizar de datos completa." :
                    "Error al actualizar los datos.";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return mensaje;
        }
        public DataTable ProductoConsultar(string parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = new CapaDatosConnection().dbconexion;
                Comando.Connection.Open();
                Comando.CommandText = "ProductoConsultar";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@pvalor", parametro);
                dr = Comando.ExecuteReader();
                dt.Load(dr);
                Comando.Connection.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;
        }
    }
}
