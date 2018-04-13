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
    public class CRUDMesoneros
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlConnection cn;
        public string connectionString = "";

        public CRUDMesoneros() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlConnection(connectionString);
        }
        public int InsertarMesoneros(Mesoneros Mesoneros)
        {
            try
            {

                //SqlConnection con = new SqlConnection(conexion.connectionString);

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Mesoneros] (Nombre,Apellido) VALUES (@Nombre,@Apellido)";
                cmd.Parameters.AddWithValue("@Nombre", Mesoneros.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Mesoneros.Apellido);

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
        public DataTable UltimoIDMesoneros()
        {

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(IDMesoneros) as IDMesoneros from Mesoneros", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarMesoneros(Mesoneros Mesoneros)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
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
                SqlConnection con = new SqlConnection(conexion.connectionString);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
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
            SqlDataAdapter sda = new SqlDataAdapter("select IDMesoneros,Nombre,Apellido from Mesoneros", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarMesoneros(string IDMesoneros)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Mesoneros WHERE IDMesoneros = '" + IDMesoneros + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable MesonerosComboBox()
        {
            cn.Open();
            SqlCommand sc = new SqlCommand("select IDMesoneros, (Nombre +' '+ Apellido) as nombre from Mesoneros", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDMesoneros", typeof(string));
            dt.Columns.Add("nombre", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }
    }
}
