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

        public void ActualizarFactura(Factura fact)
        {
            SqlCommand ejecutarSql = new SqlCommand();
            ejecutarSql.Connection = conexion.AbrirConexion();

            try
            {
                ejecutarSql.CommandText = "UPDATE factura SET TOTAL_FINAL = @TotalFinal, FECHA_FACT = @FechaFact WHERE FACTURA_ID = @Id;";
                ejecutarSql.Parameters.AddWithValue("@TotalFinal", fact.TOTAL_FINAL);
                ejecutarSql.Parameters.AddWithValue("@FechaFact", fact.FECHA_FACT);
                ejecutarSql.Parameters.AddWithValue("@Id", fact.FACTURAID);

                ejecutarSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        public Factura ObtenerFacturaPorId(string id)
        {
            Factura factura = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();

            try
            {
                comando.CommandText = "SELECT * FROM factura WHERE FACTURA_ID = @Id;";
                comando.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        factura = new Factura
                        {
                            FACTURAID = reader.GetInt32(0).ToString(),
                            TOTAL_FINAL = reader.GetDecimal(1).ToString(),
                            FECHA_FACT = reader.GetDateTime(2)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la factura: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return factura;
        }


        public bool EliminarFactura(string id)
        {
            SqlCommand ejecutarSql = new SqlCommand();
            ejecutarSql.Connection = conexion.AbrirConexion();

            try
            {
                ejecutarSql.CommandText = "DELETE FROM factura WHERE FACTURA_ID = @Id;";
                ejecutarSql.Parameters.AddWithValue("@Id", int.Parse(id)); // Convertir a int si es necesario

                int filasAfectadas = ejecutarSql.ExecuteNonQuery();
                return filasAfectadas > 0; // Retorna true si se eliminó al menos una fila
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }



    }

}
