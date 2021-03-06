﻿using Models;
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
    public class CRUDPromocion : CRUDMenu
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlConnection cn;
        public string connectionString = "";

        public CRUDPromocion()
        {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlConnection(connectionString);
        }
        public int InsertarPromocion(Promociones Promocion)
        {
            try
            {
                //SqlConnection con = new SqlConnection(conexion.connectionString);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                #region Query
                cmd.CommandText = "insert into Promociones(descripcion,status,tipopromocion,lunesinicio,lunesfin,aplicalunes,lunesdiasalida " +
                   ",martesinicio,martesfin,aplicamartes,martesdiasalida,miercolesinicio,miercolesfin,aplicamiercoles,miercolesdiasalida " +
                   ",juevesinicio,juevesfin,aplicajueves,juevesdiasalida,viernesinicio,viernesfin,aplicaviernes,viernesdiasalida,sabadoinicio," +
                   "sabadofin,aplicasabado,domingoinicio,sabadodiasalida,domingofin,aplicadomingo,domingodiasalida,visualizar,Relacionuno,Relaciondos," +
                   "forzarporproducto,IDMenu,Descuento,IDTipoDescuento)values (@descripcion,@status,@tipopromocion,@lunesinicio,@lunesfin,@aplicalunes,@lunesdiasalida " +
                   ",@martesinicio,@martesfin,@aplicamartes,@martesdiasalida,@miercolesinicio,@miercolesfin,@aplicamiercoles,@miercolesdiasalida" +
                   ",@juevesinicio,@juevesfin,@aplicajueves,@juevesdiasalida,@viernesinicio,@viernesfin,@aplicaviernes,@viernesdiasalida,@sabadoinicio," +
                   "@sabadofin,@aplicasabado,@domingoinicio,@sabadodiasalida,@domingofin,@aplicadomingo,@domingodiasalida,@visualizar,@Relacionuno,@Relaciondos," +
                   "@forzarporproducto,@IDMenu,@Descuento,@IDTipoDescuento)";
                #endregion

                #region Parametros
                cmd.Parameters.AddWithValue("@descripcion", Promocion.descripcion);
                cmd.Parameters.AddWithValue("@status", Promocion.status);
                cmd.Parameters.AddWithValue("@tipopromocion", Promocion.tipopromocion);
                cmd.Parameters.AddWithValue("@IDMenu", Promocion.IDMenu);
                cmd.Parameters.AddWithValue("@Descuento", Promocion.descuento);
                cmd.Parameters.AddWithValue("@IDTipoDescuento", Promocion.IDTipoDescuento);


                cmd.Parameters.AddWithValue("@lunesinicio", Promocion.lunesinicio);
                cmd.Parameters.AddWithValue("@lunesfin", Promocion.lunesfin);
                cmd.Parameters.AddWithValue("@aplicalunes", Promocion.aplicalunes);
                cmd.Parameters.AddWithValue("@lunesdiasalida", Promocion.lunesdiasalida);
                cmd.Parameters.AddWithValue("@martesinicio", Promocion.martesinicio);
                cmd.Parameters.AddWithValue("@martesfin", Promocion.martesfin);
                cmd.Parameters.AddWithValue("@aplicamartes", Promocion.aplicamartes);
                cmd.Parameters.AddWithValue("@martesdiasalida", Promocion.martesdiasalida);
                cmd.Parameters.AddWithValue("@miercolesinicio", Promocion.miercolesinicio);
                cmd.Parameters.AddWithValue("@miercolesfin", Promocion.miercolesfin);
                cmd.Parameters.AddWithValue("@aplicamiercoles", Promocion.aplicamiercoles);
                cmd.Parameters.AddWithValue("@miercolesdiasalida", Promocion.miercolesdiasalida);
                cmd.Parameters.AddWithValue("@juevesinicio", Promocion.juevesinicio);
                cmd.Parameters.AddWithValue("@juevesfin", Promocion.juevesfin);
                cmd.Parameters.AddWithValue("@aplicajueves", Promocion.aplicajueves);
                cmd.Parameters.AddWithValue("@juevesdiasalida", Promocion.juevesdiasalida);
                cmd.Parameters.AddWithValue("@viernesinicio", Promocion.viernesinicio);
                cmd.Parameters.AddWithValue("@viernesfin", Promocion.viernesfin);
                cmd.Parameters.AddWithValue("@aplicaviernes", Promocion.aplicaviernes);
                cmd.Parameters.AddWithValue("@viernesdiasalida", Promocion.viernesdiasalida);
                cmd.Parameters.AddWithValue("@sabadoinicio", Promocion.sabadoinicio);
                cmd.Parameters.AddWithValue("@sabadofin", Promocion.sabadofin);
                cmd.Parameters.AddWithValue("@aplicasabado", Promocion.aplicasabado);
                cmd.Parameters.AddWithValue("@domingoinicio", Promocion.domingoinicio);
                cmd.Parameters.AddWithValue("@sabadodiasalida", Promocion.sabadodiasalida);
                cmd.Parameters.AddWithValue("@domingofin", Promocion.domingofin);
                cmd.Parameters.AddWithValue("@aplicadomingo", Promocion.aplicadomingo);
                cmd.Parameters.AddWithValue("@domingodiasalida", Promocion.domingodiasalida);
                cmd.Parameters.AddWithValue("@visualizar", Promocion.visualizar);
                cmd.Parameters.AddWithValue("@Relacionuno", Promocion.Relacionuno);
                cmd.Parameters.AddWithValue("@Relaciondos", Promocion.Relaciondos);
                cmd.Parameters.AddWithValue("@forzarporproducto", Promocion.forzarporproducto);

                #endregion

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
        public DataTable UltimoIDPromocion()
        {

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(IDPromociones) as IDPromocion from Promociones", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarPromocion(Promociones Promocion)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                #region Query
                cmd.CommandText = "UPDATE Promociones SET descripcion=@descripcion,status=@status,tipopromocion=@tipopromocion,lunesinicio=@lunesinicio," +
                "lunesfin=@lunesfin,aplicalunes=@aplicalunes,lunesdiasalida=@lunesdiasalida,martesinicio=@martesinicio,martesfin=@martesfin," +
                "aplicamartes=@aplicamartes,martesdiasalida=@martesdiasalida,miercolesinicio=@miercolesinicio,miercolesfin=@miercolesfin," +
                "aplicamiercoles=@aplicamiercoles,miercolesdiasalida=@miercolesdiasalida,juevesinicio=@juevesinicio,juevesfin=@juevesfin," +
                "aplicajueves=@aplicajueves,juevesdiasalida=@juevesdiasalida,viernesinicio=@viernesinicio,viernesfin=@viernesfin," +
                "aplicaviernes=@aplicaviernes,viernesdiasalida=@viernesdiasalida,sabadoinicio=@sabadoinicio,sabadofin=@sabadofin," +
                "aplicasabado=@aplicasabado,domingoinicio=@domingoinicio,sabadodiasalida=@sabadodiasalida,domingofin=@domingofin,aplicadomingo=@aplicadomingo" +
                ",domingodiasalida=@domingodiasalida,visualizar=@visualizar,Relacionuno=@Relacionuno,Relaciondos=@Relaciondos,forzarporproducto=@forzarporproducto, "+
                "IDMenu=@IDMenu,Descuento = @Descuento,IDTipoDescuento =@IDTipoDescuento " +
                "WHERE IDPromociones= '" + Promocion.IDPromociones + "'";
                #endregion
                //"The parameterized query '(@descripcion nvarchar(6),@status nvarchar(6),@tipopromocion nva' expects the parameter '@lunesdiasalida', which was not supplied."
                #region Parametros
                cmd.Parameters.AddWithValue("@descripcion", Promocion.descripcion);
                cmd.Parameters.AddWithValue("@status", Promocion.status);
                cmd.Parameters.AddWithValue("@tipopromocion", Promocion.tipopromocion);
                cmd.Parameters.AddWithValue("@IDMenu", Promocion.IDMenu);
                cmd.Parameters.AddWithValue("@Descuento", Promocion.descuento);
                cmd.Parameters.AddWithValue("@IDTipoDescuento", Promocion.IDTipoDescuento);

                cmd.Parameters.AddWithValue("@lunesinicio", Promocion.lunesinicio);
                cmd.Parameters.AddWithValue("@lunesfin", Promocion.lunesfin);
                cmd.Parameters.AddWithValue("@aplicalunes", Promocion.aplicalunes);
                cmd.Parameters.AddWithValue("@lunesdiasalida", Promocion.lunesdiasalida);
                cmd.Parameters.AddWithValue("@martesinicio", Promocion.martesinicio);
                cmd.Parameters.AddWithValue("@martesfin", Promocion.martesfin);
                cmd.Parameters.AddWithValue("@aplicamartes", Promocion.aplicamartes);
                cmd.Parameters.AddWithValue("@martesdiasalida", Promocion.martesdiasalida);
                cmd.Parameters.AddWithValue("@miercolesinicio", Promocion.miercolesinicio);
                cmd.Parameters.AddWithValue("@miercolesfin", Promocion.miercolesfin);
                cmd.Parameters.AddWithValue("@aplicamiercoles", Promocion.aplicamiercoles);
                cmd.Parameters.AddWithValue("@miercolesdiasalida", Promocion.miercolesdiasalida);
                cmd.Parameters.AddWithValue("@juevesinicio", Promocion.juevesinicio);
                cmd.Parameters.AddWithValue("@juevesfin", Promocion.juevesfin);
                cmd.Parameters.AddWithValue("@aplicajueves", Promocion.aplicajueves);
                cmd.Parameters.AddWithValue("@juevesdiasalida", Promocion.juevesdiasalida);
                cmd.Parameters.AddWithValue("@viernesinicio", Promocion.viernesinicio);
                cmd.Parameters.AddWithValue("@viernesfin", Promocion.viernesfin);
                cmd.Parameters.AddWithValue("@aplicaviernes", Promocion.aplicaviernes);
                cmd.Parameters.AddWithValue("@viernesdiasalida", Promocion.viernesdiasalida);
                cmd.Parameters.AddWithValue("@sabadoinicio", Promocion.sabadoinicio);
                cmd.Parameters.AddWithValue("@sabadofin", Promocion.sabadofin);
                cmd.Parameters.AddWithValue("@aplicasabado", Promocion.aplicasabado);
                cmd.Parameters.AddWithValue("@domingoinicio", Promocion.domingoinicio);
                cmd.Parameters.AddWithValue("@sabadodiasalida", Promocion.sabadodiasalida);
                cmd.Parameters.AddWithValue("@domingofin", Promocion.domingofin);
                cmd.Parameters.AddWithValue("@aplicadomingo", Promocion.aplicadomingo);
                cmd.Parameters.AddWithValue("@domingodiasalida", Promocion.domingodiasalida);
                cmd.Parameters.AddWithValue("@visualizar", Promocion.visualizar);
                cmd.Parameters.AddWithValue("@Relacionuno", Promocion.Relacionuno);
                cmd.Parameters.AddWithValue("@Relaciondos", Promocion.Relaciondos);
                cmd.Parameters.AddWithValue("@forzarporproducto", Promocion.forzarporproducto);
                #endregion

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
        public void EliminarPromocion(string IDPromocion)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Promociones WHERE IDPromociones= '" + IDPromocion + "'";

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet ListarPromocion()
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Promociones", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarPromocion(string IDPromocion)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Promociones WHERE IDPromociones = '" + IDPromocion + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        //public DataTable PromocionComboBox()
        //{
        //    cn.Open();
        //    SqlCommand sc = new SqlCommand("select IDSubGrupo,Descripcion from SubGrupos", cn);
        //    SqlDataReader reader;
        //    reader = sc.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("IDSubGrupo", typeof(string));
        //    dt.Columns.Add("Descripcion", typeof(string));
        //    dt.Load(reader);
        //    cn.Close();
        //    return dt;
        //}

    }
}
