using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using Models;
using System.Configuration;
using System.Data;

namespace Datos
{
    public class CRUDCliente
    {
        public Conexion conexion = new Conexion();

        public int InsertarCliente(Cliente cliente) {
            try
            {
                
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into Cliente(Nombre,Direccion,Tipo_Facturacion,Estado,Pais,CodPostal,FolioFiscal,rfc,Curp,Giro,Poblacion,Contacto,Telefono1,Telefono2,Telefono3,Telefono4,Telefono5)values (@Nombre,@Direccion,@Tipo_Facturacion,@Estado,@Pais,@CodPostal,@FolioFiscal,@rfc,@Curp,@Giro,@Poblacion,@Contacto,@Telefono1,@Telefono2,@Telefono3,@Telefono4,@Telefono5)";
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Tipo_Facturacion", cliente.Tipo_facturacion);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@Pais", cliente.Pais);
                cmd.Parameters.AddWithValue("@CodPostal", cliente.CodPostal);
                cmd.Parameters.AddWithValue("@FolioFiscal", cliente.FolioFiscal);
                cmd.Parameters.AddWithValue("@rfc", cliente.Rfc);
                cmd.Parameters.AddWithValue("@Curp", cliente.Curp);
                cmd.Parameters.AddWithValue("@Giro", cliente.Giro);
                cmd.Parameters.AddWithValue("@Poblacion", cliente.Poblacion);
                cmd.Parameters.AddWithValue("@Contacto", cliente.Contacto);
                cmd.Parameters.AddWithValue("@Telefono1", cliente.Telefono1);
                cmd.Parameters.AddWithValue("@Telefono2", cliente.Telefono2);
                cmd.Parameters.AddWithValue("@Telefono3", cliente.Telefono3);
                cmd.Parameters.AddWithValue("@Telefono4", cliente.Telefono4);
                cmd.Parameters.AddWithValue("@Telefono5", cliente.Telefono5);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (SqlCeException ex)
            {
                return 0;
            }

        }
        public int ModificarCliente()
        {
            return 0;
        }
        public int EliminarCliente()
        {
            return 0;
        }
        public DataSet ListarCliente()
        {
            DataSet _ds = new DataSet();
            ConnectionStringSettings cns = ConfigurationManager.ConnectionStrings["BD"];
            string connectionString = cns.ConnectionString;
            SqlCeConnection cn = new SqlCeConnection(connectionString);


            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Cliente", cn);
            sda.Fill(_ds);
            return _ds;
        }
    }
}
