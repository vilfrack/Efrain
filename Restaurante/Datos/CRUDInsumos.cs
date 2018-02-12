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
    public class CRUDInsumos : CRUDGrupos
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDInsumos() {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarInsumos(Insumos Insumos)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Insumos] (IDGrupos,Descripcion,UnidadMedida,UltimoCosto,CostoPromedio,CostoImpuesto,IVA,Inventariable) VALUES (@IDGrupos,@Descripcion,@UnidadMedida,@UltimoCosto,@CostoPromedio,@CostoImpuesto,@IVA,@Inventariable)";
                cmd.Parameters.AddWithValue("@IDGrupos", Insumos.IDGrupos);
                cmd.Parameters.AddWithValue("@Descripcion", Insumos.Descripcion);
                cmd.Parameters.AddWithValue("@UnidadMedida", Insumos.UnidadMedida);
                cmd.Parameters.AddWithValue("@UltimoCosto", Insumos.UltimoCosto);
                cmd.Parameters.AddWithValue("@CostoPromedio", Insumos.CostoPromedio);
                cmd.Parameters.AddWithValue("@CostoImpuesto", Insumos.CostoImpuesto);
                cmd.Parameters.AddWithValue("@IVA", Insumos.IVA);
                cmd.Parameters.AddWithValue("@Inventariable", Insumos.Inventariable);

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
        public DataTable UltimoIDInsumo()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDInsumos) as IDInsumos from Insumos", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarInsumo(Insumos Insumos)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Insumos SET IDGrupos=@IDGrupos,Descripcion=@Descripcion,UnidadMedida=@UnidadMedida,UltimoCosto=@UltimoCosto,CostoPromedio=@CostoPromedio,CostoImpuesto=@CostoImpuesto,IVA=@IVA,Inventariable=@Inventariable WHERE IDInsumos= '" + Insumos.IDInsumos + "'";
                cmd.Parameters.AddWithValue("@IDGrupos", Insumos.IDGrupos);
                cmd.Parameters.AddWithValue("@Descripcion", Insumos.Descripcion);
                cmd.Parameters.AddWithValue("@UnidadMedida", Insumos.UnidadMedida);
                cmd.Parameters.AddWithValue("@UltimoCosto", Insumos.UltimoCosto);
                cmd.Parameters.AddWithValue("@CostoPromedio", Insumos.CostoPromedio);
                cmd.Parameters.AddWithValue("@CostoImpuesto", Insumos.CostoImpuesto);
                cmd.Parameters.AddWithValue("@IVA", Insumos.IVA);
                cmd.Parameters.AddWithValue("@Inventariable", Insumos.Inventariable);

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
        public void EliminarInsumo(string IDInsumos)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Insumos WHERE IDInsumos= '" + IDInsumos + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarInsumo()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDGrupos,Descripcion,UnidadMedida from Insumos", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarInsumo(string IDInsumos)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Insumos WHERE IDInsumos = '" + IDInsumos + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataSet BuscarInsumoByGrupo(string IDGrupos)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDInsumos,Descripcion,UnidadMedida from Insumos WHERE IDGrupos = '" + IDGrupos + "'", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable UnidadMedida() {
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
