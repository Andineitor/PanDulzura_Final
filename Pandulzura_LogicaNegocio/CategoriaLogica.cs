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
    public class CategoriaLogica
    {
        private CategoriaDAO categoriaDAO = new CategoriaDAO();

        public bool InsertarCategoria(Categoria nuevaCategoria)
        {
            try
            {
                categoriaDAO.InsertarCategoria(nuevaCategoria);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public DataTable ListarCategoria()
        {
            try
            {
                return categoriaDAO.ListarCategoria();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public Categoria BuscarCategoriaPorId(int categoriaId)
        {
            try
            {
                return categoriaDAO.BuscarCategoriaPorId(categoriaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar categoría: " + ex.Message);
            }
        }

        public bool EliminarCategoria(int categoriaId)
        {
            try
            {
                categoriaDAO.EliminarCategoria(categoriaId);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar categoría: " + ex.Message);
            }
        }

    }
}
