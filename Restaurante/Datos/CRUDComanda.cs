using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CRUDComanda
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDComanda() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }

        public List<Mesas> DatosMesas() {
            List<Mesas> ListMesas = new List<Mesas>();

            SqlCeCommand command = new SqlCeCommand("SELECT IDMesas,NumeroMesa,CantidadPersona FROM Mesas;", cn);
            cn.Open();
            SqlCeDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListMesas.Add(new Mesas {
                    IDMesas = reader.GetInt32(0),
                    NumeroMesa =Convert.ToInt32(reader.GetString(1)),
                    CantidadPersona = reader.GetInt32(2)
                });
            }
            reader.Close();
            cn.Close();
            return ListMesas;
        }
    }
}
