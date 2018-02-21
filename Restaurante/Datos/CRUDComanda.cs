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
    public class CRUDComanda
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDComanda() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }

        public List<Mesas> DatosMesas() {
            List<Mesas> ListMesas = new List<Mesas>();

            SqlCeCommand command = new SqlCeCommand("SELECT IDMesas,NumeroMesa,CantidadPersona FROM Mesas;", cn);
            cn.Open();
            SqlCeDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListMesas.Add(new Mesas {
                    IDMesas = reader.GetInt32(0),
                    NumeroMesa =Convert.ToInt32(reader.GetString(1)),
                    CantidadPersona = reader.GetInt32(2)
                });
            }
            reader.Close();
            cn.Close();
            return ListMesas;
        }
        public DataTable UltimoIDComanda(Comanda Comanda)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDComanda) as IDComanda from Comanda WHERE IDMesas ='" + Comanda.IDMesas + "' AND Status='ABIERTA'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable ComandaAbierta(Comanda Comanda)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select Count(1) as existe from Comanda WHERE IDMesas ='"+Comanda.IDMesas+ "' AND Status='ABIERTA'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable BuscarComanda(Comanda Comanda)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Comanda WHERE IDMesas ='" + Comanda.IDMesas + "' AND Status='ABIERTA'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int InsertarComanda(Comanda Comanda)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Comanda] (IDMesas,TotalPrecio,Status,Fecha) VALUES (@IDMesas,@TotalPrecio,@Status,@Fecha)";
                cmd.Parameters.AddWithValue("@IDMesas", Comanda.IDMesas);
                cmd.Parameters.AddWithValue("@TotalPrecio", Comanda.TotalPrecio);
                cmd.Parameters.AddWithValue("@Status", Comanda.Status);
                cmd.Parameters.AddWithValue("@Fecha", Comanda.Fecha);

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
        public int ModificarComanda(Comanda Comanda)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Comanda SET IDMesas=@IDMesas,TotalPrecio=@TotalPrecio,Status=@Status,Fecha=@Fecha WHERE IDComanda= '" + Comanda.IDComanda + "'";
                cmd.Parameters.AddWithValue("@IDMesas", Comanda.IDMesas);
                cmd.Parameters.AddWithValue("@TotalPrecio", Comanda.TotalPrecio);
                cmd.Parameters.AddWithValue("@Status", Comanda.Status);
                cmd.Parameters.AddWithValue("@Fecha", Comanda.Fecha);

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
        public void EliminarComanda(string IDComanda)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Comanda WHERE IDComanda= '" + IDComanda + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarComanda()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Comanda", cn);
            sda.Fill(_ds);
            return _ds;
        }

        public int InsertarMasterComanda(MasterComanda MasterComanda)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [MasterComanda] (IDComanda,IDMenu,Precio) VALUES (@IDComanda,@IDMenu,@Precio)";
                cmd.Parameters.AddWithValue("@IDComanda", MasterComanda.IDComanda);
                cmd.Parameters.AddWithValue("@IDMenu", MasterComanda.IDMenu);
                cmd.Parameters.AddWithValue("@Precio", MasterComanda.Precio);

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
        public int ModificarMasterComanda(MasterComanda MasterComanda)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE MasterComanda SET IDComanda=@IDComanda,IDMenu=@IDMenu,Precio=@Precio WHERE IDMasterComanda= '" + MasterComanda.IDMasterComanda + "'";
                cmd.Parameters.AddWithValue("@IDComanda", MasterComanda.IDComanda);
                cmd.Parameters.AddWithValue("@IDMenu", MasterComanda.IDMenu);
                cmd.Parameters.AddWithValue("@Precio", MasterComanda.Precio);

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
        public void EliminarMasterComanda(int IDMasterComanda)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM MasterComanda WHERE IDMasterComanda= '" + IDMasterComanda + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarMasterComanda(int IDComanda)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select Menu.Nombre as Menu,MasterComanda.* from MasterComanda " +
                                                        "INNER JOIN Menu ON  Menu.IDMenu = MasterComanda.IDMenu "+
                                                        "WHERE IDComanda ='"+ IDComanda + "'", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public decimal GruposComboBox()
        {
            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("select Precio from MasterComanda", cn);
            SqlCeDataReader reader;
            reader = sc.ExecuteReader();
            decimal Precio = 0;

            while (reader.Read())
            {
                //int employeeID = rdr.GetInt32(0);   // or: rdr["EmployeeKey"];
                Precio = Precio + Convert.ToDecimal(reader["Precio"].ToString()); // or: rdr["FirstName"];
            }
            cn.Close();
            Precio = Math.Round(Convert.ToDecimal(Precio), 2);
            return Precio;
        }
    }
}
