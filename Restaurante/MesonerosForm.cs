using Datos;
using Datos.EF;
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
    public partial class MesonerosForm : Form
    {
        BDRestauranteEntities EF = new BDRestauranteEntities();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public CRUDMesoneros CRUDMesoneros = new CRUDMesoneros();
        private Models.Mesoneros Mesoneros = new Models.Mesoneros();

        public MesonerosForm()
        {
            InitializeComponent();
        }

        private void MesonerosForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(griViewMesoneros);
            utilidades.ConfiguracionGridview(GridViewUsuario);
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtIDMesonero.Enabled = false;
            BindGrid();
            BindGridUsuarios();
        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDMesoneros.ListarMesoneros();
            if (_ds.Tables.Count > 0)
            {
                griViewMesoneros.DataSource = _ds.Tables[0];
            }
        }
        private void BindGridUsuarios()
        {
            GridViewUsuario.DataSource = EF.Usuario.ToList();
            this.GridViewUsuario.Columns["IDUsuario"].Visible = false;
            this.GridViewUsuario.Columns["Login"].Visible = false;
            this.GridViewUsuario.Columns["Password"].Visible = false;
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDMesonero.Text != "")
            {
                MessageBox.Show("DEBE SELECCIONAR UN USUARIO");
            }
            else
            {
                Mesoneros.Nombre = txtNombre.Text;
                Mesoneros.Apellido = txtApellido.Text;
                int validar = CRUDMesoneros.InsertarMesoneros(Mesoneros);
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
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            //BtnNuevo.Enabled = true;
            limpiarControles();
        }
        private void limpiarControles()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtIDMesonero.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDMesonero.Text != "")
            {
                Mesoneros.IDMesoneros = Convert.ToInt32(txtIDMesonero.Text);
                Mesoneros.Nombre = txtNombre.Text;
                Mesoneros.Apellido = txtApellido.Text;

                int validar = CRUDMesoneros.ModificarMesoneros(Mesoneros);
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
                if (txtIDMesonero.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDMesoneros.EliminarMesoneros(txtIDMesonero.Text);
                    limpiarControles();
                    BindGrid();
                    MessageBox.Show("REGISTRO ELIMINADO");
                }
            }
        }

        private void griViewMesoneros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (griViewMesoneros.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (griViewMesoneros.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < griViewMesoneros.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            griViewMesoneros.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    string IDMesoneros = griViewMesoneros.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDMesoneros.BuscarMesoneros(IDMesoneros);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDMesonero.Text = _datatable.Rows[0]["IDMesoneros"].ToString();
                        txtNombre.Text = _datatable.Rows[0]["Nombre"].ToString();
                        txtApellido.Text = _datatable.Rows[0]["Apellido"].ToString();
                    }
                    //btnEditar.Enabled = true;
                    //BtnNuevo.Enabled = false;
                    //BtnGuardar.Enabled = false;
                    //btnEliminar.Enabled = true;
                    //txtNombre.Enabled = true;
                    //txtApellido.Enabled = true;
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewUsuario.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewUsuario.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewUsuario.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewUsuario.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    //GridViewPermisoRol.Rows[e.RowIndex].Cells["IDMaestro"].Value.ToString();
                    //txtIDMesonero.Text =
                    txtNombre.Text = GridViewUsuario.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = GridViewUsuario.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    txtUsuarioID.Text = GridViewUsuario.Rows[e.RowIndex].Cells["IDUsuario"].Value.ToString();
                }
            }
        }
    }
}
