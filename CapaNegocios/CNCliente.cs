using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CNCliente
    {
        public static string Insertar(string pNombre, string pApellido, string pDireccion, DateTime pFechaIngreso, string pEstado)
        {
            CDClientes objClientes = new CDClientes();
            objClientes.Nombre = pNombre;
            objClientes.Apellido = pApellido;
            objClientes.Direccion = pDireccion;
            objClientes.Fecha = pFechaIngreso;
            objClientes.Estado = pEstado;

            return objClientes.Insertar(objClientes);
        }
        public static string Actualizar(int pID, string pNombre, string pApellido, string pDireccion, DateTime pFechaIngreso, string pEstado)
        {
            CDClientes objClientes = new CDClientes();
            objClientes.ID = pID;
            objClientes.Nombre = pNombre;
            objClientes.Apellido = pApellido;
            objClientes.Direccion = pDireccion;
            objClientes.Fecha = pFechaIngreso;
            objClientes.Estado = pEstado;

            return objClientes.Actualizar(objClientes);
        }
        public DataTable ObtenerCliente(string parametro)
        {
            CDClientes objClientes = new CDClientes();
            DataTable dt = new DataTable();
            dt = objClientes.ClienteConsultar(parametro);

            return dt;
        }
    }
}
