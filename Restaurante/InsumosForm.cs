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
    public partial class InsumosForm : Form
    {
        public CRUDInsumos CRUDInsumos = new CRUDInsumos();
        private Insumos Insumos = new Insumos();
        public InsumosForm()
        {
            InitializeComponent();
        }

        private void InsumosForm_Load(object sender, EventArgs e)
        {
            insertarCheckGrid();
            BindGrid();

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            Controles(false);

            comboInventariable.Items.Add("Si");
            comboInventariable.Items.Add("No");
            comboInventariable.SelectedIndex = 0;
            //UNIDAD DE MEDIDA
            ComboUnidadMedida();
            //GRUPOS
            ComboGrupos();
        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDInsumos.ListarInsumo();
            if (_ds.Tables.Count > 0)
            {
                griViewInsumos.DataSource = _ds.Tables[0];
            }


        }
        private void insertarCheckGrid() {
            ////CODIGO PARA INSERTAR EL CHECKBOX
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Seleccionar";
            checkBoxColumn.Width = 100;
            checkBoxColumn.Name = "check";

            griViewInsumos.Columns.Insert(0, checkBoxColumn);
        }
        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (this.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar =='.' || e.KeyChar =='\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtUltimoCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender,e);
        }

        private void txtCostoPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
        }

        private void txtCostoImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
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
            if (txtIDInsumo.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                if (txtCostoPromedio.Text !="" && txtUltimoCosto.Text != "" && txtCostoImpuesto.Text !="" && txtIva.Text !="")
                {
                    //Insumos.IDInsumos = txtIDInsumo.Text;
                    Insumos.IDGrupos = Convert.ToInt32(comboIDGrupo.SelectedValue.ToString());
                    Insumos.Descripcion = txtDescripcionInsumo.Text;
                    Insumos.UnidadMedida = comboUnidadMedida.Text;
                    Insumos.UltimoCosto = Convert.ToDouble(txtUltimoCosto.Text);
                    Insumos.CostoPromedio = Convert.ToDouble(txtCostoPromedio.Text);
                    Insumos.CostoImpuesto = Convert.ToDouble(txtCostoImpuesto.Text);
                    Insumos.IVA = Convert.ToDouble(txtIva.Text);
                    Insumos.Inventariable = comboInventariable.Text;

                    int validar = CRUDInsumos.InsertarInsumos(Insumos);
                    if (validar == 1)
                    {
                        MessageBox.Show("Registro agregado");
                        BindGrid();
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
        private void Controles(bool accion) {
            if (accion)
            {
                //txtIDInsumo.Enabled = true;
                txtUltimoCosto.Enabled = true;
                txtDescripcionInsumo.Enabled = true;
                comboInventariable.Enabled = true;
                txtCostoPromedio.Enabled = true;
                comboUnidadMedida.Enabled = true;
                comboIDGrupo.Enabled = true;
                txtCostoImpuesto.Enabled = true;
                txtIva.Enabled = true;
            }
            else
            {
                //txtIDInsumo.Enabled = false;
                txtUltimoCosto.Enabled = false;
                txtDescripcionInsumo.Enabled = false;
                comboInventariable.Enabled = false;
                txtCostoPromedio.Enabled = false;
                comboUnidadMedida.Enabled = false;
                comboIDGrupo.Enabled = false;
                txtCostoImpuesto.Enabled = false;
                txtIva.Enabled = false;
            }

        }
        private void ComboGrupos() {
            DataTable dtGrupos = new DataTable();
            dtGrupos = CRUDInsumos.GruposComboBox();
            comboIDGrupoBusqueda.ValueMember = "IDGrupo";
            comboIDGrupoBusqueda.DisplayMember = "Descripcion";
            comboIDGrupoBusqueda.DataSource = dtGrupos;

            comboIDGrupo.ValueMember = "IDGrupo";
            comboIDGrupo.DisplayMember = "Descripcion";
            comboIDGrupo.DataSource = dtGrupos;
        }
        private void ComboUnidadMedida() {
            DataTable dt = new DataTable();
            dt = CRUDInsumos.UnidadMedida();
            comboUnidadMedida.ValueMember = "IDUnidad";
            comboUnidadMedida.DisplayMember = "Descripcion";
            comboUnidadMedida.DataSource = dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDInsumo.Text != "")
            {
                Insumos.IDInsumos = Convert.ToInt32(txtIDInsumo.Text);
                Insumos.IDGrupos = Convert.ToInt32(comboIDGrupo.SelectedValue.ToString());
                Insumos.Descripcion = txtDescripcionInsumo.Text;
                Insumos.UnidadMedida = comboUnidadMedida.SelectedText;
                Insumos.UltimoCosto = Convert.ToDouble(txtUltimoCosto.Text);
                Insumos.CostoPromedio = Convert.ToDouble(txtCostoPromedio.Text);
                Insumos.CostoImpuesto = Convert.ToDouble(txtCostoImpuesto.Text);
                Insumos.IVA = Convert.ToDouble(txtIva.Text);
                Insumos.Inventariable = comboInventariable.SelectedText;

                int validar = CRUDInsumos.ModificarInsumo(Insumos);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            BtnNuevo.Enabled = true;
            limpiarControles();
        }
        private void limpiarControles() {
            txtUltimoCosto.Text = "";
            txtDescripcionInsumo.Text = "";
            comboInventariable.SelectedIndex = -1;
            txtCostoPromedio.Text = "";
            comboUnidadMedida.SelectedIndex = -1;
            comboIDGrupo.SelectedIndex = -1;
            txtCostoImpuesto.Text = "";
            txtIva.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            BtnNuevo.Enabled = true;
            limpiarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtIDInsumo.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDInsumos.EliminarInsumo(txtIDInsumo.Text);
                    limpiarControles();
                    BindGrid();
                    MessageBox.Show("REGISTRO ELIMINADO");
                }
            }
        }

        private void griViewInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (griViewInsumos.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (griViewInsumos.Rows[e.RowIndex].Cells[0].Selected)
                {

                    int row_index = e.RowIndex;
                    for (int i = 0; i < griViewInsumos.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            griViewInsumos.Rows[i].Cells["check"].Value = false;
                        }

                    }

                    string IDInsumos = griViewInsumos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDInsumos.BuscarInsumo(IDInsumos);
                    if (_datatable.Rows.Count > 0)
                    {


                        txtUltimoCosto.Text = _datatable.Rows[0]["UltimoCosto"].ToString();
                        txtDescripcionInsumo.Text = _datatable.Rows[0]["Descripcion"].ToString();
                        comboInventariable.SelectedText = _datatable.Rows[0]["Inventariable"].ToString();
                        txtCostoPromedio.Text = _datatable.Rows[0]["CostoPromedio"].ToString();
                        comboUnidadMedida.SelectedText = _datatable.Rows[0]["UnidadMedida"].ToString();
                        comboIDGrupo.SelectedText = _datatable.Rows[0]["IDGrupos"].ToString();
                        txtCostoImpuesto.Text = _datatable.Rows[0]["CostoImpuesto"].ToString();
                        txtIva.Text = _datatable.Rows[0]["IVA"].ToString();


                    }

                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    btnEliminar.Enabled = true;
                }
                else
                {

                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Close();
        }

        private void comboIDGrupoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

            string IDGrupos = comboIDGrupoBusqueda.SelectedValue.ToString();
            DataSet _ds = new DataSet();
            _ds = CRUDInsumos.BuscarInsumoByGrupo(IDGrupos);
            if (_ds.Tables.Count > 0)
            {
                griViewInsumos.DataSource = _ds.Tables[0];
            }
        }
    }
}
