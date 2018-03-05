﻿using Datos;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class CuentaForm : Form
    {
        public CuentaForm()
        {
            InitializeComponent();
        }

        public CRUDCuenta CRUDCuenta = new CRUDCuenta();
        private Cuenta Cuenta = new Cuenta();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        private Utilidades.Status status = new Utilidades.Status();

        private void CuentaForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionGridview(GridViewComanda);
            utilidades.ConfiguracionGridview(GridViewCuenta);
            utilidades.ConfiguracionFormulario(this);
            BindGrid();
            //BindGridComanda();
            //btnEditar.Enabled = false;
            btnImprimir.Enabled = false;
            //BtnGuardar.Enabled = false;

            //Controles(false);

            //comboInventariable.Items.Add("Si");
            //comboInventariable.Items.Add("No");
            //comboInventariable.SelectedIndex = 0;
            //UNIDAD DE MEDIDA
            //ComboUnidadMedida();
            //GRUPOS
            //ComboGrupos();
        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDCuenta.ListarCuenta();
            if (_ds.Tables.Count > 0)
            {
                GridViewCuenta.DataSource = _ds.Tables[0];
                this.GridViewCuenta.Columns["IDMesas"].Visible = false;
                this.GridViewCuenta.Columns["IDMesoneros"].Visible = false;
                this.GridViewCuenta.Columns["IDComanda"].Visible = false;
                this.GridViewCuenta.Columns["Mesero"].Visible = false;
                this.GridViewCuenta.Columns["NumeroMesa"].Visible = false;
                this.GridViewCuenta.Columns["Status"].Visible = false;
            }
        }
        private void BindGridComanda(string IDComanda)
        {
            DataSet _ds = new DataSet();
            _ds = CRUDCuenta.ListarComanda(IDComanda);
            if (_ds.Tables.Count > 0)
            {
                GridViewComanda.DataSource = _ds.Tables[0];
                this.GridViewComanda.Columns["IDMesas"].Visible = false;
                this.GridViewComanda.Columns["IDMesoneros"].Visible = false;
                this.GridViewComanda.Columns["IDComanda"].Visible = false;
                this.GridViewComanda.Columns["Status"].Visible = false;
                this.GridViewComanda.Columns["TotalPrecio"].Visible = false;
            }
        }


        private void Controles(bool accion)
        {
            if (accion)
            {
                //txtIDInsumo.Enabled = true;
                //txtUltimoCosto.Enabled = true;
                //txtDescripcionInsumo.Enabled = true;
                //comboInventariable.Enabled = true;
                //txtCostoPromedio.Enabled = true;
                //comboUnidadMedida.Enabled = true;
                //comboIDGrupo.Enabled = true;
                //txtCostoImpuesto.Enabled = true;
                //txtIva.Enabled = true;


                txtIDCuenta.Enabled = true;
                txtMesero.Enabled = true;
                txtReserva.Enabled = true;
                txtNumeroMesa.Enabled = true;
                txtFolio.Enabled = true;
                txtComisionista.Enabled = true;
                txtOrden.Enabled = true;
                txtNomCliente.Enabled = true;
                txtApertura.Enabled = true;
            }
            else
            {
                //txtIDInsumo.Enabled = false;
                //txtUltimoCosto.Enabled = false;
                //txtDescripcionInsumo.Enabled = false;
                //comboInventariable.Enabled = false;
                //txtCostoPromedio.Enabled = false;
                //comboUnidadMedida.Enabled = false;
                //comboIDGrupo.Enabled = false;
                //txtCostoImpuesto.Enabled = false;
                //txtIva.Enabled = false;

                txtIDCuenta.Enabled = false;
                txtMesero.Enabled = false;
                txtReserva.Enabled = false;
                txtNumeroMesa.Enabled = false;
                txtFolio.Enabled = false;
                txtComisionista.Enabled = false;
                txtOrden.Enabled = false;
                txtNomCliente.Enabled = false;
                txtApertura.Enabled = false;
            }

        }

        private void BindGridByCombo()
        {
            string IDMesas = comboBuscarMesa.SelectedValue.ToString();
            DataSet _ds = new DataSet();
            _ds = CRUDCuenta.BuscarCuentaByMesa(IDMesas);
            if (_ds.Tables.Count > 0)
            {
                GridViewCuenta.DataSource = _ds.Tables[0];
            }
        }

        private void comboBuscarMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridByCombo();
        }

        private void txtSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender,e,txtSubTotal);
        }

        private void txtMonedero_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender, e, txtMonedero);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender, e, txtDescuento);
        }

        private void txtImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender, e, txtImpuesto);
        }

        private void txtPropina_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender, e, txtPropina);
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender, e, txtCargo);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Close();
        }

        private void GridViewCuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool orden = false;
            if (GridViewCuenta.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewCuenta.Rows[e.RowIndex].Cells[0].Selected)
                {

                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewCuenta.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewCuenta.Rows[i].Cells["check"].Value = false;
                        }
                    }

                    string IDComanda = GridViewCuenta.Rows[e.RowIndex].Cells["IDComanda"].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDCuenta.BuscarComandaCuenta(IDComanda);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDCuenta.Text = IDComanda;
                        txtMesero.Text = _datatable.Rows[0]["Mesero"].ToString();
                        txtNumeroMesa.Text = _datatable.Rows[0]["NumeroMesa"].ToString();
                        txtApertura.Text = _datatable.Rows[0]["fecha"].ToString();
                        labelIDMesero.Text = _datatable.Rows[0]["IDMesoneros"].ToString();
                        labeIDMesa.Text = _datatable.Rows[0]["IDMesas"].ToString();
                        txtSubTotal.Text = _datatable.Rows[0]["TotalPrecio"].ToString();
                        txtTotal.Text = _datatable.Rows[0]["TotalPrecio"].ToString();

                        //BUSCAMOS SI LA COMANDA EXISTE EN LA TABLA DE CUENTA
                        _datatable = CRUDCuenta.BuscarCuenta(IDComanda, status.Abierta);
                        if (_datatable.Rows.Count > 0)
                        {

                            txtFolio.Text = _datatable.Rows[0]["Folio"].ToString();
                            txtOrden.Text = _datatable.Rows[0]["Orden"].ToString();
                            txtCierre.Text = _datatable.Rows[0]["Cierre"].ToString();
                            orden = true;
                            if (txtCierre.Text == "01/01/1950 0:00:00")
                            {
                                txtCierre.Text = string.Empty;
                            }
                            if (txtFolio.Text =="0")
                            {
                                txtFolio.Text = string.Empty;
                            }
                        }
                        else
                        {
                            orden = false;
                            //EN CASO DE NO EXISTIR LO CREAMOS LA CUENTA CON STATUS ABIERTO
                            Cuenta.IDComanda = Convert.ToInt32(IDComanda);
                            Cuenta.Folio = 0;
                            Cuenta.Orden = 0;
                            Cuenta.Status = status.Abierta;
                            Cuenta.IDMesas = Convert.ToInt32(labeIDMesa.Text);
                            Cuenta.IDMesoneros = Convert.ToInt32(labelIDMesero.Text);
                            Cuenta.Apertura = Convert.ToDateTime(txtApertura.Text);
                            Cuenta.SubTotal = Convert.ToDecimal(txtTotal.Text);
                            Cuenta.Total = Convert.ToDecimal(txtTotal.Text);
                            Cuenta.Reserva = string.Empty;
                            Cuenta.Cierre = Convert.ToDateTime("01/01/1950 00:00:00");
                            CRUDCuenta.InsertarCuenta(Cuenta);
                        }
                        BindGridComanda(IDComanda);
                        if (orden==false)
                        {
                            //en caso de que sea true no genera consecutivo, si no que muestra el que tiene en base de datos
                            Orden(IDComanda);
                        }


                    }
                    Controles(true);
                    //btnEditar.Enabled = true;
                    //BtnNuevo.Enabled = false;
                    btnImprimir.Enabled = true;
                }
            }
        }
        private void Folio() {
            //Indica el folio de la cuenta. Es un número consecutivo que se asigna en el momento de imprimir la cuenta.
            int Folio = CRUDCuenta.Folio();
            txtFolio.Text = Convert.ToString(Folio);
        }
        private void Orden(string IDComanda)
        {
           //consecutivo que se reinicia al cerrar el turno
           int consecutivo = CRUDCuenta.Consecutivo(status.Abierta);
           txtOrden.Text = Convert.ToString(consecutivo);

            ////se actualiza el orden nuevo
            Cuenta.IDComanda = Convert.ToInt32(IDComanda);
            Cuenta.Orden = Convert.ToInt32(txtOrden.Text);
            CRUDCuenta.ActualizarOrden(Cuenta);
        }

        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea imprimir la cuenta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCierre.Text = DateTime.Now.ToString();
                Folio();
                Cuenta.Folio = Convert.ToInt32(txtFolio.Text);
                Cuenta.Orden = Convert.ToInt32(txtOrden.Text);
                Cuenta.IDCuenta = Convert.ToInt32(txtIDCuenta.Text);
                Cuenta.Cierre = Convert.ToDateTime(DateTime.Now.ToString());
                Cuenta.Status = status.Cerrado;
                int validar = CRUDCuenta.Actualizar(Cuenta);
            }
        }
    }
}
