﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public SqlConnection cn;
        // public String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\juan\\documents\\visual studio 2015\\Projects\\WFPizzeria\\WFPizzeria\\Base de datos\\BDPizza.mdf'; Integrated Security=True";
        public String connectionString = "";
        public Conexion()
        {
            try
            {
                ConnectionStringSettings cns = ConfigurationManager.ConnectionStrings["BD"];
                connectionString = cns.ConnectionString;
                cn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void CerrarConexion()
        {
            cn.Close();
        }
        public void ValidateConexion() {

        }
    }
}
