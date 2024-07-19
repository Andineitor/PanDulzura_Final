using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_AccesoDatos.DAO
{
    public class FacturaDao
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        //crud
        public void InsertarFact(Factura fact)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();

            try
            {
                ejecutarSql.CommandText = "INSERT INTO factura (TOTAL_FINAL, FECHA_FACT) " +
                                          "VALUES (@TotalFinal, @FechaFact)";
                ejecutarSql.Parameters.AddWithValue("@TotalFinal", fact.TOTAL_FINAL);
                ejecutarSql.Parameters.AddWithValue("@FechaFact", fact.FECHA_FACT);
                ejecutarSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        //lista
        public DataTable ListarFact()
        {
            DataTable dt = new DataTable();
            try
            {
                //conectar a la bd
                ejecutarSql.Connection = conexion.AbrirConexion();

                //sacar la inf
                ejecutarSql.CommandText = "Select * from factura";
                transaccion = ejecutarSql.ExecuteReader();

                // almacenar resultado de la query
                dt.Load(transaccion);
                conexion.CerrarConexion();

                //retornar query
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar: " + ex.Message);
            }
        }
    }
}

