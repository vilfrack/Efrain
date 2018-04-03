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
    public partial class TipoDescuentoForm : Form
    {
        private CRUDTipoDescuento CRUDTipoDescuento = new CRUDTipoDescuento();
        private Models.TipoDescuento TipoDescuento = new Models.TipoDescuento();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();

        public TipoDescuentoForm()
        {
            InitializeComponent();
            ComboVisible();
            BindGrid();
        }

        private void TipoDescuentoForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(griViewTipoDescuento);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
            comboVisible.Enabled = false;
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
                TipoDescuento.Visible = comboVisible.SelectedValue.ToString() =="1"?true:false;
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

        private void griViewTipoDescuento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (griViewTipoDescuento.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (griViewTipoDescuento.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < griViewTipoDescuento.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            griViewTipoDescuento.Rows[i].Cells["check"].Value = false;
                        }
                    }

                    string IDTipoDescuento = griViewTipoDescuento.Rows[e.RowIndex].Cells["IDTipoDescuento"].Value.ToString();

                    DataTable _datatable = new DataTable();
                    _datatable = CRUDTipoDescuento.BuscarTipoDescuento(IDTipoDescuento);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDTipoDescuento.Text = _datatable.Rows[0]["IDTipoDescuento"].ToString();
                        txtDescripcion.Text = _datatable.Rows[0]["Descripcion"].ToString();
                        txtDescuento.Text = _datatable.Rows[0]["Descuento"].ToString();
                        string sVisible = _datatable.Rows[0]["Visible"].ToString();
                        if (sVisible == "True")
                        {
                            comboVisible.SelectedValue = 1;
                        }
                        else
                        {
                            comboVisible.SelectedValue = 0;
                        }

                    }
                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    BtnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    comboVisible.Enabled = true;
                }
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender, e, txtDescuento);
        }
    }
}
