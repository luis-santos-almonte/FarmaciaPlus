using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CapaDatos
{
    public class CapaDatosConnection
    {
        public static string Conexion = @"Data Source=
        (LocalDB)\MSSQLLocalDB;AttachDbFilename=
        C:\ProyectosCapellan\New folder\FarmaciaPlus\CapaDatos\DBFarmacia.mdf;
        Integrated Security = True";
        public SqlConnection dbconexion = new SqlConnection(Conexion);
    }
}
