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
    public class CDFactura
    {
        private int dID_Factura, dID_Cliente, dID_Empleado;
        private DateTime dFecha;
        public CDFactura()
        {

        }
        public CDFactura(int idFactura, int idCliente, int idEmpleado, DateTime fecha)
        {

        }
        public int ID_Factura
        {
            get { return dID_Factura; }
            set { dID_Factura = value; }
        }
        public int ID_Cliente
        {
            get { return dID_Cliente; }
            set { dID_Cliente = value; }
        }
        public int ID_Empleado
        {
            get { return dID_Empleado; }
            set { dID_Empleado = value; }
        }
        public DateTime Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }
        public string Insertar(CDFactura objFactura)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("FacturaInsertar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@idCliente", objFactura.ID_Cliente);
                Comando.Parameters.AddWithValue("@idEmpleado", objFactura.ID_Empleado);
                Comando.Parameters.AddWithValue("@fecha", objFactura.Fecha);

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
        public string Actualizar(CDFactura objFactura)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("FacturaActualizar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@idCliente", objFactura.ID_Cliente);
                Comando.Parameters.AddWithValue("@idEmpleado", objFactura.ID_Empleado);
                Comando.Parameters.AddWithValue("@fecha", objFactura.Fecha);

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
        public DataTable FacturaConsultar(string parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = new CapaDatosConnection().dbconexion;
                Comando.Connection.Open();
                Comando.CommandText = "FacturaConsultar";
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
