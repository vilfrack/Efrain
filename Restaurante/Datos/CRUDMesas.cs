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
    public class CRUDMesas
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDMesas()
        {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarMesas(Mesas Mesas)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "insert into Mesas(NumeroMesa,CantidadPersona)values (@NumeroMesa,@CantidadPersona)";
                cmd.Parameters.AddWithValue("@NumeroMesa", Mesas.NumeroMesa);
                cmd.Parameters.AddWithValue("@CantidadPersona", Mesas.CantidadPersona);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cn.Close();
                return 1;
            }
            catch (SqlCeException ex)
            {
                return 0;
            }

        }
        public DataTable UltimoIDMesas()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDMesas) as IDMesas from Mesas", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarMesas(Mesas mesas)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Mesas SET NumeroMesa=@NumeroMesa,CantidadPersona=@CantidadPersona WHERE IDMesas= '" + mesas.IDMesas + "'";
                cmd.Parameters.AddWithValue("@NumeroMesa", mesas.NumeroMesa);
                cmd.Parameters.AddWithValue("@CantidadPersona", mesas.CantidadPersona);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public void EliminarMesas(string IDMesas)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Mesas WHERE IDMesas= '" + IDMesas + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarMesas()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDMesas,NumeroMesa, CantidadPersona from Mesas", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarMesas(string IDMesas)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Mesas WHERE IDMesas = '" + IDMesas + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
    }
}
