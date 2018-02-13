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

    public class CRUDUnidadMedida
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDUnidadMedida() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarUnidadMedida(UnidadMedida UnidadMedida)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "insert into UnidadMedida(Descripcion)values (@Descripcion)";
                cmd.Parameters.AddWithValue("@Descripcion", UnidadMedida.Descripcion);

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
        public DataTable UltimoIDUnidad()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDUnidad) as IDUnidad from UnidadMedida", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarUnidadMedida(UnidadMedida UnidadMedida)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE UnidadMedida SET Descripcion=@Descripcion WHERE IDUnidad= '" + UnidadMedida.IDUnidad + "'";
                cmd.Parameters.AddWithValue("@Descripcion", UnidadMedida.Descripcion);

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
        public void EliminarUnidadMedida(string IDUnidad)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM UnidadMedida WHERE IDUnidad= '" + IDUnidad + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarUnidadMedida()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDUnidad,Descripcion from UnidadMedida", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarUnidadMedida(string IDUnidad)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from UnidadMedida WHERE IDUnidad = '" + IDUnidad + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable UnidadMedidaComboBox()
        {
            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("select IDUnidad,Descripcion from UnidadMedida", cn);
            SqlCeDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDUnidad", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }
    }
}
