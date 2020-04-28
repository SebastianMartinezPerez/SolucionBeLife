using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
using System.Data.SqlClient;

namespace Controlador
{
    public class DaoPlan
    {
        private SqlConnection con;
        public DaoPlan()
        {
            con = new Conexion().getConexion();
        }

        // Método Read
        public Plan Read(string idPlan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PlanRead";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar, 5).Value = idPlan;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Plan p = null;
                while (dr.Read())
                {
                    p = new Plan();
                    p.IdPlan = dr[0].ToString();
                    p.Nombre = dr[1].ToString();
                    p.PrimaBase = float.Parse(dr[2].ToString());
                    p.PolizaActual = dr[3].ToString();
                }
                con.Close();
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Método ReadAll
        public List<Plan> ReadAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PlanReadAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                List<Plan> lista = new List<Plan>();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Plan p = new Plan();
                    p.IdPlan = dr[0].ToString();
                    p.Nombre = dr[1].ToString();
                    p.PrimaBase = float.Parse(dr[2].ToString());
                    p.PolizaActual = dr[3].ToString();
                    lista.Add(p);
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
