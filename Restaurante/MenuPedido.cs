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
using System.Globalization;

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
        private MasterInsumos MasterInsumos = new MasterInsumos();
        private int IntIDMenu = 0;
        private void MenuPedido_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewMenu);
            utilidades.ConfiguracionGridview(GridViewInsumo);
            utilidades.ConfiguracionGridview(GridViewMasterInsumo);

            BindGrid();
            BindGridInsumos();



            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            ComboGrupos(comboBuscarInsumo);
            ComboGrupos(comboGrupo);
            //ComboGrupos(comboBuscarMenu);

            Controles(false);
        }

        private void BindGrid()
        {
            //METODO PARA CARGAR LOS REGISTROS DE LA TABLA MENU
            DataSet _ds = new DataSet();
            _ds = CRUDMenu.ListarMenu();
            if (_ds.Tables.Count > 0)
            {
                GridViewMenu.DataSource = _ds.Tables[0];
                this.GridViewMenu.Columns["IDMenu"].Visible = false;
                this.GridViewMenu.Columns["IDGrupo"].Visible = false;
            }
        }
        private void BindGridInsumos()
        {
            //METODO QUE CARGA LOS INSUMOS
            DataSet _ds = new DataSet();
            _ds = CRUDMenu.ListarInsumo();
            if (_ds.Tables.Count > 0)
            {
                GridViewInsumo.DataSource = _ds.Tables[0];
                this.GridViewInsumo.Columns["IDGrupos"].Visible = false;
            }
        }
        private void BindGridMasterInsumo()
        {
            //METODO QUE CARGA LOS INSUMOS AGREGADOS A UN MENU
            DataSet _ds = new DataSet();
            _ds = CRUDMenu.ListarMasterInsumo();
            if (_ds.Tables.Count > 0)
            {
                GridViewMasterInsumo.DataSource = _ds.Tables[0];
                this.GridViewMasterInsumo.Columns["IDMasterInsumos"].Visible = false;
                this.GridViewMasterInsumo.Columns["IDInsumos"].Visible = false;
                this.GridViewMasterInsumo.Columns["IDMenu"].Visible = false;
            }
        }
        private void BindGridMasterInsumoByIDMenu(string IDMenu)
        {
            //METODOS QUE BUSCA LOS INSUMOS AGREGOS A UN MENU USANDO EL IDMENU COMO CONDICIONAL
            DataSet _ds = new DataSet();
            _ds = CRUDMenu.ListarMasterInsumoByIDmenu(IDMenu);
            if (_ds.Tables.Count > 0)
            {
                GridViewMasterInsumo.DataSource = _ds.Tables[0];
                this.GridViewMasterInsumo.Columns["IDMasterInsumos"].Visible = false;
                this.GridViewMasterInsumo.Columns["IDInsumos"].Visible = false;
                this.GridViewMasterInsumo.Columns["IDMenu"].Visible = false;
            }
        }
        private void BindGridByCombo(ComboBox combo, DataGridView GridView)
        {
            //PERMITE HACER LA BUSQUEDA EN EL GRID POR GRUPOS
            string IDGrupos = combo.SelectedValue.ToString();
            DataSet _ds = new DataSet();
            _ds = CRUDMenu.BuscarInsumoByGrupo(IDGrupos);
            if (_ds.Tables.Count > 0)
            {
                GridView.DataSource = _ds.Tables[0];
            }
        }
        private void ComboGrupos(ComboBox combo)
        {
            DataTable dtGrupos = new DataTable();
            dtGrupos = CRUDMenu.GruposComboBox();
            combo.ValueMember = "IDGrupo";
            combo.DisplayMember = "Descripcion";
            combo.DataSource = dtGrupos;
        }
        private void Controles(bool accion)
        {
            if (accion)
            {
                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
            }
        }

        private void limpiarControles()
        {
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

            int validar = CRUDMenu.InsertarMenu(Menu);
            DataTable _datatable = new DataTable();
            _datatable = CRUDMenu.UltimoIDMenu();
            IntIDMenu = Convert.ToInt32(_datatable.Rows[0]["IDMenu"].ToString());
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
                    Menu.Nombre = txtNombre.Text;
                    Menu.Precio = Convert.ToDecimal(txtPrecio.Text);

                    int validar = CRUDMenu.InsertarMenu(Menu);
                    if (validar == 1)
                    {
                        DataTable _datatable = new DataTable();
                        _datatable = CRUDMenu.UltimoIDMenu();
                        string IDMenu = _datatable.Rows[0]["IDMenu"].ToString();
                        CRUDMenu.InsertarMasterInsumos(IDMenu, MasterInsumos);
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
            Controles(false);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            CRUDMenu.EliminarMasterInsumosNotSave();
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
                        limpiarControles();
                        txtIDGrupo.Text = _datatable.Rows[0]["IDGrupo"].ToString();
                        txtIDMenu.Text = _datatable.Rows[0]["IDMenu"].ToString();
                        txtNombre.Text = _datatable.Rows[0]["Nombre"].ToString();
                        txtPrecio.SelectedText = _datatable.Rows[0]["Precio"].ToString();
                    }

                    BindGridMasterInsumoByIDMenu(IDMenu);

                    Controles(true);
                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void comboBuscarInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridByCombo(comboBuscarInsumo, GridViewInsumo);
        }

        private void comboBuscarMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridByCombo(comboBuscarMenu,GridViewMenu);
        }

        private void GridViewInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewInsumo.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewInsumo.Rows[e.RowIndex].Cells[0].Selected)
                {

                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewInsumo.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewInsumo.Rows[i].Cells["check"].Value = false;
                        }
                    }

                    string IDInsumo = GridViewInsumo.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDMenu.BuscarInsumo(IDInsumo);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtHiddenIDInsumo.Text = _datatable.Rows[0]["IDInsumos"].ToString();
                        txtDescripcionInsumo.Text = _datatable.Rows[0]["Descripcion"].ToString();
                    }

                }
            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            if (txtHiddenIDInsumo.Text == "")
            {
                MessageBox.Show("DEBE SELECCIONAR UN INSUMO");
            }
            else
            {
                if (txtCantidadInsumo.Text != "")
                {
                    MasterInsumos.IDInsumos = Convert.ToInt32(txtHiddenIDInsumo.Text);
                    MasterInsumos.Cantidad = Convert.ToDecimal(txtCantidadInsumo.Text);
                    MasterInsumos.IDMenu = IntIDMenu;
                    int validar = CRUDMenu.InsertarTemporalMasterInsumos(MasterInsumos);
                    if (validar == 1)
                    {
                        MessageBox.Show("Insumo agregado");
                        //BindGridMasterInsumo();
                        BindGridMasterInsumoByIDMenu(Convert.ToString(IntIDMenu));

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INDICAR UNA CANTIDAD");
                }
            }
        }

        private void GridViewMasterInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewMasterInsumo.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewMasterInsumo.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewMasterInsumo.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewMasterInsumo.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    txtHiddenIDMasterInsumo.Text = GridViewMasterInsumo.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCantidadInsumo.Text = GridViewMasterInsumo.Rows[0].Cells[4].Value.ToString();
                    txtDescripcionInsumo.Text = GridViewMasterInsumo.Rows[0].Cells[5].Value.ToString();
                }
            }
        }

        private void btnEliminarInsumo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtHiddenIDMasterInsumo.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDMenu.EliminarMasterInsumos(txtHiddenIDMasterInsumo.Text);
                    txtHiddenIDInsumo.Text = "";
                    txtHiddenIDMasterInsumo.Text = "";
                    txtDescripcionInsumo.Text = "";
                    BindGridMasterInsumoByIDMenu(txtIDMenu.Text);
                    MessageBox.Show("INSUMO ELIMINADO");
                }
            }
        }

        private void txtCantidadInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumeros(sender, e, txtCantidadInsumo);
        }
    }
}
