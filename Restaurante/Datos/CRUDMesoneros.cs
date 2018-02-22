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
    public class CRUDMesoneros
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDMesoneros() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarMesoneros(Mesoneros Mesoneros)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Mesoneros] (Nombre,Apellido) VALUES (@Nombre,@Apellido)";
                cmd.Parameters.AddWithValue("@Nombre", Mesoneros.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Mesoneros.Apellido);

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
        public DataTable UltimoIDMesoneros()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDMesoneros) as IDMesoneros from Mesoneros", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarMesoneros(Mesoneros Mesoneros)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Mesoneros SET Nombre=@Nombre,Apellido=@Apellido WHERE IDMesoneros= '" + Mesoneros.IDMesoneros + "'";
                cmd.Parameters.AddWithValue("@Nombre", Mesoneros.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Mesoneros.Apellido);

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
        public void EliminarMesoneros(string IDMesoneros)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Mesoneros WHERE IDMesoneros= '" + IDMesoneros + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarMesoneros()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDMesoneros,Nombre,Apellido from Mesoneros", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarMesoneros(string IDMesoneros)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Mesoneros WHERE IDMesoneros = '" + IDMesoneros + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
    }
}
