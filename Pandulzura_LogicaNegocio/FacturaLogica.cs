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

        public bool ActualizarFactura(Factura fact)
        {
            try
            {
                facDao.ActualizarFactura(fact);
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error: " + ex.Message);
            }

        }

        public Factura ObtenerFacturaPorId(string id)
        {
            try
            {
                return facDao.ObtenerFacturaPorId(id);


            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public bool EliminarFactura(string id)
        {
            try
            {
                facDao.EliminarFactura(id);
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error: " + ex.Message);
            }
        }





    }
}
