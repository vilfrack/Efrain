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
            /*
             select Comanda.*, Mesas.IDMesas,Mesoneros.IDMesoneros, Mesoneros.Nombre,Mesoneros.Apellido from Comanda
            inner join Mesas ON Comanda.IDMesas = Mesas.IDMesas
            inner join Mesoneros ON Comanda.IDMesoneros = Mesoneros.IDMesoneros
            WHERE Comanda.Status='CERRADA'
             */
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select Comanda.*,Mesas.NumeroMesa, (Mesoneros.Nombre + ' ' + Mesoneros.Apellido) as Mesero "+
                                                        "from Comanda " +
                                                        "inner join Mesas ON Comanda.IDMesas = Mesas.IDMesas "+
                                                        "inner join Mesoneros ON Comanda.IDMesoneros = Mesoneros.IDMesoneros "+
                                                        "WHERE Comanda.Status = 'CERRADA'", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataSet ListarComanda(string IDComanda)
        {
            //DEBE MOSTRAR LA CUENTA CON TODOS LOS PEDIDOS DEL CLIENTE

            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select  Menu.Nombre as Menu, Menu.Precio, Comanda.* from Comanda " +
                                                        "inner join MasterComanda ON MasterComanda.IDComanda = Comanda.IDComanda " +
                                                        "inner join Menu ON Menu.IDMenu = MasterComanda.IDMenu " +
                                                        "where Comanda.Status = 'CERRADA' AND Comanda.IDComanda ='" + IDComanda + "' ", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public DataTable BuscarCuenta(string IDComanda)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select Comanda.*, Menu.Nombre,(Mesoneros.Nombre + ' ' + Mesoneros.Apellido) as Mesero,Mesas.NumeroMesa from Comanda " +
                                                        "inner join MasterComanda ON MasterComanda.IDComanda = Comanda.IDComanda "+
                                                        "inner join Menu ON Menu.IDMenu = MasterComanda.IDMenu "+
                                                        "inner join Mesoneros ON Mesoneros.IDMesoneros = Comanda.IDMesoneros "+
                                                        "inner join Mesas ON Mesas.IDMesas = Comanda.IDMesas "+
                                                        "where Comanda.Status = 'CERRADA' AND Comanda.IDComanda ='" + IDComanda + "' ", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }

        public DataSet BuscarCuentaByMesa(string IDMesa)
        {
            DataSet _ds = new DataSet();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select Cuenta.* from Cuenta " +
                                                        "INNER JOIN Comanda ON Comanda.IDComanda = Cuenta.IDComanad " +
                                                        "WHERE Comanda.IDMesas = '" + IDMesa + "' AND Comanda.Status='CERRADA'", cn);
            sda.Fill(_ds);
            return _ds;
        }
    }
}
