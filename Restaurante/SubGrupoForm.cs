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
    public partial class SubGrupoForm : Form
    {
        private CRUDSubGrupos CRUDSubGrupos = new CRUDSubGrupos();
        private Models.SubGrupos SubGrupos = new Models.SubGrupos();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();

        public SubGrupoForm()
        {
            InitializeComponent();
            ComboGrupo();
            BindGrid();
        }

        private void SubGrupoForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(griViewSubGrupos);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
            comboGrupo.Enabled = false;
        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDSubGrupos.ListarSubGrupo();
            if (_ds.Tables.Count > 0)
            {
                griViewSubGrupos.DataSource = _ds.Tables[0];
            }
        }
        private void ComboGrupo() {
            DataTable dt = new DataTable();
            dt = CRUDSubGrupos.GruposComboBox();
            comboGrupo.ValueMember = "IDGrupo";
            comboGrupo.DisplayMember = "Descripcion";
            comboGrupo.DataSource = dt;
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            txtDescripcion.Enabled = true;
            comboGrupo.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (txtIDSubGrupo.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                SubGrupos.Descripcion = txtDescripcion.Text;
                int validar = CRUDSubGrupos.InsertarSubGrupo(SubGrupos);
                //se obtiene el ID del SubGrupo recien insertado
                DataTable _datatable = new DataTable();
                _datatable = CRUDSubGrupos.UltimoIDSubGrupo();
                string IDSubGrupo = _datatable.Rows[0]["IDSubGrupo"].ToString();
                //se obtiene el id del grupo
                string IDGrupo = comboGrupo.SelectedValue.ToString();
                // se insertar en el mastergrupoSubGrupo
                CRUDSubGrupos.InsertarSubGrupoMaster(IDGrupo, IDSubGrupo);
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
        private void limpiarControles()
        {
            txtDescripcion.Text = "";
            txtIDSubGrupo.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDSubGrupo.Text != "")
            {
                SubGrupos.IDSubGrupo = Convert.ToInt32(txtIDSubGrupo.Text);
                SubGrupos.Descripcion = txtDescripcion.Text;

                int validar = CRUDSubGrupos.ModificarSubGrupo(SubGrupos);
                string IDSubGrupo = txtIDSubGrupo.Text;
                string IDGrupo = comboGrupo.SelectedValue.ToString();
                //se actualiza el masterGrupo
                CRUDSubGrupos.ActualizarSubGrupoMaster(IDGrupo, IDSubGrupo);
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
                if (txtIDSubGrupo.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDSubGrupos.EliminarSubGrupo(txtIDSubGrupo.Text);

                    string IDSubGrupo = txtIDSubGrupo.Text;
                    string IDGrupo = comboGrupo.SelectedValue.ToString();
                    //se elimina el masterGrupo
                    CRUDSubGrupos.EliminarSubGrupoMaster(IDSubGrupo);
                    limpiarControles();
                    BindGrid();
                    MessageBox.Show("REGISTRO ELIMINADO");
                }
            }
        }

        private void griViewSubGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (griViewSubGrupos.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (griViewSubGrupos.Rows[e.RowIndex].Cells[0].Selected)
                {
                    string IDSubGrupo = griViewSubGrupos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDSubGrupos.BuscarSubGrupo(IDSubGrupo);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDSubGrupo.Text = _datatable.Rows[0]["IDSubGrupo"].ToString();
                        txtDescripcion.Text = _datatable.Rows[0]["Descripcion"].ToString();
                    }
                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    BtnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    txtDescripcion.Enabled = true;
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
