using Datos;
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
    public partial class PagarCuentaForm : Form
    {
        public PagarCuentaForm()
        {
            InitializeComponent();
        }
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        private Utilidades.Status status = new Utilidades.Status();
        private Utilidades.FormaPago formaPago = new Utilidades.FormaPago();
        public CRUDCuenta CRUDCuenta = new CRUDCuenta();
        private Models.Cuenta Cuenta = new Models.Cuenta();

        private static int _IDCuenta = 0;
        private decimal _descuento = 0;
        private decimal _propina = 0;
        private decimal _total = 0;
        private void PagarCuentaForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridviewSinSeleccionar(gridViewPago);

            #region SE OBTIENE LOS VALORES DEL FORMULARIO DE CUENTA
            CuentaForm CuentaForm = new CuentaForm();
            txtPropina.Text =Convert.ToString(CuentaForm._SetPropina);
            txtConsumo.Text = Convert.ToString(CuentaForm._SetTotal);

            txtTotalMN.Text = Convert.ToString(CuentaForm._SetTotal);
            txtCambioMN.Text = Convert.ToString(CuentaForm._SetPropina);

            _total = CuentaForm._SetTotal;
            _IDCuenta = CuentaForm._IDCuenta;
            _descuento = CuentaForm._SetDescuento;
            _propina = CuentaForm._SetPropina;

            #endregion
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            lblFormaPago.Text = formaPago.Efectivo;
            binGriew(formaPago.Efectivo);
        }

        private void binGriew(string pago) {
            //descripcion importe propina importe total

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Importe", typeof(string)));
            dt.Columns.Add(new DataColumn("Propina", typeof(string)));
            dt.Columns.Add(new DataColumn("Importe total", typeof(string)));
            decimal totalImporte = Convert.ToDecimal(txtConsumo.Text + txtPropina.Text);
            dt.Rows.Add(pago, txtConsumo.Text, txtPropina.Text, totalImporte);

            gridViewPago.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PagarCuentaForm PagarCuentaForm = new PagarCuentaForm();
            this.Close();
        }

        private void btnMasterCard_Click(object sender, EventArgs e)
        {
            lblFormaPago.Text = formaPago.MasterCard;
            binGriew(formaPago.MasterCard);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea pagar la cuenta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cuenta.Status = status.Cerrado;
                Cuenta.IDCuenta = _IDCuenta;
                Cuenta.FormaPago = lblFormaPago.Text;
                Cuenta.Descuento = _descuento;
                Cuenta.Propina = _propina;
                Cuenta.Total = _total;

                int validar = CRUDCuenta.ActualizarStatusCuenta(Cuenta);
                if (validar == 1)
                {
                    MessageBox.Show("Cuenta Pagada");
                }
            }
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            lblFormaPago.Text = formaPago.Visa;
            binGriew(formaPago.Visa);
        }

        private void btnCheque_Click(object sender, EventArgs e)
        {
            lblFormaPago.Text = formaPago.Cheque;
            binGriew(formaPago.Cheque);
        }
    }
}
