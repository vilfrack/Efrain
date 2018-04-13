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
    public class CRUDTurno : CRUDCuenta
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlConnection cn;
        public string connectionString = "";

        public CRUDTurno() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlConnection(connectionString);
        }
        public void Cierre(Turno Turno) {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE Turno SET StatusTurno = StatusTurno, Cerrar = @Cerrar WHERE IDTurno ='"+Turno.IDTurno+"'";
            cmd.Parameters.AddWithValue("@Cerrar", Turno.Cerrar);
            cmd.Parameters.AddWithValue("@StatusTurno", Turno.StatusTurno);

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Apertura(Turno Turno) {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "insert into Turno(Apertura,StatusTurno,FondoInicial) " +
                              "values (@Apertura,@StatusTurno,@FondoInicial)";
            cmd.Parameters.AddWithValue("@Apertura", Turno.Apertura);
            cmd.Parameters.AddWithValue("@StatusTurno", Turno.StatusTurno);
            cmd.Parameters.AddWithValue("@FondoInicial", Turno.FondoInicial);


            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public int ObtenerTurnoAbierto(string Status) {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(1) as Turno FROM Turno WHERE StatusTurno = '" + Status + "'", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int Turno = _datatable.Rows[0]["Turno"].ToString() == "" ? 0 : Convert.ToInt32(_datatable.Rows[0]["Turno"].ToString());
            return Turno;
        }
        public int ObtenerIDTurnoAbierto(string Status)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(IDTurno) as IDTurno FROM Turno WHERE StatusTurno = '" + Status + "'", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int Turno = _datatable.Rows[0]["IDTurno"].ToString() == "" ? 0 : Convert.ToInt32(_datatable.Rows[0]["IDTurno"].ToString());
            return Turno;
        }
        public DataSet ListarCuentasPagadas(string IDTurno)
        {
            //DEBE MOSTRAR LA CUENTA CON TODOS LOS PEDIDOS DEL CLIENTE
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Cuenta.FormaPago,Cuenta.Total FROM Cuenta " +
                                                        "INNER JOIN Turno ON Turno.IDTurno = Cuenta.IDTurno "+
                                                        "WHERE Turno.IDTurno ='"+ IDTurno + "'", cn);
            sda.Fill(_ds);
            return _ds;
        }
    }
}
