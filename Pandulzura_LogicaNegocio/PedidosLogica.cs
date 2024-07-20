using Pandulzura_AccesoDatos.DAO;
using Pandulzura_AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_LogicaNegocio
{
    public class PedidosLogica
    {
        private PedidosDAO pedidosDao;
        public PedidosLogica()
        {
            pedidosDao = new PedidosDAO();
        }
        public bool InsertarPedido(Pedidos nuevoPedido)
        {
            try
            {
                pedidosDao.InsertarPedido(nuevoPedido);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar pedido: " + ex.Message);
            }
        }

        public DataTable ListarPedidos()
        {
            try
            {
                return pedidosDao.ListarPedidos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar pedidos: " + ex.Message);
            }
        }

        public Pedidos BuscarPedidoPorId(int pedidoId)
        {
            try
            {
                return pedidosDao.BuscarPedidoPorId(pedidoId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar pedido: " + ex.Message);
            }
        }

        public bool EliminarPedidos(int pedidoId)
        {
            try
            {
                pedidosDao.EliminarPedido(pedidoId);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar pedido: " + ex.Message);
            }
        }

//        public bool ActualizarPedido(Pedidos pedido)
//        {
//            try
//            {
//                return pedidosDao.ActualizarPedido(pedido);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Error al actualizar pedido: " + ex.Message);
//            }
//        }

    }
}
