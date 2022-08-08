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
    public class CDClientes
    {
        private int dID_Cliente;
        private string dNombre, dApellido, dDireccion, dEstado;
        private DateTime dFecha;
        public CDClientes()
        {

        }
        public CDClientes(int idCliente, string pnombre,
        string papellido, string pdireccion, DateTime pfechaingreso, string pestado)
        {

        }
        public int ID
        {
            get { return dID_Cliente; }
            set { dID_Cliente = value; }
        }
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Apellido
        {
            get { return dApellido; }
            set { dApellido = value; }
        }
        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }
        public DateTime Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        public string Insertar(CDClientes objCliente)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("ClienteInsertar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@pnombre", objCliente.Nombre);
                Comando.Parameters.AddWithValue("@papellido", objCliente.Apellido);
                Comando.Parameters.AddWithValue("@pdireccion", objCliente.Direccion);
                Comando.Parameters.AddWithValue("@pfechaingreso", objCliente.Fecha);
                Comando.Parameters.AddWithValue("@pestado", objCliente.Estado);

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
        public string Actualizar(CDClientes objCliente)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("ClienteActualizar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@pID", objCliente.ID);
                Comando.Parameters.AddWithValue("@pnombre", objCliente.Nombre);
                Comando.Parameters.AddWithValue("@papellido", objCliente.Apellido);
                Comando.Parameters.AddWithValue("@pdireccion", objCliente.Direccion);
                Comando.Parameters.AddWithValue("@pfechaingreso", objCliente.Fecha);
                Comando.Parameters.AddWithValue("@pestado", objCliente.Estado);

                mensaje = Comando.ExecuteNonQuery() == 1 ? "Actualizacion de datos completa." :
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
        public DataTable ClienteConsultar(string parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = new CapaDatosConnection().dbconexion;
                Comando.Connection.Open();
                Comando.CommandText = "ClienteConsultar";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@pvalor", parametro);
                dr = Comando.ExecuteReader();
                dt.Load(dr);
                Comando.Connection.Close();
            }
            catch(Exception ex){
                dt = null;
            }
            return dt;
        }
    }
}
