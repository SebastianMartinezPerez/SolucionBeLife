using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controlador
{
    public class Conexion
    {
        private static SqlConnection con;
        private string cadena =
            @"Data Source=SEBASTIÁN;Initial Catalog=BeLife;Integrated Security=True";
        /*
         * Cadena Sebastián : @"Data Source=SEBASTIÁN;Initial Catalog=BeLife;Integrated Security=True";
         * Cadena 2: 
         * Cadena 3:
        */
        public Conexion()
        {
            if (con == null)
            {
                con = new SqlConnection(cadena);
            }

        }

        public SqlConnection getConexion()
        {
            return con;
        }

    }

}
