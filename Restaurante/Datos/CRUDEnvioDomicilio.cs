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
    public class CRUDEnvioDomicilio
    {
        public Conexion conexion = new Conexion();

        public int InsertarEnvioDomicilio(EnvioDomicilio envioDomicilio)
        {
            try
            {

                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into ServicioDomicilio(IDCliente,Calle,Direccion,NumExterior,NumInterior,Cruzamientos,Cruzamientos2,Colonia,Zona,Referencia,Ciudad,Delegación,Estado,Pais,CP)values (@IDCliente,@Calle,@Direccion,@NumExterior,@NumInterior,@Cruzamientos,@Cruzamientos2,@Colonia,@Zona,@Referencia,@Ciudad,@Delegación,@Estado,@Pais,@CP)";
                cmd.Parameters.AddWithValue("@IDCliente", envioDomicilio.IDCliente);
                cmd.Parameters.AddWithValue("@Calle", envioDomicilio.Calle);
                cmd.Parameters.AddWithValue("@Direccion", envioDomicilio.Direccion);
                cmd.Parameters.AddWithValue("@NumExterior", envioDomicilio.NumExterior);
                cmd.Parameters.AddWithValue("@NumInterior", envioDomicilio.Pais);
                cmd.Parameters.AddWithValue("@Cruzamientos", envioDomicilio.Cruzamientos);
                cmd.Parameters.AddWithValue("@Cruzamientos2", envioDomicilio.Cruzamientos2);
                cmd.Parameters.AddWithValue("@Colonia", envioDomicilio.Colonia);
                cmd.Parameters.AddWithValue("@Zona", envioDomicilio.Zona);
                cmd.Parameters.AddWithValue("@Referencia", envioDomicilio.Referencia);
                cmd.Parameters.AddWithValue("@Ciudad", envioDomicilio.Ciudad);
                cmd.Parameters.AddWithValue("@Delegación", envioDomicilio.Delegación);
                cmd.Parameters.AddWithValue("@Estado", envioDomicilio.Estado);
                cmd.Parameters.AddWithValue("@Pais", envioDomicilio.Pais);
                cmd.Parameters.AddWithValue("@CP", envioDomicilio.CP);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }
        public int ModificarEnvioDomicilio(EnvioDomicilio envioDomicilio)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE ServicioDomicilio SET Calle=@Calle,Direccion=@Direccion,NumExterior=@NumExterior,NumInterior=@NumInterior,Cruzamientos=@Cruzamientos,Cruzamientos2=@Cruzamientos2,Colonia=@Colonia,Zona=@Zona,Referencia=@Referencia,Ciudad=@Ciudad,Delegación=@Delegación,Estado=@Estado,Pais=@Pais,CP=@CP WHERE IDCliente= '" + envioDomicilio.IDCliente + "'";
                cmd.Parameters.AddWithValue("@IDCliente", envioDomicilio.IDCliente);
                cmd.Parameters.AddWithValue("@Calle", envioDomicilio.Calle);
                cmd.Parameters.AddWithValue("@Direccion", envioDomicilio.Direccion);
                cmd.Parameters.AddWithValue("@NumExterior", envioDomicilio.NumExterior);
                cmd.Parameters.AddWithValue("@NumInterior", envioDomicilio.Pais);
                cmd.Parameters.AddWithValue("@Cruzamientos", envioDomicilio.Cruzamientos);
                cmd.Parameters.AddWithValue("@Cruzamientos2", envioDomicilio.Cruzamientos2);
                cmd.Parameters.AddWithValue("@Colonia", envioDomicilio.Colonia);
                cmd.Parameters.AddWithValue("@Zona", envioDomicilio.Zona);
                cmd.Parameters.AddWithValue("@Referencia", envioDomicilio.Referencia);
                cmd.Parameters.AddWithValue("@Ciudad", envioDomicilio.Ciudad);
                cmd.Parameters.AddWithValue("@Delegación", envioDomicilio.Delegación);
                cmd.Parameters.AddWithValue("@Estado", envioDomicilio.Estado);
                cmd.Parameters.AddWithValue("@Pais", envioDomicilio.Pais);
                cmd.Parameters.AddWithValue("@CP", envioDomicilio.CP);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public void EliminarEnvioDomicilio(string IDCliente)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM ServicioDomicilio WHERE IDCliente= '" + IDCliente + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public DataTable BuscarEnvioDomicilio(string IDCliente)
        {
            DataSet _ds = new DataSet();
            ConnectionStringSettings cns = ConfigurationManager.ConnectionStrings["BD"];
            string connectionString = cns.ConnectionString;
            SqlConnection cn = new SqlConnection(connectionString);


            SqlDataAdapter sda = new SqlDataAdapter("select * from ServicioDomicilio WHERE IDCliente = '" + IDCliente + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable ValidarEnvioDomicilio(string IDCliente)
        {
            DataSet _ds = new DataSet();
            ConnectionStringSettings cns = ConfigurationManager.ConnectionStrings["BD"];
            string connectionString = cns.ConnectionString;
            SqlConnection cn = new SqlConnection(connectionString);


            SqlDataAdapter sda = new SqlDataAdapter("select count(1) as validar from ServicioDomicilio WHERE IDCliente = '" + IDCliente + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
    }
}
