using Datos;
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
    public partial class PromocionesForm : Form
    {
        public PromocionesForm()
        {
            InitializeComponent();
            ComboVisible();
            BindGrid();
        }

        private CRUDPromocion CRUDPromocion = new CRUDPromocion();
        private Models.TipoDescuento TipoDescuento = new Models.TipoDescuento();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();

        private void PromocionesForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(griViewTipoDescuento);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
            comboTipo.Enabled = false;
        }

        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDTipoDescuento.ListarTipoDescuento();
            if (_ds.Tables.Count > 0)
            {
                griViewTipoDescuento.DataSource = _ds.Tables[0];
                this.griViewTipoDescuento.Columns["IDTipoDescuento"].Visible = false;
                this.griViewTipoDescuento.Columns["Visible"].Visible = false;
            }
        }
        private void ComboVisible()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Value");
            dataTable.Columns.Add("Text");
            dataTable.Rows.Add(1, "Si");
            dataTable.Rows.Add(0, "No");

            comboVisible.DataSource = dataTable;
            comboVisible.DisplayMember = "Text";
            comboVisible.ValueMember = "Value";

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            txtDescripcion.Enabled = true;
            comboVisible.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDTipoDescuento.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                TipoDescuento.Descripcion = txtDescripcion.Text;
                TipoDescuento.Descuento = Convert.ToDecimal(txtDescuento.Text);
                TipoDescuento.Visible = comboVisible.SelectedValue.ToString() == "1" ? true : false;
                int validar = CRUDTipoDescuento.InsertarTipoDescuento(TipoDescuento);

                if (validar == 1)
                {
                    MessageBox.Show("Registro agregado");
                    BindGrid();
                    limpiarControles();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDTipoDescuento.Text != "")
            {
                TipoDescuento.IDTipoDescuento = Convert.ToInt32(txtIDTipoDescuento.Text);
                TipoDescuento.Descripcion = txtDescripcion.Text;
                TipoDescuento.Descuento = Convert.ToDecimal(txtDescuento.Text);
                TipoDescuento.Visible = comboVisible.SelectedValue.ToString() == "Si" ? true : false;
                int validar = CRUDTipoDescuento.ModificarTipoDescuento(TipoDescuento);
                //string IDSubGrupo = txtIDTipoDescuento.Text;
                //string IDGrupo = comboVisible.SelectedValue.ToString();
                //se actualiza el masterGrupo
                //CRUDTipoDescuento.ActualizarSubGrupoMaster(IDGrupo, IDSubGrupo);
                if (validar != 0)
                {
                    BindGrid();
                    MessageBox.Show("REGISTRO MODIFICADO");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la Lista");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtIDTipoDescuento.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDTipoDescuento.EliminarTipoDescuento(txtIDTipoDescuento.Text);

                    string IDSubGrupo = txtIDTipoDescuento.Text;
                    string IDGrupo = comboVisible.SelectedValue.ToString();
                    //se elimina el masterGrupo
                    //CRUDTipoDescuento.EliminarSubGrupoMaster(IDSubGrupo);
                    limpiarControles();
                    BindGrid();
                    MessageBox.Show("REGISTRO ELIMINADO");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
            BtnNuevo.Enabled = true;
            limpiarControles();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiarControles()
        {
            txtDescuento.Text = "";
            txtDescripcion.Text = "";
            txtIDTipoDescuento.Text = "";
            comboVisible.SelectedIndex = -1;
        }
    }
}
