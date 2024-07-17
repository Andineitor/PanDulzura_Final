using System;

namespace Pandulzura_AccesoDatos
{
    internal class ConexionBDBase
    {

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}