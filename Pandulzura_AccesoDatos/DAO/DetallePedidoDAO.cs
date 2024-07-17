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
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into detalle_pedidos(detalle_pedido_id, cantidad_pedido)" + "values('" + nuevoDetalle.IdDetalle + "','" + nuevoDetalle.CantidadPedido + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar detalles de pedido: " + ex.Message);
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
                ejecutarSql.CommandText = "Select detalle_pedido_id, cantidad_pedido from detalle_pedidos";
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
    }
}
