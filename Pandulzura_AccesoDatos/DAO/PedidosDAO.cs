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

        public DataTable BuscarPedidoPorId(int pedidoId)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "Select * from PEDIDOS where PEDIDO_ID = @PedidoId";
                ejecutarSql.Parameters.AddWithValue("@PedidoId", pedidoId);
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar pedido: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public DataTable Mostrar()
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "MostrarPedidos";
                ejecutarSql.CommandType = CommandType.StoredProcedure;
                transaccion = ejecutarSql.ExecuteReader();
                tabla.Load(transaccion);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar pedidos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}