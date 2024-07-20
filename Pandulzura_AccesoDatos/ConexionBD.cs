using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos
{
    internal class ConexionBD
    {
        private SqlConnection connection = new SqlConnection("server=SALMA-112516;database=PanDulzuraV2;Integrated Security=True");
    
        public SqlConnection AbrirConexion()
        {
            if(connection.State== ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public SqlConnection CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }

    
}
