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
    public class CRUDMenu
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDMenu()
        {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarMenu(Menu Menu)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Menu] (IDGrupo,IDMasterInsumos,Nombre,Precio) VALUES (@IDGrupo,@IDMasterInsumos,@Nombre,@Precio)";
                cmd.Parameters.AddWithValue("@IDGrupo", Menu.IDGrupo);
                cmd.Parameters.AddWithValue("@IDMasterInsumos", Menu.IDMasterInsumos);
                cmd.Parameters.AddWithValue("@Nombre", Menu.Nombre);
                cmd.Parameters.AddWithValue("@Precio", Menu.Precio);

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
        public DataTable UltimoIDMenu()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDMenu) as IDMenu from Menu", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarMenu(Menu Menu)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Menu SET IDGrupo=@IDGrupo,IDMasterInsumos=@IDMasterInsumos,Nombre=@Nombre,Precio=@Precio WHERE IDMenu= '" + Menu.IDMenu + "'";
                cmd.Parameters.AddWithValue("@IDGrupo", Menu.IDGrupo);
                cmd.Parameters.AddWithValue("@IDMasterInsumos", Menu.IDMasterInsumos);
                cmd.Parameters.AddWithValue("@Nombre", Menu.Nombre);
                cmd.Parameters.AddWithValue("@Precio", Menu.Precio);

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
        public void EliminarMenu(string IDMenu)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Menu WHERE IDMenu= '" + IDMenu + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarMenu()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDMenu,IDGrupo,IDMasterInsumos,Nombre,Precio from Menu", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarMenu(string IDMenu)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Menu WHERE IDMenu = '" + IDMenu + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataSet BuscarMenuByGrupo(string IDGrupos)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Menu WHERE IDGrupos = '" + IDGrupos + "'", cn);
            sda.Fill(_ds);
            return _ds;
        }


    }
}
