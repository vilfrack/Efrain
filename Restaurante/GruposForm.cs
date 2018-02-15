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
    public partial class GruposForm : Form
    {
        private CRUDGrupos CRUDGrupos = new CRUDGrupos();
        private Grupos Grupos = new Grupos();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();

        public GruposForm()
        {
            InitializeComponent();
            BindGrid();
        }

        private void GruposForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionGridview(griViewGrupos);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDGrupos.ListarGrupo();
            if (_ds.Tables.Count > 0)
            {
                griViewGrupos.DataSource = _ds.Tables[0];
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDGrupo.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                Grupos.Descripcion = txtDescripcion.Text;
                int validar = CRUDGrupos.InsertarGrupo(Grupos);
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
        private void limpiarControles() {
            txtDescripcion.Text = "";
            txtIDGrupo.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDGrupo.Text != "")
            {
                Grupos.IDGrupo = Convert.ToInt32(txtIDGrupo.Text);
                Grupos.Descripcion = txtDescripcion.Text;

                int validar = CRUDGrupos.ModificarGrupo(Grupos);
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
                if (txtIDGrupo.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDGrupos.EliminarGrupo(txtIDGrupo.Text);
                    limpiarControles();
                    BindGrid();
                    MessageBox.Show("REGISTRO ELIMINADO");
                }
            }
        }

        private void griViewGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (griViewGrupos.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (griViewGrupos.Rows[e.RowIndex].Cells[0].Selected)
                {
                    string IDGrupo = griViewGrupos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDGrupos.BuscarGrupo(IDGrupo);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDGrupo.Text = _datatable.Rows[0]["IDGrupo"].ToString();
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
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Close();
        }
    }
}
