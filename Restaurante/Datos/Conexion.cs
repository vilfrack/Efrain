using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Configuration;

namespace Datos
{
    class Conexion
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public SqlDataAdapter adapt;
        // public String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\juan\\documents\\visual studio 2015\\Projects\\WFPizzeria\\WFPizzeria\\Base de datos\\BDPizza.mdf'; Integrated Security=True";
        public String connectionString = "";
        public Conexion()
        {
            try
            {
                ConnectionStringSettings cns = ConfigurationManager.ConnectionStrings["BD"];
                connectionString = cns.ConnectionString;
                cn = new SqlConnection(connectionString);
                cn.Open();
            }
            catch (Exception ex)
            {

            }

        }
        public void CerrarConexion()
        {
            cn.Close();
        }
    }
}
