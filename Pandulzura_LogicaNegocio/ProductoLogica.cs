using Pandulzura_AccesoDatos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pandulzura_AccesoDatos.Entidades;
using System.Data;

namespace Pandulzura_LogicaNegocio
{
    public class ProductoLogica
    {
        private ProductoDAO productoDAO = new ProductoDAO ();

        public bool InsertarProducto(Producto nuevoProducto)
        {
            try
            {
                productoDAO.InsertarProducto(nuevoProducto);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public DataTable ListarProducto() 
        {
            try 
            {
                return productoDAO.ListarProducto();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
