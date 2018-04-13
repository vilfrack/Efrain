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
    public class CRUDGrupos
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlConnection cn;
        public string connectionString = "";

        public CRUDGrupos() {
           cns = ConfigurationManager.ConnectionStrings["BD"];
           connectionString = cns.ConnectionString;
           cn = new SqlConnection(connectionString);
        }
        public int InsertarGrupo(Grupos Grupos)
        {
            try
            {

                //SqlConnection con = new SqlConnection(conexion.connectionString);

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "insert into Grupos(Descripcion)values (@Descripcion)";
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
        public DataTable UltimoIDGrupo()
        {

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(IDGrupo) as IDGrupo from Grupos", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarGrupo(Grupos Grupos)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Grupos SET Descripcion=@Descripcion WHERE IDGrupo= '" + Grupos.IDGrupo + "'";
                cmd.Parameters.AddWithValue("@Descripcion", Grupos.Descripcion);

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
        public void EliminarGrupo(string IDGrupos)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Grupos WHERE IDGrupo= '" + IDGrupos + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarGrupo()
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select IDGrupo,Descripcion from Grupos", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarGrupo(string IDGrupos)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Grupos WHERE IDGrupo = '" + IDGrupos + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable GruposComboBox()
        {
            cn.Open();
            SqlCommand sc = new SqlCommand("select IDGrupo,Descripcion from Grupos", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDGrupo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }
    }
}
