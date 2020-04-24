using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
using System.Data.SqlClient;

namespace Controlador
{
    public class DaoSexo
    {
        private SqlConnection con;
        public DaoSexo() {
            con = new Conexion().getConexion();
        }




        // Método Read
        public Sexo Read(int idSexo) {
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SexoRead";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int, 1).Value = idSexo;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Sexo s = null;
                while (dr.Read()) {
                    s = new Sexo();
                    s.IdSexo = int.Parse(dr[0].ToString());
                    s.Descripcion = dr[1].ToString();
                }
                con.Close();
                return s;
            }
            catch (Exception) {
                return null;
            }
        }

        // Método ReadAll
        public List<Sexo> ReadAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SexoReadAll"; 
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                List<Sexo> lista = new List<Sexo>();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Sexo s = new Sexo();
                    s.IdSexo = int.Parse(dr[0].ToString());
                    s.Descripcion = dr[1].ToString();
                    lista.Add(s);
                }
                con.Close();
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
