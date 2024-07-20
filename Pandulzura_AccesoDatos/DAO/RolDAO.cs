using System;
using System.Data;
using System.Data.SqlClient;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_AccesoDatos.DAO
{
    public class RolDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        // Insertar
        public void InsertarRol(Rol nuevoRol)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO roles(nombre_rol) VALUES (@NombreRol)";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@NombreRol", nuevoRol.NombreRol);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar rol: " + ex.Message);
            }
        }

        // Listar
        public DataTable ListarRol()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT roles_id, nombre_rol FROM roles";
                ejecutarSql.Parameters.Clear();
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar roles: " + ex.Message);
            }
        }

        // Eliminar
        public void EliminarRol(int idRol)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM roles WHERE roles_id = @IdRol";
                ejecutarSql.Parameters.Clear();
                
                ejecutarSql.Parameters.AddWithValue("@IdRol", idRol);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }

        // Buscar
        public Rol BuscarRol(int idRol)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "SELECT roles_id, nombre_rol FROM roles WHERE roles_id = @IdRol";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdRol", idRol);
                transaccion = ejecutarSql.ExecuteReader();

                Rol rol = null;
                if (transaccion.Read())
                {
                    rol = new Rol
                    {
                        IdRol = Convert.ToInt32(transaccion["roles_id"]),
                        NombreRol = transaccion["nombre_rol"].ToString()
                    };
                }

                transaccion.Close();
                conexion.CerrarConexion();
                return rol;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar rol: " + ex.Message);
            }
        }
        // Actualizar
        public bool ActualizarRol(Rol rol)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "UPDATE roles SET nombre_rol = @nombreRol WHERE roles_id = @idRol";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@idRol", rol.IdRol);
                ejecutarSql.Parameters.AddWithValue("@nombreRol", rol.NombreRol);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar rol: " + ex.Message);
            }
        }
    }
}
