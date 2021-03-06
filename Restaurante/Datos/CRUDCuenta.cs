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
    public class CRUDCuenta : Comanda
    {
        public Conexion conexion = new Conexion();
        public ConnectionStringSettings cns;
        public SqlConnection cn;
        public string connectionString = "";

        public CRUDCuenta()
        {
            cns = ConfigurationManager.ConnectionStrings["BD"];
            connectionString = cns.ConnectionString;
            cn = new SqlConnection(connectionString);
        }
        public void InsertarCuenta(Cuenta Cuenta)
        {
            try
            {

                //SqlConnection con = new SqlConnection(conexion.connectionString);

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Cuenta] (IDMesas,IDMesoneros,IDComanda,Reserva,Apertura,Cierre,Orden,Folio, " +
                    "SubTotal,Total,Descuento,Impuesto,Propina,Status,IDTurno) VALUES (@IDMesas,@IDMesoneros,@IDComanda,@Reserva, " +
                    "@Apertura,@Cierre,@Orden,@Folio,@SubTotal,@Total,@Descuento,@Impuesto,@Propina,@Status,@IDTurno)";
                cmd.Parameters.AddWithValue("@IDMesas", Cuenta.IDMesas);
                cmd.Parameters.AddWithValue("@IDMesoneros", Cuenta.IDMesoneros);
                cmd.Parameters.AddWithValue("@IDComanda", Cuenta.IDComanda);
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
                cmd.Parameters.AddWithValue("@IDTurno", Cuenta.IDTurno);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (SqlException ex)
            {

            }

        }
        public DataTable UltimoIDCuenta()
        {

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(IDCuenta) as IDCuenta from Cuenta", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public int ModificarCuenta(Cuenta Cuenta)
        {
            try
            {

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
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
                SqlConnection con = new SqlConnection(conexion.connectionString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
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
        public DataSet ListarCuenta(int IDTurno)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select Comanda.*,Mesas.NumeroMesa, (Mesoneros.Nombre + ' ' + Mesoneros.Apellido) as Mesero " +
                                                        "from Comanda " +
                                                        "inner join Mesas ON Comanda.IDMesas = Mesas.IDMesas " +
                                                        "inner join Mesoneros ON Comanda.IDMesoneros = Mesoneros.IDMesoneros " +
                                                        "WHERE Comanda.Status = 'CERRADA' AND Comanda.IDTurno='"+ IDTurno + "'", cn);
            sda.Fill(_ds);
            return _ds;
        }

        public DataTable BuscarComandaCuenta(string IDComanda)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select Comanda.*, Menu.Nombre,(Mesoneros.Nombre + ' ' + Mesoneros.Apellido) as Mesero,Mesas.NumeroMesa,Mesas.IDMesas from Comanda " +
                                                        "inner join MasterComanda ON MasterComanda.IDComanda = Comanda.IDComanda " +
                                                        "inner join Menu ON Menu.IDMenu = MasterComanda.IDMenu " +
                                                        "inner join Mesoneros ON Mesoneros.IDMesoneros = Comanda.IDMesoneros " +
                                                        "inner join Mesas ON Mesas.IDMesas = Comanda.IDMesas " +
                                                        "where Comanda.Status = 'CERRADA' AND Comanda.IDComanda ='" + IDComanda + "' ", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataTable BuscarCuenta(string IDComanda, string Status)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * FROM Cuenta " +
                                                        "where Status = '" + Status + "' AND IDComanda ='" + IDComanda + "' ", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];
        }
        public DataSet BuscarCuentaByMesa(string IDMesa)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select Cuenta.* from Cuenta " +
                                                        "INNER JOIN Comanda ON Comanda.IDComanda = Cuenta.IDComanad " +
                                                        "WHERE Comanda.IDMesas = '" + IDMesa + "' AND Comanda.Status='CERRADA'", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public int Actualizar(Cuenta cuenta) {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Cuenta SET Orden=@Orden,Folio=@Folio,Cierre=@Cierre,Total=@Total,Propina=@Propina,Impuesto=@Impuesto,Cargo=@Cargo,Monedero=@Monedero,Descuento=@Descuento WHERE IDCuenta= '" + cuenta.IDCuenta + "'";
                cmd.Parameters.AddWithValue("@Orden", cuenta.Orden);
                cmd.Parameters.AddWithValue("@Folio", cuenta.Folio);
                cmd.Parameters.AddWithValue("@Cierre", cuenta.Cierre);

                cmd.Parameters.AddWithValue("@Total", cuenta.Total);
                cmd.Parameters.AddWithValue("@Propina", cuenta.Propina);
                cmd.Parameters.AddWithValue("@Impuesto", cuenta.Impuesto);
                cmd.Parameters.AddWithValue("@Cargo", cuenta.Cargo);
                cmd.Parameters.AddWithValue("@Monedero", cuenta.Monedero);
                cmd.Parameters.AddWithValue("@Descuento", cuenta.Descuento);

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
        public int ActualizarStatusCuenta(Cuenta cuenta) {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Cuenta SET "+
                                        "Status=@Status, "+
                                        "FormaPago = @FormaPago, " +
                                        "Total =@Total, " +
                                        "Propina = @Propina, " +
                                        "Descuento = @Descuento " +
                                    "WHERE IDCuenta= '" + cuenta.IDCuenta + "'";

                cmd.Parameters.AddWithValue("@Status", cuenta.Status);
                cmd.Parameters.AddWithValue("@FormaPago", cuenta.FormaPago);
                cmd.Parameters.AddWithValue("@Total", cuenta.Total);
                cmd.Parameters.AddWithValue("@Propina", cuenta.Propina);
                cmd.Parameters.AddWithValue("@Descuento", cuenta.Descuento);

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
        public void ActualizarOrden(Cuenta cuenta)
        {
            try
            {

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Cuenta SET Orden=@Orden WHERE IDComanda= '" + cuenta.IDComanda + "'";
                cmd.Parameters.AddWithValue("@Orden", cuenta.Orden);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

            }
        }
        public int Consecutivo(string status)
        {
            int consecutivo = 0;
            string FechaCierre = DateTime.Now.ToShortDateString();
            string FechaApertura = DateTime.Now.ToShortDateString();

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select count(1) as Validar from Cuenta WHERE Status ='" + status + "'", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int validar = _datatable.Rows[0]["Validar"].ToString() == "" ? 0 : Convert.ToInt32(_datatable.Rows[0]["Validar"].ToString());
            if (validar > 0)
            {
                consecutivo = validar + 1;
            }
            else
            {
                consecutivo = 1;
            }

            return consecutivo;
        }
        public int Folio() {
            int folio = 0;
            string FechaCierre = DateTime.Now.ToShortDateString();
            string FechaApertura = DateTime.Now.ToShortDateString();

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select count(1) as folio from Cuenta WHERE Imprimir =1", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int validar = _datatable.Rows[0]["folio"].ToString() == "" ? 0 : Convert.ToInt32(_datatable.Rows[0]["folio"].ToString());
            if (validar > 0)
            {
                folio = 1;
            }
            else
            {
                folio = validar + 1;
            }

            return folio;
        }
        public bool CuentaAbierta(string Status) {
            bool cuenta = false;
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(1) as cuenta from Cuenta WHERE Status='" + Status + "'", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            int Turno = _datatable.Rows[0]["cuenta"].ToString() == "" ? 0 : Convert.ToInt32(_datatable.Rows[0]["cuenta"].ToString());
            if (Turno != 0)
            {
                cuenta = true;
            }
            return cuenta;
        }
        public DataSet ListarComanda(string IDComanda)
        {
            //DEBE MOSTRAR LA CUENTA CON TODOS LOS PEDIDOS DEL CLIENTE

            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select  Menu.IDMenu,Menu.Nombre as Menu, Menu.Precio, Comanda.* from Comanda " +
                                                        "inner join MasterComanda ON MasterComanda.IDComanda = Comanda.IDComanda " +
                                                        "inner join Menu ON Menu.IDMenu = MasterComanda.IDMenu " +
                                                        "where Comanda.Status = 'PROCESANDO' AND Comanda.IDComanda ='" + IDComanda + "' ", cn);
            sda.Fill(_ds);
            return _ds;
        }
        public decimal obtenerDescuento(string IDMenu) {
            decimal descuento = 0;
            //SE OBTENDRIA EL IDMENU DE PROMOCIONES
            DataSet _ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select Descuento FROM Promociones " +
                                                        "where IDMenu = '" + IDMenu + "'", cn);
            sda.Fill(_ds);

            DataTable _datatable = new DataTable();
            _datatable = _ds.Tables[0];
            string dato = _datatable.Rows.Count > 0 ? _datatable.Rows[0]["Descuento"].ToString() : "0";
            //dato = dato == "" ? "0" : dato;

            descuento = Convert.ToDecimal(dato);

            return descuento;
        }
        public List<Promociones> PromocionesDia(string IDMenu, string dia) {

            List<Promociones> lista = new List<Promociones>();
            SqlCommand command = new SqlCommand("select * FROM Promociones where IDMenu = '" + IDMenu + "'", cn);
            cn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                switch (dia)
                {
                    case "lunes":
                        lista.Add(new Promociones
                        {
                            aplicalunes = true,
                            lunesinicio = reader["lunesinicio"].ToString(),
                            lunesfin = reader["lunesfin"].ToString()
                        });
                        break;
                    case "martes":
                        lista.Add(new Promociones
                        {
                            aplicamartes = true,
                            martesinicio = reader["martesinicio"].ToString(),
                            martesfin = reader["martesfin"].ToString(),
                        });
                        break;
                    case "miércoles":
                        lista.Add(new Promociones
                        {
                            aplicamiercoles = true,
                            miercolesinicio = reader["miercolesinicio"].ToString(),
                            miercolesfin = reader["miercolesfin"].ToString(),
                        });
                        break;
                    case "jueves":
                        lista.Add(new Promociones
                        {
                            aplicajueves = true,
                            juevesinicio = reader["juevesinicio"].ToString(),
                            juevesfin = reader["juevesfin"].ToString(),
                        });
                        break;
                    case "viernes":
                        lista.Add(new Promociones
                        {
                            aplicaviernes = true,
                            viernesinicio = reader["viernesinicio"].ToString(),
                            viernesfin = reader["viernesfin"].ToString(),
                        });
                        break;
                    case "sabado":
                        lista.Add(new Promociones
                        {
                            aplicasabado = true,
                            sabadoinicio = reader["sabadoinicio"].ToString(),
                            sabadofin = reader["sabadofin"].ToString(),
                        });
                        break;
                    case "domingo":
                        lista.Add(new Promociones
                        {
                            aplicadomingo = true,
                            domingoinicio = reader["domingoinicio"].ToString(),
                            domingofin = reader["domingofin"].ToString(),
                        });
                        break;
                }

            }
            reader.Close();
            cn.Close();
            return lista;
        }
        public DataTable HorasDias(string IDMenu) {
            decimal descuento = 0;
            DataSet _ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter("select * FROM Promociones " +
                                                        "where IDMenu = '" + IDMenu + "'", cn);
            sda.Fill(_ds);
            return _ds.Tables[0];

        }
    }
}
