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
        public void Apertura() { }
        public int Consecutivo() {
            int consecutivo = 0;
            string FechaCierre = DateTime.Now.ToShortDateString();
            string FechaApertura = DateTime.Now.ToShortDateString();

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select count(1) as Validar from Cierre WHERE Cierre ='"+ FechaCierre + "'" , cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int validar =  _datatable.Rows[0]["Validar"].ToString() == "" ?0 : Convert.ToInt32(_datatable.Rows[0]["Validar"].ToString());
            if (validar > 0)
            {
                consecutivo = 1;
            }
            else
            {

            }

            return consecutivo;
        }
    }
}
