﻿using Models;
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
   public class CRUDSubGrupos
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlCeConnection cn;
        public string connectionString = "";

        public CRUDSubGrupos()
        {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlCeConnection(connectionString);
        }
        public int InsertarSubGrupo(SubGrupos Grupos)
        {
            try
            {

                //SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "insert into SubGrupos(Descripcion)values (@Descripcion)";
                cmd.Parameters.AddWithValue("@Descripcion", Grupos.Descripcion);

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
        public DataTable UltimoIDSubGrupo()
        {

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select MAX(IDSubGrupo) as IDSubGrupo from SubGrupos", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarSubGrupo(SubGrupos SubGrupo)
        {
            try
            {
                cn.Open();
                SqlCeCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE SubGrupos SET Descripcion=@Descripcion WHERE IDSubGrupo= '" + SubGrupo.IDSubGrupo + "'";
                cmd.Parameters.AddWithValue("@Descripcion", SubGrupo.Descripcion);

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
        public void EliminarSubGrupo(string IDSubGrupos)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(conexion.connectionString);

                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM SubGrupos WHERE IDSubGrupo= '" + IDSubGrupos + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarSubGrupo()
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select IDSubGrupo,Descripcion from SubGrupos", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarSubGrupo(string IDSubGrupo)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select * from SubGrupos WHERE IDSubGrupo = '" + IDSubGrupo + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable SubGruposComboBox()
        {
            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("select IDSubGrupo,Descripcion from SubGrupos", cn);
            SqlCeDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDSubGrupo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }
    }
}
