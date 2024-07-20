using System;
using System.Data;
using System.Data.SqlClient;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_AccesoDatos.DAO
{
    public class ProductoDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        // Insertar
        public void InsertarProducto(Producto nuevoProducto)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO productos (nombre_product, descripcion_product, precio_product, disponibilidad_product) " +
                                          "VALUES (@NombreProd, @DescripcionProd, @PrecioProd, @DisponibilidadProd)";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@NombreProd", nuevoProducto.NombreProd);
                ejecutarSql.Parameters.AddWithValue("@DescripcionProd", nuevoProducto.DescripcionProd);
                ejecutarSql.Parameters.AddWithValue("@PrecioProd", nuevoProducto.PrecioProd);
                ejecutarSql.Parameters.AddWithValue("@DisponibilidadProd", nuevoProducto.DisponibilidadProd);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }

        // Listar
        // Listar
        public DataTable ListarProducto()
        {
            DataTable dt = new DataTable();
            try
            {
                // Abrir la conexión
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT producto_id, nombre_product, descripcion_product, precio_product, disponibilidad_product FROM productos";
                ejecutarSql.Parameters.Clear();

                // Ejecutar el comando y cargar los resultados en un DataTable
                using (transaccion = ejecutarSql.ExecuteReader())
                {
                    dt.Load(transaccion);
                }

                // Cerrar la conexión
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message);
            }
        }


        // Buscar
        public Producto BuscarProducto(int idProd)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "SELECT producto_id, nombre_product, descripcion_product, precio_product, disponibilidad_product FROM productos WHERE producto_id = @IdProd";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdProd", idProd);
                transaccion = ejecutarSql.ExecuteReader();

                Producto producto = null;
                if (transaccion.Read())
                {
                    producto = new Producto
                    {
                        IdProd = Convert.ToInt32(transaccion["producto_id"]),
                        NombreProd = transaccion["nombre_product"].ToString(),
                        DescripcionProd = transaccion["descripcion_product"].ToString(),
                        PrecioProd = Convert.ToDouble(transaccion["precio_product"]),
                        DisponibilidadProd = transaccion["disponibilidad_product"].ToString()
                    };
                }

                transaccion.Close();
                conexion.CerrarConexion();
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar producto: " + ex.Message);
            }
        }

        // Actualizar
        public bool ActualizarProducto(Producto producto)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "UPDATE productos SET nombre_product = @NombreProd, descripcion_product = @DescripcionProd, " +
                                          "precio_product = @PrecioProd, disponibilidad_product = @DisponibilidadProd WHERE producto_id = @IdProd";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdProd", producto.IdProd);
                ejecutarSql.Parameters.AddWithValue("@NombreProd", producto.NombreProd);
                ejecutarSql.Parameters.AddWithValue("@DescripcionProd", producto.DescripcionProd);
                ejecutarSql.Parameters.AddWithValue("@PrecioProd", producto.PrecioProd);
                ejecutarSql.Parameters.AddWithValue("@DisponibilidadProd", producto.DisponibilidadProd);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        // Eliminar
        public void EliminarProducto(int idProd)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM productos WHERE producto_id = @IdProd";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdProd", idProd);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }
    }
}
