using System;
using System.Data;
using System.Data.SqlClient;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_AccesoDatos.DAO
{
    public class PedidosDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;
        DataTable tabla = new DataTable();

        public void InsertarPedido(Pedidos nuevoPedido)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into PEDIDOS(USUARIO_ID, FECHA_PEDIDO, ESTADO_PEDIDO) " +
                                          "values(@UsuarioId, @FechaPedido, @EstadoPedido)";
                ejecutarSql.Parameters.AddWithValue("@UsuarioId", nuevoPedido.UsuarioId);
                ejecutarSql.Parameters.AddWithValue("@FechaPedido", nuevoPedido.FechaPedido);
                ejecutarSql.Parameters.AddWithValue("@EstadoPedido", nuevoPedido.EstadoPedido);
                ejecutarSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar pedido: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public DataTable ListarPedidos()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "Select * from PEDIDOS";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar pedidos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public Pedidos BuscarPedidoPorId(int idPedido)
        {
            Pedidos pedido = null;
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT pedido_id, usuario_id, fecha_pedido, estado_pedido FROM pedidos WHERE pedido_id = @IdPedido";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@IdPedido", idPedido);

                transaccion = ejecutarSql.ExecuteReader();

                if (transaccion.Read())
                {
                    pedido = new Pedidos
                    {
                        PedidoId = Convert.ToInt32(transaccion["pedido_id"]),
                        UsuarioId = Convert.ToInt32(transaccion["usuario_id"]),
                        FechaPedido = Convert.ToDateTime(transaccion["fecha_pedido"]),
                        EstadoPedido = (Pedidos.Estado)Enum.Parse(typeof(Pedidos.Estado), transaccion["estado_pedido"].ToString())
                    };
                }
                transaccion.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar pedido: " + ex.Message);
            }
            return pedido;
        }

        public void EliminarPedido(int idPedido)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM usuarios WHERE PEDIDO_ID = @PedidoId";
                ejecutarSql.Parameters.Clear();
                ejecutarSql.Parameters.AddWithValue("@PedidoId", idPedido);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar pedido: " + ex.Message);
            }
        }
    }
}