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
    public class FacturaLogica
    {
        private FacturaDao facDao = new FacturaDao();



        public bool InsertarFac(Factura nuevafact)
        {
            try
            {
                facDao.InsertarFact(nuevafact);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

        }

        public DataTable ListarFact()
        {
            try
            {
                return facDao.ListarFact();


            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
