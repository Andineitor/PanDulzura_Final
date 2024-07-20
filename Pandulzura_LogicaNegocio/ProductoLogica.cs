using Pandulzura_AccesoDatos.DAO;
using Pandulzura_AccesoDatos.Entidades;
using System.Data;
using System;

public class ProductoLogica
{
    private ProductoDAO productoDAO = new ProductoDAO();

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

    public Producto BuscarProducto(int idProd)
    {
        try
        {
            return productoDAO.BuscarProducto(idProd);
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message);
        }
    }

    public bool ActualizarProducto(Producto producto)
    {
        try
        {
            productoDAO.ActualizarProducto(producto);
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message);
        }
    }

    public bool EliminarProducto(int idProd)
    {
        try
        {
            productoDAO.EliminarProducto(idProd);
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message);
        }
    }
}
