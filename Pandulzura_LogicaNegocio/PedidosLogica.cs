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

        public DataTable BuscarPedidoPorId(int pedidoId)
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

        public DataTable Mostrar()
        {
            try
            {
                return pedidosDao.Mostrar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar pedidos: " + ex.Message);
            }
        }
    }
}
