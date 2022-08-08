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
    public class CDDetalleFactura
    {
        private int dID_Detalle, dID_Factura, dID_Producto;
        private decimal dCantidad, dPrecio_Unitario;
        public CDDetalleFactura()
        {

        }
        public CDDetalleFactura(int pID_Detalle, int pID_Factura, int pID_Producto, decimal pCantidad, decimal pPrecio_Unitario)
        {

        }
        public int ID_Detalle
        {
            get { return dID_Detalle; }
            set { dID_Detalle = value; }
        }
        public int ID_Factura
        {
            get { return dID_Factura; }
            set { dID_Factura = value; }
        }
        public int ID_Producto
        {
            get { return dID_Producto; }
            set { dID_Producto = value; }
        }
        public decimal Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }
        public decimal Precio_Unitario
        {
            get { return dPrecio_Unitario; }
            set { dPrecio_Unitario = value; }
        }
        public string Insertar(CDDetalleFactura objDetalleFatura)
        {
            string mensaje = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = CapaDatosConnection.Conexion;
                SqlCommand Comando = new SqlCommand("DetalleInsertar", sqlcon);
                sqlcon.Open();
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@idCliente", objDetalleFatura.ID_Factura);
                Comando.Parameters.AddWithValue("@idEmpleado", objDetalleFatura.ID_Producto);
                Comando.Parameters.AddWithValue("@fecha", objDetalleFatura.Cantidad);
                Comando.Parameters.AddWithValue("@fecha", objDetalleFatura.Precio_Unitario);

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
        public DataTable DetalleConsultar(string parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = new CapaDatosConnection().dbconexion;
                Comando.Connection.Open();
                Comando.CommandText = "DetalleConsultar";
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
