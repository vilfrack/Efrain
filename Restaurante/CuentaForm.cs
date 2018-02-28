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
    public partial class CuentaForm : Form
    {
        public CuentaForm()
        {
            InitializeComponent();
        }

        public CRUDCuenta CRUDCuenta = new CRUDCuenta();
        private Cuenta Cuenta = new Cuenta();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();

        private void CuentaForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionGridview(GridViewOrden);
            utilidades.ConfiguracionGridview(GridViewCuenta);
            utilidades.ConfiguracionFormulario(this);
            BindGrid();

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

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
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            Controles(true);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDCuenta.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                if (txtMesero.Text != "" && txtNumeroMesa.Text != "")
                {
                    //Insumos.IDInsumos = txtIDInsumo.Text;
                    Cuenta.IDMesoneros =Convert.ToInt32(labelIDMesero.Text);
                    Cuenta.Reserva = txtReserva.Text;
                    Cuenta.IDMesas = Convert.ToInt32(labelNumeroMesa.Text);
                    Cuenta.Folio = txtFolio.Text;
                    Cuenta.Comisionista = txtComisionista.Text;
                    Cuenta.Orden = txtOrden.Text;
                    //Cuenta.IDCliente = txtNomCliente.Text;
                    Cuenta.Apertura = Convert.ToDateTime(txtApertura.Text);

                    int validar = CRUDCuenta.InsertarCuenta(Cuenta);
                    if (validar == 1)
                    {
                        MessageBox.Show("Registro agregado");
                        BindGridByCombo();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("LOS CAMPOS DE COSTO PROMEDIO, COSTO IMPUESTO Y ULTIMO COSTO NO PUEDEN QUEDAR VACIOS");
                }


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (txtIDInsumo.Text != "")
            //{
            //    Insumos.IDInsumos = Convert.ToInt32(txtIDInsumo.Text);
            //    Insumos.IDGrupos = Convert.ToInt32(comboIDGrupo.SelectedValue.ToString());
            //    Insumos.Descripcion = txtDescripcionInsumo.Text;
            //    Insumos.UnidadMedida = comboUnidadMedida.SelectedText;
            //    Insumos.UltimoCosto = Convert.ToDouble(txtUltimoCosto.Text);
            //    Insumos.CostoPromedio = Convert.ToDouble(txtCostoPromedio.Text);
            //    Insumos.CostoImpuesto = Convert.ToDouble(txtCostoImpuesto.Text);
            //    Insumos.IVA = Convert.ToDouble(txtIva.Text);
            //    Insumos.Inventariable = comboInventariable.SelectedText;

            //    int validar = CRUDInsumos.ModificarInsumo(Insumos);
            //    if (validar != 0)
            //    {
            //        BindGridByCombo();
            //        MessageBox.Show("REGISTRO MODIFICADO");
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar un registro de la Lista");
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Seguro desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    if (txtIDInsumo.Text == "")
            //    {
            //        MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
            //    }
            //    else
            //    {
            //        CRUDInsumos.EliminarInsumo(txtIDInsumo.Text);
            //        limpiarControles();
            //        BindGridByCombo();
            //        MessageBox.Show("REGISTRO ELIMINADO");
            //    }
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            BtnNuevo.Enabled = true;
            //limpiarControles();
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
    }
}
