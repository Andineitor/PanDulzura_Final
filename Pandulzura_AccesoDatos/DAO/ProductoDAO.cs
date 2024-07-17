using Pandulzura_AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.DAO
{
    public class ProductoDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        //crud
        public void InsertarProducto(Producto nuevoProducto)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into productos( producto_id, nombre_product, descripcion_product, precio_product, disponibilidad_product)" + "values('" + nuevoProducto.IdProd + "','" + nuevoProducto.NombreProd + "','" + nuevoProducto.DescripcionProd + "','" + nuevoProducto.PrecioProd + "','" + nuevoProducto.DisponibilidadProd + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }

        //lista
        public DataTable ListarProducto()
        {
            DataTable dt = new DataTable();
            try
            {
                //conectar a la bd
                ejecutarSql.Connection = conexion.AbrirConexion();

                //sacar la inf
                ejecutarSql.CommandText = "Select producto_id, categoria_id, nombre_product, descripcion_product, precio_product, disponibilidad_product from productos";
                transaccion = ejecutarSql.ExecuteReader();

                // almacenar resultado de la query
                dt.Load(transaccion);
                conexion.CerrarConexion();

                //retornar query
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message);
            }
        }
    }
}
