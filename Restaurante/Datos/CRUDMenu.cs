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
    public class CRUDMenu : CRUDInsumos
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
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDMenu,IDGrupo,Nombre,Precio from Menu", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataSet ListarMasterInsumo()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDMasterInsumos,MasterInsumos.IDInsumos,IDMenu,Cantidad,Descripcion from MasterInsumos "+
                                                        "INNER JOIN Insumos on Insumos.IDInsumos = MasterInsumos.IDInsumos", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataSet ListarMasterInsumoByIDmenu(string IDMenu)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MasterInsumos.IDMasterInsumos,MasterInsumos.IDInsumos,MasterInsumos.IDMenu,MasterInsumos.Cantidad,Insumos.Descripcion " +
                                                        "from MasterInsumos INNER JOIN Insumos on Insumos.IDInsumos = MasterInsumos.IDInsumos "+
                                                        "INNER JOIN Menu on Menu.IDMenu = MasterInsumos.IDMenu " +
                                                        "WHERE MasterInsumos.IDMenu ='"+IDMenu+"'", cn);
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
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Menu WHERE IDGrupo = '" + IDGrupos + "'", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public int InsertarTemporalMasterInsumos(MasterInsumos MasterInsumos) {
            try
            {
                //DETERMINA SI LA CONEXION ESTA ABIERTA
                if (cn.State == ConnectionState.Open) {
                    cn.Close();
                }
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [MasterInsumos] (IDInsumos,Cantidad,IDMenu) VALUES (@IDInsumos,@Cantidad,@IDMenu)";
                cmd.Parameters.AddWithValue("@IDInsumos", MasterInsumos.IDInsumos);
                cmd.Parameters.AddWithValue("@Cantidad", MasterInsumos.Cantidad);
                cmd.Parameters.AddWithValue("@IDMenu", MasterInsumos.IDMenu);

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

        public void InsertarMasterInsumos(string IDMenu, MasterInsumos MasterInsumos)
        {
            //en este metodo se guarda con el IDMenu
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE MasterInsumos SET IDMenu=@IDMenu WHERE IDMenu= '" + MasterInsumos.IDMenu + "'";
                cmd.Parameters.AddWithValue("@IDMenu", IDMenu);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (SqlCeException ex)
            {
            }
        }

        public void EliminarMasterInsumos(string IDMasterInsumos)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM MasterInsumos WHERE IDMasterInsumos= '" + IDMasterInsumos + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void EliminarMasterInsumosNotSave()
        {
            try
            {
                //ESTE METODO BORRARA TODOS LOS INSUMOS QUE NO SE HAN GUARDADO, ESTE METODO SERA LLAMADO CUANDO SE DE CLICK EN ATRAS
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM MasterInsumos WHERE IDMenu= '" + 0 + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable BuscarMasterInsumo(string IDMasterInsumos)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from MasterInsumos WHERE IDMasterInsumos = '" + IDMasterInsumos + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
    }
}
