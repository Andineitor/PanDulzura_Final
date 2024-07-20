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
                ejecutarSql.CommandText = "INSERT INTO usuarios(roles_id, nombre_user, cedula_user, mail_user, telefono_user, direccion_user, contrasena_user) " +
                                          "VALUES(@RolesId, @NombreUser, @CedulaUser, @MailUser, @TelefonoUser, @DireccionUser, @ContrasenaUser)";
                ejecutarSql.Parameters.Clear(); // Limpia los parámetros anteriores
                ejecutarSql.Parameters.AddWithValue("@RolesId", nuevoUser.RolesId);
                ejecutarSql.Parameters.AddWithValue("@NombreUser", nuevoUser.NombreUser);
                ejecutarSql.Parameters.AddWithValue("@CedulaUser", nuevoUser.CedulaUser);
                ejecutarSql.Parameters.AddWithValue("@MailUser", nuevoUser.MailUser);
                ejecutarSql.Parameters.AddWithValue("@TelefonoUser", nuevoUser.TelefonoUser);
                ejecutarSql.Parameters.AddWithValue("@DireccionUser", nuevoUser.DireccionUser);
                ejecutarSql.Parameters.AddWithValue("@ContrasenaUser", nuevoUser.ContrasenaUser);

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
                ejecutarSql.Parameters.Clear(); // Limpia los parámetros anteriores
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

        //buscar
        public Usuario BuscarUser(int idUser)
        {
            Usuario usuario = null;
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT usuario_id, roles_id, nombre_user, cedula_user, mail_user, telefono_user, direccion_user, contrasena_user FROM usuarios WHERE usuario_id = @IdUser";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdUser", idUser);

                transaccion = ejecutarSql.ExecuteReader();

                if (transaccion.Read())
                {
                    usuario = new Usuario
                    {
                        IdUser = Convert.ToInt32(transaccion["usuario_id"]),
                        RolesId = Convert.ToInt32(transaccion["roles_id"]),
                        NombreUser = transaccion["nombre_user"].ToString(),
                        CedulaUser = Convert.ToInt64(transaccion["cedula_user"]),
                        MailUser = transaccion["mail_user"].ToString(),
                        TelefonoUser = Convert.ToInt64(transaccion["telefono_user"]),
                        DireccionUser = transaccion["direccion_user"].ToString(),
                        ContrasenaUser = transaccion["contrasena_user"].ToString()
                    };
                }
                transaccion.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar usuario: " + ex.Message);
            }
            return usuario;
        }


        //elimanar
        public void EliminarUser(int idUser)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM usuarios WHERE usuario_id = @IdUser";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdUser", idUser);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }

        // Actualizar
        public void ActualizarUser(Usuario idUser)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE usuarios SET nombre_user = @NombreUser, cedula_user = @CedulaUser, mail_user = @MailUser, telefono_user = @TelefonoUser, direccion_user = @DireccionUser, contrasena_user = @ContrasenaUser WHERE usuario_id = @IdUser";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdUser", idUser.IdUser);
                ejecutarSql.Parameters.AddWithValue("@RolesId", idUser.RolesId);
                ejecutarSql.Parameters.AddWithValue("@NombreUser", idUser.NombreUser);
                ejecutarSql.Parameters.AddWithValue("@CedulaUser", idUser.CedulaUser);
                ejecutarSql.Parameters.AddWithValue("@MailUser", idUser.MailUser);
                ejecutarSql.Parameters.AddWithValue("@TelefonoUser", idUser.TelefonoUser);
                ejecutarSql.Parameters.AddWithValue("@DireccionUser", idUser.DireccionUser);
                ejecutarSql.Parameters.AddWithValue("@ContrasenaUser", idUser.ContrasenaUser);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
        }
    }

}
