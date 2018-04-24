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
    public class CRUDComanda : CRUDMesoneros
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlConnection cn;
        public string connectionString = "";

        public CRUDComanda() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlConnection(connectionString);
        }

        public List<Mesas> DatosMesas() {
            List<Mesas> ListMesas = new List<Mesas>();

            SqlCommand command = new SqlCommand("SELECT IDMesas,NumeroMesa,CantidadPersona FROM Mesas;", cn);
            cn.Open();
            SqlDataReader reader = command.ExecuteReader();
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

        public string DisponibilidadMesa(int IDTurno, string Status, int IDMesas) {
            string disponibilidad = "DISPONIBLE";
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(1) as validar FROM Comanda WHERE IDMesas ='"+ IDMesas + "' AND IDTurno = '"+ IDTurno + "' AND Status ='"+ Status + "';", cn);
            sda.Fill(_ds);
            string validar = _ds.Tables[0].Rows[0]["validar"].ToString();
            if (validar !="0")
            {
                disponibilidad = "NO DISPONIBLE";
            }
            return disponibilidad;
        }
        public DataTable UltimoIDComanda(Comanda Comanda)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(IDComanda) as IDComanda from Comanda WHERE IDMesas ='" + Comanda.IDMesas + "' AND Status='ABIERTA'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable ComandaAbierta(Comanda Comanda)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(1) as existe from Comanda WHERE IDMesas ='"+Comanda.IDMesas+ "' AND Status='ABIERTA'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable ComandaCerrada(Comanda Comanda)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(1) as existe from Comanda WHERE IDMesas ='" + Comanda.IDMesas + "' AND Status='CERRADA'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable BuscarComanda(Comanda Comanda)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Comanda WHERE IDMesas ='" + Comanda.IDMesas + "' AND Status='ABIERTA'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int InsertarComanda(Comanda Comanda)
        {
            try
            {

                //SqlConnection con = new SqlConnection(conexion.connectionString);

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Comanda] (IDMesas,TotalPrecio,Status,Fecha,IDTurno) VALUES (@IDMesas,@TotalPrecio,@Status,@Fecha,@IDTurno)";
                cmd.Parameters.AddWithValue("@IDMesas", Comanda.IDMesas);
                cmd.Parameters.AddWithValue("@TotalPrecio", Comanda.TotalPrecio);
                cmd.Parameters.AddWithValue("@Status", Comanda.Status);
                cmd.Parameters.AddWithValue("@Fecha", Comanda.Fecha);
                cmd.Parameters.AddWithValue("@IDTurno", Comanda.IDTurno);

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
        public int ModificarComanda(Comanda Comanda)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Comanda SET IDMesas=@IDMesas, "+
                                  "TotalPrecio=@TotalPrecio,Status=@Status, "+
                                  "IDMesoneros=@IDMesoneros WHERE IDComanda= '" + Comanda.IDComanda + "'";

                cmd.Parameters.AddWithValue("@IDMesas", Comanda.IDMesas);
                cmd.Parameters.AddWithValue("@TotalPrecio", Comanda.TotalPrecio);
                cmd.Parameters.AddWithValue("@Status", Comanda.Status);
                cmd.Parameters.AddWithValue("@IDMesoneros", Comanda.IDMesoneros);
                //cmd.Parameters.AddWithValue("@Fecha", Comanda.Fecha);

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
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from Comanda", cn);
            sda.Fill(_ds);
            return _ds;
        }

        public int InsertarMasterComanda(MasterComanda MasterComanda)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [MasterComanda] (IDComanda,IDMenu,Precio) VALUES (@IDComanda,@IDMenu,@Precio)";
                cmd.Parameters.AddWithValue("@IDComanda", MasterComanda.IDComanda);
                cmd.Parameters.AddWithValue("@IDMenu", MasterComanda.IDMenu);
                cmd.Parameters.AddWithValue("@Precio", MasterComanda.Precio);

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
        public int ModificarMasterComanda(MasterComanda MasterComanda)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
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
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
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
            SqlDataAdapter sda = new SqlDataAdapter("select Menu.Nombre as Menu,MasterComanda.* from MasterComanda " +
                                                        "INNER JOIN Menu ON  Menu.IDMenu = MasterComanda.IDMenu "+
                                                        "INNER JOIN Comanda ON Comanda.IDComanda = MasterComanda.IDComanda "+
                                                        "WHERE Comanda.IDComanda ='" + IDComanda + "' AND Comanda.Status='ABIERTA'", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public decimal GruposComboBox()
        {
            cn.Open();
            SqlCommand sc = new SqlCommand("select Precio from MasterComanda", cn);
            SqlDataReader reader;
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
