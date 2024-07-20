using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pandulzura_AccesoDatos.DAO;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_LogicaNegocio
{
    public class RolLogica
    {
        private RolDAO rolDao = new RolDAO();

        public bool InsertarRol(Rol nuevorol)
        {
            try
            {
                rolDao.InsertarRol(nuevorol);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

        }

        public DataTable ListarRol()
        {
            try
            {
               return rolDao.ListarRol();
              

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        // Eliminar
        public bool EliminarRol(int idRol)
        {
            try
            {
                rolDao.EliminarRol(idRol);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }



        // Buscar
        public Rol BuscarRol(int idRol)
        {
            try
            {
                return rolDao.BuscarRol(idRol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        //Update
        public bool ActualizarRol(Rol rol)
        {
            try
            {
                return rolDao.ActualizarRol(rol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}

