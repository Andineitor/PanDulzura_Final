using Pandulzura_AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.DAO
{
    public class CategoriaDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        //crud
        public void InsertarCategoria(Categoria nuevaCategoria)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into categoria(categoria_id, nombre_categoria)" + "values('" + nuevaCategoria.IdCategoria + "','" + nuevaCategoria.NombreCategoria + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar categoria: " + ex.Message);
            }
        }

        //lista
        public DataTable ListarCategoria()
        {
            DataTable dt = new DataTable();
            try
            {
                //conectar a la bd
                ejecutarSql.Connection = conexion.AbrirConexion();

                //sacar la inf
                ejecutarSql.CommandText = "Select categoria_id, nombre_categoria from categoria";
                transaccion = ejecutarSql.ExecuteReader();

                // almacenar resultado de la query
                dt.Load(transaccion);
                conexion.CerrarConexion();

                //retornar query
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar categorias: " + ex.Message);
            }
        }

        //Buascar
        public Categoria BuscarCategoriaPorId(int idCategoria)
        {
            Categoria categoria = null;
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT categoria_id, nombre_categoria FROM categoria WHERE categoria_id = @IdCategoria";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdCategoria", idCategoria);

                transaccion = ejecutarSql.ExecuteReader();

                if (transaccion.Read())
                {
                    categoria = new Categoria
                    {
                        CategoriaId = Convert.ToInt32(transaccion["categoria_id"]),
                        NombreCategoria = transaccion["nombre_categoria"].ToString()
                    };
                }
                transaccion.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar categoría: " + ex.Message);
            }
            return categoria;
        }

        //Eliminar
        public void EliminarCategoria(int idCategoria)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM categorias WHERE categoria_id = @CategoriaId";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@CategoriaId", idCategoria);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar categoría: " + ex.Message);
            }
        }

    }
}
