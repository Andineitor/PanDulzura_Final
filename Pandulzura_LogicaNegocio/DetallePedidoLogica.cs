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
    public class DetallePedidoLogica
    {
        private DetallePedidoDAO detalleDAO = new DetallePedidoDAO();

        public bool InsertarDetalle(DetallePedido nuevoDetalle)
        {
            try
            {
                detalleDAO.InsertarDetalle(nuevoDetalle);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public DataTable ListarDetalle()
        {
            try
            {
                return detalleDAO.ListarDetalle();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
