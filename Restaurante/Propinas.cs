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
    public partial class Propinas : Form
    {
        public CuentaForm _CuentaForm;
        public Propinas()
        {
            InitializeComponent();
        }
        public Propinas(CuentaForm CuentaForm)
        {
            this._CuentaForm = CuentaForm;
            InitializeComponent();
        }
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();

        private void Propinas_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);

            #region SE OBTIENE LOS VALORES DEL FORMULARIO DE CUENTA
            CuentaForm CuentaForm = new CuentaForm();
            txtSubTotal.Text = Convert.ToString(CuentaForm._SubTotal);
            //txtConsumo.Text = Convert.ToString(CuentaForm._SetTotal);

            //txtTotalMN.Text = Convert.ToString(CuentaForm._SetTotal);
            //txtCambioMN.Text = Convert.ToString(CuentaForm._SetPropina);
            //_IDCuenta = CuentaForm._IDCuenta;

            #endregion
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*OJO DE ESTA FORMA SE PUEDE ENVIAR VARIABLES DE UN FORMAULARIO A OTRO, LLAMANDO UN METODO ESPECIFICO*/
            if (txtPropinaCantidad.Text != "" && txtPropinaPorcentaje.Text !="")
            {
                MessageBox.Show("SOLO SE PUEDE SELECCIONAR UNA OPCION");
            }
            else
            {
                string propina = "";
                bool porcentaje = false;
                if (txtPropinaCantidad.Text != "")
                {
                    propina = txtPropinaCantidad.Text;
                }
                if (txtPropinaPorcentaje.Text !="")
                {
                    propina = txtPropinaPorcentaje.Text;
                    porcentaje = true;
                }
                CuentaForm form2 = new CuentaForm();

                form2.propina(propina, porcentaje);
                this.Close();
            }

        }
    }
}
