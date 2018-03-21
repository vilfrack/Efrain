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
    public partial class ComandaDetalleForm : Form
    {
        public CuentaForm _CuentaForm;
        public ComandaDetalleForm()
        {
            InitializeComponent();

        }
        //se crea dos contructores de ComandaDetalleForm, el vacio es cuado se llamada del menu principal comanda y luego ComandaDetalleForm,
        //el otro cuando se llama de CuentaForm y se necesita refrescar el gridview de CuentaForm al dar click en agregar cuenta
        public ComandaDetalleForm(CuentaForm CuentaForm)
        {
            InitializeComponent();
            this._CuentaForm = CuentaForm;
        }

        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public CRUDMenu CRUDMenu = new CRUDMenu();
        public CRUDInsumos CRUDInsumos = new CRUDInsumos();
        public CRUDComanda CRUDComanda = new CRUDComanda();
        public Models.MasterComanda MasterComanda = new Models.MasterComanda();
        public Models.Comanda Comanda = new Models.Comanda();
        private int IDMesas = 0;
        private int NumeroMesa = 0;
        private int CantidadPersona = 0;
        private int IDComanda = 0;

        private void ComandaDetalleForm_Load(object sender, EventArgs e)
        {

            #region SE CREAN LAS CONFIGURACIONES DEL FORMULARIO Y DE LOS GRID
                utilidades.ConfiguracionFormulario(this);
                utilidades.ConfiguracionGridview(GridViewMenu);
                utilidades.ConfiguracionGridview(GridViewComanda);
            #endregion

            ComandaForm ComandaForm = new ComandaForm();
            ComboGrupos();
            ComboMesonero();
            string IDGrupos = comboGrupoBusqueda.SelectedValue.ToString();
            BindGrid(IDGrupos);

            #region SE OBTIENE LOS VALORES DEL FORMULARIO ANTERIOR
                IDMesas = ComandaForm.SetIDMesas;
                NumeroMesa = ComandaForm.SetNumeroMesa;
                CantidadPersona = ComandaForm.SetCantidadPersona;
                labelNumeroMesa.Text = NumeroMesa.ToString();
            #endregion



            //SE CREA LA COMANDA PARA OBTENER SU ID
            Comanda.IDMesas = IDMesas;
            Comanda.Status = "ABIERTA";
            Comanda.Fecha = DateTime.Now;

            DataTable _datatable = new DataTable();
            //VALIDAMOS SI LA COMANDA EXISTE POR MEDIO DEL ID DE MESA MAS EL STATUS
            _datatable = CRUDComanda.ComandaAbierta(Comanda);
            int existe = Convert.ToInt32(_datatable.Rows[0]["existe"].ToString());
            if (existe==0)
            {
                CRUDComanda.InsertarComanda(Comanda);
                //SE OBTIENE EL ID DE LA COMANDA CREADA
                //DataTable _datatable = new DataTable();
                _datatable = CRUDComanda.UltimoIDComanda(Comanda);
                IDComanda = Convert.ToInt32(_datatable.Rows[0]["IDComanda"].ToString());
            }
            else
            {
                //en caso contrario se busca la comanda por medio del id de mesa y el status
                _datatable = CRUDComanda.BuscarComanda(Comanda);
                IDComanda = Convert.ToInt32(_datatable.Rows[0]["IDComanda"].ToString());
            }

        }

        private void BindGrid(string IDGrupos)
        {

            DataSet _ds = new DataSet();
            _ds = CRUDMenu.BuscarMenuByGrupo(IDGrupos);
            if (_ds.Tables.Count > 0)
            {
                GridViewMenu.DataSource = _ds.Tables[0];
                this.GridViewMenu.Columns["IDMenu"].Visible = false;
                this.GridViewMenu.Columns["IDGrupo"].Visible = false;
            }
        }

        private void BindGridPlatos()
        {
            DataSet _ds = new DataSet();
            DataTable _datatable = new DataTable();
            _ds = CRUDComanda.ListarMasterComanda(IDComanda);
            if (_ds.Tables.Count > 0)
            {
                GridViewComanda.DataSource = _ds.Tables[0];
                this.GridViewComanda.Columns["IDMenu"].Visible = false;
                this.GridViewComanda.Columns["IDComanda"].Visible = false;
                this.GridViewComanda.Columns["IDMasterComanda"].Visible = false;
            }
        }

        private void ComboGrupos()
        {
            DataTable dtGrupos = new DataTable();
            dtGrupos = CRUDInsumos.GruposComboBox();
            comboGrupoBusqueda.ValueMember = "IDGrupo";
            comboGrupoBusqueda.DisplayMember = "Descripcion";
            comboGrupoBusqueda.DataSource = dtGrupos;
        }
        private void ComboMesonero()
        {
            DataSet dsMesoneros = new DataSet();
            DataTable dtMesoneros = new DataTable();
            //dsMesoneros = CRUDComanda.MesonerosComboBox();
            dtMesoneros = CRUDComanda.MesonerosComboBox();


            comboMesonero.ValueMember = "IDMesoneros";
            comboMesonero.DisplayMember = "Nombre";
            comboMesonero.DataSource = dtMesoneros;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboGrupoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid(comboGrupoBusqueda.SelectedValue.ToString());
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
                    string NombreMenu = GridViewMenu.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string Precio = GridViewMenu.Rows[e.RowIndex].Cells[4].Value.ToString();

                    MasterComanda.IDComanda = IDComanda;
                    MasterComanda.IDMenu = Convert.ToInt32(IDMenu);
                    MasterComanda.Precio = Convert.ToDecimal(Precio);
                    //INSERTARMOS LOS VALORES AL MASTER
                    CRUDComanda.InsertarMasterComanda(MasterComanda);
                    // SE LLAMA AL METODO TOTAL QUE PERMITE IR CALCULADO EL TOTAL DE LOS PRECIOS
                    total();
                    //SE CAGAR EL GRID DE PLATOS
                    BindGridPlatos();
                }
            }
        }

        private void GridViewComanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewComanda.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewComanda.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewComanda.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewComanda.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    string IDMasterComanda = GridViewComanda.Rows[e.RowIndex].Cells["IDMasterComanda"].Value.ToString();

                    CRUDComanda.EliminarMasterComanda(Convert.ToInt32(IDMasterComanda));

                    BindGridPlatos();
                    total();
                }
            }
        }

        private void total() {
            decimal TotalPrecio = CRUDComanda.GruposComboBox();
            //separador de miles
            LabelTotal.Text = TotalPrecio.ToString("N2");
        }

        private void btnCrearComanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro desea registrar la comanda?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Comanda.IDComanda = IDComanda;
                    Comanda.IDMesas = IDMesas;
                    Comanda.Status = "CERRADA";
                    Comanda.IDMesoneros = Convert.ToInt32(comboMesonero.SelectedValue);
                    Comanda.TotalPrecio = Convert.ToDecimal(LabelTotal.Text);
                    CRUDComanda.ModificarComanda(Comanda);
                    //SE ACTUALIZA EL GRID DE CUENTAFORM
                    _CuentaForm.BindGridCuenta();



                    MessageBox.Show("Comanda registrada");
                    this.Close();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("ERROR: "+ex.Message);
            }

        }

        private void comboMesonero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
