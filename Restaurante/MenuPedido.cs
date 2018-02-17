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
using Models;

namespace Restaurante
{
    public partial class MenuPedido : Form
    {

        public MenuPedido()
        {

            InitializeComponent();
        }

        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public CRUDMenu CRUDMenu = new CRUDMenu();
        private Models.Menu Menu = new Models.Menu();

        private void MenuPedido_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewMenu);
            BindGrid();

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            Controles(false);
        }

        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDMenu.ListarMenu();
            if (_ds.Tables.Count > 0)
            {
                GridViewMenu.DataSource = _ds.Tables[0];
                this.GridViewMenu.Columns["IDMenu"].Visible = false;
                this.GridViewMenu.Columns["IDGrupo"].Visible = false;
                this.GridViewMenu.Columns["IDMasterInsumos"].Visible = false;
            }
        }

        private void Controles(bool accion)
        {
            if (accion)
            {
                //txtBuscarInsumo.Enabled = true;
                //txtBuscarMenu.Enabled = true;
                //txtIDGrupo.Enabled = true;
                //txtIDMaesterInsumo.Enabled = true;
                //txtIDMenu.Enabled = true;
                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
            }
            else
            {
                //txtBuscarInsumo.Enabled = false;
                //txtBuscarMenu.Enabled = false;
                //txtIDGrupo.Enabled = false;
                //txtIDMaesterInsumo.Enabled = false;
                //txtIDMenu.Enabled = false;
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
            }
        }

        private void limpiarControles()
        {
            txtBuscarInsumo.Text = "";
            txtBuscarMenu.Text = "";
            txtIDGrupo.Text = "";
            txtIDMaesterInsumo.Text = "";
            txtIDMenu.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
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
            if (txtIDMenu.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                if (txtPrecio.Text != "" && txtNombre.Text != "")
                {
                    //Insumos.IDInsumos = txtIDInsumo.Text;
                    Menu.Nombre = txtNombre.Text;
                    Menu.Precio = Convert.ToDecimal(txtPrecio.Text);

                    int validar = CRUDMenu.InsertarMenu(Menu);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDMenu.Text != "")
            {
                Menu.Nombre = txtNombre.Text;
                Menu.Precio = Convert.ToDecimal(txtPrecio.Text);
                Menu.IDMenu = Convert.ToInt32(txtIDMenu.Text);
                int validar = CRUDMenu.ModificarMenu(Menu);
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
                if (txtIDMenu.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDMenu.EliminarMenu(txtIDMenu.Text);
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

            BtnNuevo.Enabled = true;
            limpiarControles();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
           utilidades.ValidarSoloNumerosDecimales(sender, e,txtPrecio);
        }

        private void GridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewMenu.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewMenu.Rows[e.RowIndex].Cells[0].Selected)
                {

                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewMenu.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewMenu.Rows[i].Cells["check"].Value = false;
                        }
                    }

                    string IDMenu = GridViewMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDMenu.BuscarMenu(IDMenu);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDGrupo.Text = _datatable.Rows[0]["IDGrupo"].ToString();
                        txtIDMaesterInsumo.Text = _datatable.Rows[0]["IDMasterInsumos"].ToString();
                        txtIDMenu.SelectedText = _datatable.Rows[0]["IDMenu"].ToString();
                        txtNombre.Text = _datatable.Rows[0]["Nombre"].ToString();
                        txtPrecio.SelectedText = _datatable.Rows[0]["Precio"].ToString();
                    }
                    Controles(true);
                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    btnEliminar.Enabled = true;
                }
            }
        }
    }
}
