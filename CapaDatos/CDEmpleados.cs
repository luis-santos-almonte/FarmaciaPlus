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
    public class CDEmpleados
    {
        private int dID_Empleado;
        private string dNombre, dApellido, dDireccion, dEstado;
        private DateTime dFechaNac, dFechaIng;
        public CDEmpleados()
        {

        }
        public CDEmpleados(int idempleado, string pnombre,
        string papellido, string pdireccion, DateTime pfechanac, DateTime pfechaingreso, string pestado)
        {

        }
        public int ID
        {
            get { return dID_Empleado; }
            set { dID_Empleado = value; }
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
        public DateTime FechaNac
        {
            get { return dFechaNac; }
            set { dFechaNac = value; }
        }
        public DateTime FechaIng
        {
            get { return dFechaIng; }
            set { dFechaIng = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        public string Insertar(CDEmpleados objEmpleados)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("EmpleadoInsertar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@pnombre", objEmpleados.Nombre);
                Comando.Parameters.AddWithValue("@papellido", objEmpleados.Apellido);
                Comando.Parameters.AddWithValue("@pfechanac", objEmpleados.FechaNac);
                Comando.Parameters.AddWithValue("@pfechaingreso", objEmpleados.FechaIng);
                Comando.Parameters.AddWithValue("@pdireccion", objEmpleados.Direccion);
                Comando.Parameters.AddWithValue("@pestado", objEmpleados.Estado);

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
        public string Actualizar(CDEmpleados objEmpleados)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("EmpleadoActualizar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@pnombre", objEmpleados.Nombre);
                Comando.Parameters.AddWithValue("@papellido", objEmpleados.Apellido);
                Comando.Parameters.AddWithValue("@pfechanac", objEmpleados.FechaNac);
                Comando.Parameters.AddWithValue("@pfechaingreso", objEmpleados.FechaIng);
                Comando.Parameters.AddWithValue("@pdireccion", objEmpleados.Direccion);
                Comando.Parameters.AddWithValue("@pestado", objEmpleados.Estado);

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
        public DataTable EmpleadoConsultar(string parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = new CapaDatosConnection().dbconexion;
                Comando.Connection.Open();
                Comando.CommandText = "EmpleadoConsultar";
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
