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
    public class CNDetalleFactura
    {
        public static string Insertar(int pIdFactura, int pIdProducto, decimal pCantidad, decimal pPrecio)
        {
            CDDetalleFactura objDetalleFactura = new CDDetalleFactura();
            objDetalleFactura.ID_Factura = pIdFactura;
            objDetalleFactura.ID_Producto = pIdProducto;
            objDetalleFactura.Cantidad = pCantidad;
            objDetalleFactura.Precio_Unitario = pPrecio;

            return objDetalleFactura.Insertar(objDetalleFactura);
        }
        public DataTable ObtenerDetalle(string parametro)
        {
            CDDetalleFactura objDetalleFactura = new CDDetalleFactura();
            DataTable dt = new DataTable();
            dt = objDetalleFactura.DetalleConsultar(parametro);

            return dt;
        }
    }
}
