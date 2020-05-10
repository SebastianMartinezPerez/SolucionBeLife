using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
using System.Data.SqlClient;

namespace Controlador
{
    public class DaoContrato
    {
        private SqlConnection con;
        public DaoContrato()
        {
            con = new Conexion().getConexion();
        }

        // Método create
        public bool Create(Contrato c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ContratoCreate";
                cmd.Connection = con;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar, 14).Value = c.Numero;
                cmd.Parameters.Add("@FechaCreacion", System.Data.SqlDbType.DateTime).Value = c.FechaCreacion;
                cmd.Parameters.Add("@rutCliente", System.Data.SqlDbType.NVarChar, 10).Value = c.RutCliente;
                cmd.Parameters.Add("@codigoPlan", System.Data.SqlDbType.NVarChar, 5).Value = c.planContrato.IdPlan;
                cmd.Parameters.Add("@fechaIniVigencia", System.Data.SqlDbType.DateTime).Value = c.FechaInicioVigencia;
                cmd.Parameters.Add("@fechaFinVigencia", System.Data.SqlDbType.DateTime).Value = c.FechaFinVigencia;
                cmd.Parameters.Add("@vigente", System.Data.SqlDbType.Bit, 1).Value = c.Vigente;
                cmd.Parameters.Add("@declaracionSalud", System.Data.SqlDbType.Bit, 1).Value = c.DeclaracionSalud;
                cmd.Parameters.Add("@primaAnual", System.Data.SqlDbType.Float).Value = c.PrimaAnual;
                cmd.Parameters.Add("@primaMensual", System.Data.SqlDbType.Float).Value = c.PrimaMensual;
                cmd.Parameters.Add("@observaciones", System.Data.SqlDbType.NVarChar,9999999).Value = c.Observaciones;
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

        // Método Delete 
        public bool Delete(Contrato c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ContratoDelete";
                cmd.Connection = con;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar, 10).Value = c.Numero;
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

        // Método update 
        public bool Update(Contrato c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ContratoUpdate";
                cmd.Connection = con;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar, 14).Value = c.Numero;
                cmd.Parameters.Add("@FechaCreacion", System.Data.SqlDbType.DateTime).Value = c.FechaCreacion;
                cmd.Parameters.Add("@rutCliente", System.Data.SqlDbType.NVarChar, 10).Value = c.RutCliente;
                cmd.Parameters.Add("@codigoPlan", System.Data.SqlDbType.NVarChar, 5).Value = c.planContrato.IdPlan;
                cmd.Parameters.Add("@fechaIniVigencia", System.Data.SqlDbType.DateTime).Value = c.FechaInicioVigencia;
                cmd.Parameters.Add("@fechaFinVigencia", System.Data.SqlDbType.DateTime).Value = c.FechaFinVigencia;
                cmd.Parameters.Add("@vigente", System.Data.SqlDbType.Bit, 1).Value = c.Vigente;
                cmd.Parameters.Add("@declaracionSalud", System.Data.SqlDbType.Bit, 1).Value = c.DeclaracionSalud;
                cmd.Parameters.Add("@primaAnual", System.Data.SqlDbType.Float).Value = c.PrimaAnual;
                cmd.Parameters.Add("@primaMensual", System.Data.SqlDbType.Float).Value = c.PrimaMensual;
                cmd.Parameters.Add("@observaciones", System.Data.SqlDbType.NVarChar, 9999999).Value = c.Observaciones;
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
        public Contrato Read(string idContrato)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ContratoRead";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar, 14).Value = idContrato;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Contrato c = null;
                while (dr.Read())
                {
                    c = new Contrato();
                    c.Numero = dr[0].ToString();
                    c.FechaCreacion = DateTime.Parse(dr[1].ToString());
                    c.clienteContrato = new DaoCliente().Read(dr[2].ToString());
                    c.planContrato = new DaoPlan().Read(dr[3].ToString());
                    c.FechaInicioVigencia = DateTime.Parse(dr[4].ToString());
                    c.FechaFinVigencia = DateTime.Parse(dr[5].ToString());
                    c.Vigente = bool.Parse(dr[6].ToString());
                    c.DeclaracionSalud = bool.Parse(dr[7].ToString());
                    c.PrimaAnual = float.Parse(dr[8].ToString());
                    c.PrimaMensual = float.Parse(dr[9].ToString());
                    c.Observaciones = dr[10].ToString();
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
        public List<Contrato> ReadAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ContratoReadAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                List<Contrato> lista = new List<Contrato>();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contrato c = new Contrato();
                    c.Numero = dr[0].ToString();
                    c.FechaCreacion = DateTime.Parse(dr[1].ToString());
                    c.clienteContrato = new DaoCliente().Read(dr[2].ToString());
                    c.planContrato = new DaoPlan().Read(dr[3].ToString());
                    c.FechaInicioVigencia = DateTime.Parse(dr[4].ToString());
                    c.FechaFinVigencia = DateTime.Parse(dr[5].ToString());
                    c.Vigente = bool.Parse(dr[6].ToString());
                    c.DeclaracionSalud = bool.Parse(dr[7].ToString());
                    c.PrimaAnual = float.Parse(dr[8].ToString());
                    c.PrimaMensual = float.Parse(dr[9].ToString());
                    c.Observaciones = dr[10].ToString();
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

        // Método ReadAllByNumero
        public List<Contrato> ReadAllByNumero(string numero)
        {
            try
            {
                return ReadAll().Where(c => c.Numero == numero).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Método ReadAllByPoliza
        public List<Contrato> ReadAllByPoliza(string poliza)
        {
            try
            {
                return ReadAll().Where(c => c.planContrato.PolizaActual == poliza).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Método ReadAllByNumero
        public List<Contrato> ReadAllByRut(string rut)
        {
            try
            {
                return ReadAll().Where(c => c.clienteContrato.RutCliente == rut).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Método Cantidad de contratos asociados con un rut específico
        public int CantContratos(string rut)
        {
            int x = ReadAll().Where(c => c.clienteContrato.RutCliente.Equals(rut)).Count();
            return x;
        }


    }
}
