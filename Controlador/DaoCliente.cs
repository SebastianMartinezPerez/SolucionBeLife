using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
using System.Data.SqlClient;

namespace Controlador
{
    public class DaoCliente
    {
        private SqlConnection con;
        public DaoCliente()
        {
            con = new Conexion().getConexion();
        }


        // Método create
        public bool Create(Cliente c) {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ClienteCreate";
                cmd.Connection = con;
                cmd.Parameters.Add("@rut", System.Data.SqlDbType.NVarChar, 10).Value = c.RutCliente;
                cmd.Parameters.Add("@nombres", System.Data.SqlDbType.NVarChar, 20).Value = c.Nombres;
                cmd.Parameters.Add("@apellidos", System.Data.SqlDbType.NVarChar, 20).Value = c.Apellidos;
                cmd.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.Date).Value = c.FechaNacimiento;
                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.Int, 2).Value = c.sexo.IdSexo;
                cmd.Parameters.Add("@estadoCivil", System.Data.SqlDbType.Int, 2).Value = c.estadoCivil.idEstadoCivil;
                con.Open();
                int x = cmd.ExecuteNonQuery();
                con.Close();
                return x > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método delete
        public bool Delete(Cliente c)
        {
            if (new DaoContrato().CantContratos(c.RutCliente) > 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "ClienteDelete";
                    cmd.Connection = con;
                    cmd.Parameters.Add("@rut", System.Data.SqlDbType.NVarChar, 10).Value = c.RutCliente;
                    con.Open();
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    return x > 0 ? true : false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        // Método update
        public bool Update(Cliente c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ClienteUpdate";
                cmd.Connection = con;
                cmd.Parameters.Add("@rut", System.Data.SqlDbType.NVarChar, 10).Value = c.RutCliente;
                cmd.Parameters.Add("@nombres", System.Data.SqlDbType.NVarChar, 20).Value = c.Nombres;
                cmd.Parameters.Add("@apellidos", System.Data.SqlDbType.NVarChar, 20).Value = c.Apellidos;
                cmd.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.Date).Value = c.FechaNacimiento;
                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.Int, 2).Value = c.sexo.IdSexo;
                cmd.Parameters.Add("@estadoCivil", System.Data.SqlDbType.Int, 2).Value = c.estadoCivil.idEstadoCivil;
                con.Open();
                int x = cmd.ExecuteNonQuery();
                con.Close();
                return x > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método Read
        public Cliente Read(string idCliente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ClienteRead";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@rut", System.Data.SqlDbType.NVarChar, 10).Value = idCliente;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Cliente c = null;
                while (dr.Read())
                {
                    c = new Cliente();
                    c.RutCliente = dr[0].ToString();
                    c.Nombres = dr[1].ToString();
                    c.Apellidos = dr[2].ToString();
                    c.FechaNacimiento = DateTime.Parse(dr[3].ToString());
                    c.sexo = new DaoSexo().Read(int.Parse(dr[4].ToString()));
                    c.estadoCivil = new DaoEstadocivil().Read(int.Parse(dr[5].ToString()));
                }
                con.Close();
                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }


        // Método ReadAll
        public List<Cliente> ReadAll()
        {
        try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ClienteReadAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                List<Cliente> lista = new List<Cliente>();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente c = new Cliente();
                    c.RutCliente = dr[0].ToString();
                    c.Nombres = dr[1].ToString();
                    c.Apellidos = dr[2].ToString();
                    c.FechaNacimiento = DateTime.Parse(dr[3].ToString());
                    c.sexo = new DaoSexo().Read(int.Parse(dr[4].ToString()));
                    c.estadoCivil = new DaoEstadocivil().Read(int.Parse(dr[5].ToString()));
                    lista.Add(c);
                }
                con.Close();
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }


        // Método ReadAllBySexo
        public List<Cliente> ReadAllBySexo(int idSexo)
        {
            try
            {
                return ReadAll().Where(c => c.sexo.IdSexo == idSexo).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }


        // Método ReadAllBySexo
        public List<Cliente> ReadAllByEstadoCivil(int idEstadoCivil)
        {
            try
            {
                return ReadAll().Where(es => es.estadoCivil.idEstadoCivil == idEstadoCivil).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
