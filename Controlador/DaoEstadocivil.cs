using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
using System.Data.SqlClient;

namespace Controlador
{
    public class DaoEstadocivil
    {
        private SqlConnection con;
        public DaoEstadocivil()
        {
            con = new Conexion().getConexion();
        }


        // Método Read
        public EstadoCivil Read(int idEstCivil)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EstadoCivilRead";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@idEstCivil", System.Data.SqlDbType.Int, 1).Value = idEstCivil;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                EstadoCivil ec = null;
                while (dr.Read())
                {
                    ec = new EstadoCivil();
                    ec.estadoCivil = int.Parse(dr[0].ToString());
                    ec.Descripcion = dr[1].ToString();
                }
                con.Close();
                return ec;
            }
            catch (Exception)
            {
                return null;
            }
        }


        // Método ReadAll
        public List<EstadoCivil> ReadAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EstadoCivilReadAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                List<EstadoCivil> lista = new List<EstadoCivil>();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EstadoCivil ec = new EstadoCivil();
                    ec.estadoCivil = int.Parse(dr[0].ToString());
                    ec.Descripcion = dr[1].ToString();
                    lista.Add(ec);
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
