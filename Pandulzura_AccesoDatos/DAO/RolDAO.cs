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
    public class RolDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        //crud
        public void InsertarRol(Rol nuevoRol)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into roles(roles_id, nombre_rol)" + "values('" + nuevoRol.IdRol + "','" + nuevoRol.NombreRol + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar rol: " + ex.Message);
            }
        }

        //lista
        public DataTable ListarRol() {
            DataTable dt = new DataTable();
            try
            {
                //conectar a la bd
                ejecutarSql.Connection = conexion.AbrirConexion();

                //sacar la inf
                ejecutarSql.CommandText = "Select roles_id, nombre_rol from roles";
                transaccion = ejecutarSql.ExecuteReader();

                // almacenar resultado de la query
                dt.Load(transaccion);
                conexion.CerrarConexion();

                //retornar query
                return dt;
            }
            catch (Exception ex){
                    throw new Exception("Error al listar roles: " + ex.Message);
                }
            }
        }
    
}
