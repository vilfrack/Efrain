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
    public class CRUDTipoDescuento
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDTipoDescuento() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarTipoDescuento(TipoDescuento TipoDescuento)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "insert into TipoDescuento(Descripcion,Descuento,Visible)values (@Descripcion,@Descuento,@Visible)";
                cmd.Parameters.AddWithValue("@Descripcion", TipoDescuento.Descripcion);
                cmd.Parameters.AddWithValue("@Descuento", TipoDescuento.Descuento);
                cmd.Parameters.AddWithValue("@Visible", TipoDescuento.Visible);
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
        public DataTable UltimoIDTipoDescuento()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDTipoDescuento) as IDTipoDescuento from TipoDescuento", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarTipoDescuento(TipoDescuento TipoDescuento)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE TipoDescuento SET Descripcion=@Descripcion,Descuento=@Descuento,Visible=@Visible WHERE IDTipoDescuento= '" + TipoDescuento.IDTipoDescuento + "'";
                cmd.Parameters.AddWithValue("@Descripcion", TipoDescuento.Descripcion);
                cmd.Parameters.AddWithValue("@Descuento", TipoDescuento.Descuento);
                cmd.Parameters.AddWithValue("@Visible", TipoDescuento.Visible);

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
        public void EliminarTipoDescuento(string IDTipoDescuento)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM TipoDescuento WHERE IDTipoDescuento= '" + IDTipoDescuento + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarTipoDescuento()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from TipoDescuento", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarTipoDescuento(string IDTipoDescuento)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from TipoDescuento WHERE IDTipoDescuento = '" + IDTipoDescuento + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable TipoDescuentoComboBox()
        {
            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("select IDTipoDescuento,Descripcion from TipoDescuento", cn);
            SqlCeDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDTipoDescuento", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }

    }
}
