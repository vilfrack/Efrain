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
    public class CRUDTurno
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDTurno() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public void Cierre() { }
        public void Apertura(Turno Turno) {
            cn.Open();
            SqlCeCommand cmd = cn.CreateCommand();
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
            SqlCeDataAdapter sda = new SqlCeDataAdapter("SELECT COUNT(1) as Turno FROM Turno WHERE StatusTurno = '" + Status + "'", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int Turno = _datatable.Rows[0]["Turno"].ToString() == "" ? 0 : Convert.ToInt32(_datatable.Rows[0]["Turno"].ToString());
            return Turno;
        }
        public int ObtenerIDTurnoAbierto(string Status)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("SELECT MAX(IDTurno) as IDTurno FROM Turno WHERE StatusTurno = '" + Status + "'", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int Turno = _datatable.Rows[0]["Turno"].ToString() == "" ? 0 : Convert.ToInt32(_datatable.Rows[0]["Turno"].ToString());
            return Turno;
        }
    }
}
