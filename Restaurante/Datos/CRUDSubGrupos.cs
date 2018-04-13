using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class CRUDSubGrupos : CRUDGrupos
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlConnection cn;
        public string connectionString = "";

        public CRUDSubGrupos()
        {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlConnection(connectionString);
        }
        public int InsertarSubGrupo(SubGrupos Grupos)
        {
            try
            {

                //SqlConnection con = new SqlConnection(conexion.connectionString);

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "insert into SubGrupos(Descripcion)values (@Descripcion)";
                cmd.Parameters.AddWithValue("@Descripcion", Grupos.Descripcion);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cn.Close();
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }
        public DataTable UltimoIDSubGrupo()
        {

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(IDSubGrupo) as IDSubGrupo from SubGrupos", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarSubGrupo(SubGrupos SubGrupo)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE SubGrupos SET Descripcion=@Descripcion WHERE IDSubGrupo= '" + SubGrupo.IDSubGrupo + "'";
                cmd.Parameters.AddWithValue("@Descripcion", SubGrupo.Descripcion);

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
        public void EliminarSubGrupo(string IDSubGrupos)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM SubGrupos WHERE IDSubGrupo= '" + IDSubGrupos + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarSubGrupo()
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select IDSubGrupo,Descripcion from SubGrupos", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarSubGrupo(string IDSubGrupo)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from SubGrupos WHERE IDSubGrupo = '" + IDSubGrupo + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable SubGruposComboBox()
        {
            cn.Open();
            SqlCommand sc = new SqlCommand("select IDSubGrupo,Descripcion from SubGrupos", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDSubGrupo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public void InsertarSubGrupoMaster(string IDGrupo, string IDSubGrupo)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "insert into MasterGrupoSubGrupo(IDGrupo,IDSubGrupos)values (@IDGrupo,@IDSubGrupos)";
            cmd.Parameters.AddWithValue("@IDSubGrupos", IDSubGrupo);
            cmd.Parameters.AddWithValue("@IDGrupo", IDGrupo);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void ActualizarSubGrupoMaster(string IDGrupo, string IDSubGrupo) {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE MasterGrupoSubGrupo SET IDGrupo=@IDGrupo,IDSubGrupos=@IDSubGrupos WHERE IDSubGrupos= '" + IDSubGrupo + "'";
            cmd.Parameters.AddWithValue("@IDSubGrupo", IDSubGrupo);
            cmd.Parameters.AddWithValue("@IDGrupo", IDGrupo);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void EliminarSubGrupoMaster(string IDSubGrupos)
        {
            SqlConnection con = new SqlConnection(conexion.connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM MasterGrupoSubGrupo WHERE IDSubGrupos= '" + IDSubGrupos + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
