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
    public class DetallePedidoDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        //crud
        public void InsertarDetalle(DetallePedido nuevoDetalle)
        {
            // Asegúrate de que conexion es una instancia válida de tu clase de conexión.
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO [dbo].[DETALLE_PEDIDOS] " +
                                          "([PEDIDO_ID], [FACTURA_ID], [PRODUCTO_ID], [CANTIDAD_PEDIDO]) " +
                                          "VALUES (1, 1, @ProductoId, @CantidadPedido)";

                // Asignar parámetros
                ejecutarSql.Parameters.Clear(); // Limpia parámetros anteriores si los hubiera
                ejecutarSql.Parameters.AddWithValue("@ProductoId", nuevoDetalle.ProductoId);
                ejecutarSql.Parameters.AddWithValue("@CantidadPedido", nuevoDetalle.CantidadPedido);

                ejecutarSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar detalles de pedido: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(); // Asegúrate de cerrar la conexión
            }
        }




        //lista
        public DataTable ListarDetalle()
        {
            DataTable dt = new DataTable();
            try
            {
                //conectar a la bd
                ejecutarSql.Connection = conexion.AbrirConexion();

                //sacar la inf
                ejecutarSql.CommandText = "Select * from detalle_pedidos";
                transaccion = ejecutarSql.ExecuteReader();

                // almacenar resultado de la query
                dt.Load(transaccion);
                conexion.CerrarConexion();

                //retornar query
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar detalles de pedido: " + ex.Message);
            }
        }

        public bool EliminarDetalle(string id)
        {
            SqlCommand ejecutarSql = new SqlCommand();
            ejecutarSql.Connection = conexion.AbrirConexion();

            try
            {
                ejecutarSql.CommandText = "DELETE FROM DETALLE_PEDIDOS WHERE DETALLE_PEDIDO_ID = @Id;";
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
