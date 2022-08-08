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
    public class CNProductos
    {
        public static string Insertar(string pNombre, string pDescripcion, int pStock, int pPrecio, string pTipo_Venta, string pEstado)
        {
            CDProductos objProductos = new CDProductos();
            objProductos.Nombre = pNombre;
            objProductos.Descripcion = pDescripcion;
            objProductos.Stock = pStock;
            objProductos.Precio = pPrecio;
            objProductos.Tipo_Venta = pTipo_Venta;
            objProductos.Estado = pEstado;

            return objProductos.Insertar(objProductos);
        }
        public static string Actualizar(int pID, string pNombre, string pDescripcion, int pStock, int pPrecio, string pTipo_Venta, string pEstado)
        {
            CDProductos objProductos = new CDProductos();
            objProductos.ID = pID;
            objProductos.Nombre = pNombre;
            objProductos.Descripcion = pDescripcion;
            objProductos.Stock = pStock;
            objProductos.Precio = pPrecio;
            objProductos.Tipo_Venta = pTipo_Venta;
            objProductos.Estado = pEstado;

            return objProductos.Actualizar(objProductos);
        }
        public DataTable ObtenerProducto(string parametro)
        {
            CDProductos objProductos = new CDProductos();
            DataTable dt = new DataTable();
            dt = objProductos.ProductoConsultar(parametro);

            return dt;
        }
    }
}
