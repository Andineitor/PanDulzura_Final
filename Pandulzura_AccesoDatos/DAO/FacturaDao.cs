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
                //FACTURAID
                //TOTAL_FINAL
                //FECHA_FACT
                ejecutarSql.CommandText = "insert into factura(FACTURAID, TOTAL_FINAL, FECHA_FACT)" + 
                    "values('" + fact.FACTURAID + "','" + fact.TOTAL_FINAL + "','" + fact.TOTAL_FINAL + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar: " + ex.Message);
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

