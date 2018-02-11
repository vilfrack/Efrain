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
    public class CRUDInsumos
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
        public int InsertarGrupo(Insumos Insumos)
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
        public DataTable UltimoIDGrupo()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDGrupo) as IDGrupo from Grupos", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarGrupo(Grupos Grupos)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Insumos SET Descripcion=@Descripcion WHERE IDGrupo= '" + Grupos.IDGrupo + "'";
                cmd.Parameters.AddWithValue("@Descripcion", Grupos.Descripcion);

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
        public void EliminarGrupo(string IDGrupos)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Insumos WHERE IDGrupo= '" + IDGrupos + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarGrupo()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDGrupo,Descripcion from Insumos", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarGrupo(string IDGrupos)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from Insumos WHERE IDGrupo = '" + IDGrupos + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }

    }
}
