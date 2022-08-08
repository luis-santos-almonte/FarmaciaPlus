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
    public class CNFactura
    {
        public static string Insertar(int pIdCliente, int pIdEmpleado, DateTime pFecha)
        {
            CDFactura objProductos = new CDFactura();
            objProductos.ID_Cliente = pIdCliente;
            objProductos.ID_Empleado = pIdEmpleado;
            objProductos.Fecha = pFecha;

            return objProductos.Insertar(objProductos);
        }
        public DataTable ObtenerFactura(string parametro)
        {
            CDFactura objProductos = new CDFactura();
            DataTable dt = new DataTable();
            dt = objProductos.FacturaConsultar(parametro);

            return dt;
        }
    }
}
