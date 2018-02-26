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
    public class CRUDCuenta
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDCuenta()
        {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarCuenta(Cuenta Cuenta)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Cuenta] (IDMesas,IDMesoneros,Reserva,Apertura,Cierre,Orden,Folio, "+
                    "SubTotal,Total,Descuento,Impuesto,Propina,Status) VALUES (@IDMesas,@IDMesoneros,@Reserva, "+
                    "@Apertura,@Cierre,@Orden,@Folio,@SubTotal,@Total,@Descuento,@Impuesto,@Propina,@Status)";
                cmd.Parameters.AddWithValue("@IDMesas", Cuenta.IDMesas);
                cmd.Parameters.AddWithValue("@IDMesoneros", Cuenta.IDMesoneros);
                cmd.Parameters.AddWithValue("@Reserva", Cuenta.Reserva);
                cmd.Parameters.AddWithValue("@Apertura", Cuenta.Apertura);
                cmd.Parameters.AddWithValue("@Cierre", Cuenta.Cierre);
                cmd.Parameters.AddWithValue("@Orden", Cuenta.Orden);
                cmd.Parameters.AddWithValue("@Folio", Cuenta.Folio);
                cmd.Parameters.AddWithValue("@SubTotal", Cuenta.SubTotal);
                cmd.Parameters.AddWithValue("@Total", Cuenta.Total);
                cmd.Parameters.AddWithValue("@Descuento", Cuenta.Descuento);
                cmd.Parameters.AddWithValue("@Impuesto", Cuenta.Impuesto);
                cmd.Parameters.AddWithValue("@Propina", Cuenta.Propina);
                cmd.Parameters.AddWithValue("@Status", Cuenta.Status);

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
        public DataTable UltimoIDCuenta()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDCuenta) as IDCuenta from Cuenta", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarCuenta(Cuenta Cuenta)
        {
            try
            {

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Cuenta SET IDMesas=@IDMesas,IDMesoneros=@IDMesoneros,Reserva=@Reserva, " +
                    "Apertura=@Apertura,Cierre=@Cierre,Orden=@Orden,Folio=@Folio,SubTotal=@SubTotal,Total=@Total, " +
                    "Descuento=@Descuento,Impuesto=@Impuesto,Propina=@Propina,Status=@Status WHERE IDCuenta= '" + Cuenta.IDCuenta + "'";
                cmd.Parameters.AddWithValue("@IDMesas", Cuenta.IDMesas);
                cmd.Parameters.AddWithValue("@IDMesoneros", Cuenta.IDMesoneros);
                cmd.Parameters.AddWithValue("@Reserva", Cuenta.Reserva);
                cmd.Parameters.AddWithValue("@Apertura", Cuenta.Apertura);
                cmd.Parameters.AddWithValue("@Cierre", Cuenta.Cierre);
                cmd.Parameters.AddWithValue("@Orden", Cuenta.Orden);
                cmd.Parameters.AddWithValue("@Folio", Cuenta.Folio);
                cmd.Parameters.AddWithValue("@SubTotal", Cuenta.SubTotal);
                cmd.Parameters.AddWithValue("@Total", Cuenta.Total);
                cmd.Parameters.AddWithValue("@Descuento", Cuenta.Descuento);
                cmd.Parameters.AddWithValue("@Impuesto", Cuenta.Impuesto);
                cmd.Parameters.AddWithValue("@Propina", Cuenta.Propina);
                cmd.Parameters.AddWithValue("@Status", Cuenta.Status);

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
        public void EliminarCuenta(string IDCuenta)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Cuenta WHERE IDCuenta= '" + IDCuenta + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarCuenta()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDGrupos,Descripcion,UnidadMedida from Cuenta", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarCuenta(string IDCuenta)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Cuenta WHERE IDCuenta = '" + IDCuenta + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }

        public DataSet BuscarCuentaByGrupo(string IDGrupos)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDCuenta,Descripcion,UnidadMedida from Cuenta WHERE IDGrupos = '" + IDGrupos + "'", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable UnidadMedida()
        {
            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("select IDUnidad,Descripcion from UnidadMedida", cn);
            SqlCeDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDUnidad", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }

    }
}
