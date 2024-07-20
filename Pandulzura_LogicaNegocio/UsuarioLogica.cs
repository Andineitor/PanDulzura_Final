using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pandulzura_AccesoDatos.DAO;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_LogicaNegocio
{
    public class UsuarioLogica
    {
        public UsuarioDAO usuarioDao = new UsuarioDAO();

        public bool InsertarUsuario(Usuario nuevoUser)
        {
            try
            {
                usuarioDao.InsertUser(nuevoUser);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

        }

        public DataTable ListarUser()
        {
            try
            {
                return usuarioDao.ListarUser();


            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public Usuario BuscarUser(int idUser)
        {
            try
            {
                return usuarioDao.BuscarUser(idUser);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public bool EliminarUser(int idUser)
        {
            try
            {
                usuarioDao.EliminarUser(idUser);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                usuarioDao.ActualizarUser(usuario);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

    }
}