using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_AccesoDatos.DAO
{
    public class UsuarioDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        //crud
        public void InsertUser(Usuario nuevoUser)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into usuarios(usuario_id, roles_id, nombre_user, cedula_user, mail_user, telefono_user, direccion_user, contrasena_user)"
                    + "values('" + nuevoUser.IdUser + "','" + nuevoUser.RolesId + "','" + nuevoUser.NombreUser + "','" + nuevoUser.CedulaUser + "','" + nuevoUser.MailUser + "','" + nuevoUser.TelefonoUser + "','" + nuevoUser.DireccionUser + "','" + nuevoUser.ContrasenaUser + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar usurario: " + ex.Message);
            }
        }

        //lista
        public DataTable ListarUser()
        {
            DataTable dt = new DataTable();
            try
            {
                //conectar a la bd
                ejecutarSql.Connection = conexion.AbrirConexion();

                //sacar la inf
                ejecutarSql.CommandText = "Select usuario_id, roles_id, nombre_user, cedula_user, mail_user, telefono_user, direccion_user, contrasena_user from usuarios";
                transaccion = ejecutarSql.ExecuteReader();

                // almacenar resultado de la query
                dt.Load(transaccion);
                conexion.CerrarConexion();

                //retornar query
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar usuarios: " + ex.Message);
            }
        }
    }
}