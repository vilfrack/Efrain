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
            BindGridProductos();
            BindGridPromociones();
            ComboTipo();
            ComboTipoDescuento();
            ComboStatus();
            HorasMinutos();
        }

        private CRUDPromocion CRUDPromocion = new CRUDPromocion();
        private CRUDTipoDescuento CRUDTipoDescuento = new CRUDTipoDescuento();
        private Models.Promociones Promociones = new Models.Promociones();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();

        private void PromocionesForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewPromociones);
            utilidades.ConfiguracionGridview(GridViewProducto);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
            comboTipo.Enabled = false;
        }

        private void BindGridPromociones()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDPromocion.ListarPromocion();
            if (_ds.Tables.Count > 0)
            {
                GridViewPromociones.DataSource = _ds.Tables[0];
                #region Columns
                this.GridViewPromociones.Columns["IDTipoDescuento"].Visible = false;
                this.GridViewPromociones.Columns["Descuento"].Visible = false;
                this.GridViewPromociones.Columns["IDMenu"].Visible = false;
                this.GridViewPromociones.Columns["IDPromociones"].Visible = false;
                this.GridViewPromociones.Columns["lunesinicio"].Visible = false;
                this.GridViewPromociones.Columns["lunesfin"].Visible = false;
                this.GridViewPromociones.Columns["aplicalunes"].Visible = false;
                this.GridViewPromociones.Columns["lunesdiasalida"].Visible = false;
                this.GridViewPromociones.Columns["martesinicio"].Visible = false;
                this.GridViewPromociones.Columns["martesfin"].Visible = false;
                this.GridViewPromociones.Columns["aplicamartes"].Visible = false;
                this.GridViewPromociones.Columns["martesdiasalida"].Visible = false;
                this.GridViewPromociones.Columns["miercolesinicio"].Visible = false;
                this.GridViewPromociones.Columns["miercolesfin"].Visible = false;
                this.GridViewPromociones.Columns["aplicamiercoles"].Visible = false;
                this.GridViewPromociones.Columns["miercolesdiasalida"].Visible = false;
                this.GridViewPromociones.Columns["juevesinicio"].Visible = false;
                this.GridViewPromociones.Columns["juevesfin"].Visible = false;
                this.GridViewPromociones.Columns["aplicajueves"].Visible = false;
                this.GridViewPromociones.Columns["juevesdiasalida"].Visible = false;
                this.GridViewPromociones.Columns["viernesinicio"].Visible = false;
                this.GridViewPromociones.Columns["viernesfin"].Visible = false;
                this.GridViewPromociones.Columns["aplicaviernes"].Visible = false;
                this.GridViewPromociones.Columns["viernesdiasalida"].Visible = false;
                this.GridViewPromociones.Columns["sabadoinicio"].Visible = false;
                this.GridViewPromociones.Columns["sabadofin"].Visible = false;
                this.GridViewPromociones.Columns["aplicasabado"].Visible = false;
                this.GridViewPromociones.Columns["domingoinicio"].Visible = false;
                this.GridViewPromociones.Columns["sabadodiasalida"].Visible = false;
                this.GridViewPromociones.Columns["domingofin"].Visible = false;
                this.GridViewPromociones.Columns["aplicadomingo"].Visible = false;
                this.GridViewPromociones.Columns["domingodiasalida"].Visible = false;
                this.GridViewPromociones.Columns["visualizar"].Visible = false;
                this.GridViewPromociones.Columns["Relacionuno"].Visible = false;
                this.GridViewPromociones.Columns["Relaciondos"].Visible = false;
                this.GridViewPromociones.Columns["forzarporproducto"].Visible = false;
                #endregion
            }
        }

        private void BindGridProductos()
        {
            try
            {
                DataSet _ds = new DataSet();
                _ds = CRUDPromocion.ListarMenu();
                if (_ds.Tables.Count > 0)
                {
                    GridViewProducto.DataSource = _ds.Tables[0];
                    this.GridViewProducto.Columns["IDMenu"].Visible = false;
                    this.GridViewProducto.Columns["IDGrupo"].Visible = false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void ComboTipo()
        {
            //SE AGREGA INFORMACION AL COMBO TIPO
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Value");
            dataTable.Columns.Add("Text");
            dataTable.Rows.Add("Descuento", "Descuento");
            dataTable.Rows.Add("Volumen", "Volumen");

            comboTipo.DataSource = dataTable;
            comboTipo.DisplayMember = "Text";
            comboTipo.ValueMember = "Value";

        }

        private void ComboTipoDescuento()
        {
            //TipoDescuentoComboBox
            //SE AGREGA INFORMACION AL COMBO TIPO DESCUENTO
            DataTable dataTable = new DataTable();
            dataTable = CRUDTipoDescuento.TipoDescuentoComboBox();

            comboTipoDescuento.DataSource = dataTable;
            comboTipoDescuento.DisplayMember = "Descripcion";
            comboTipoDescuento.ValueMember = "IDTipoDescuento";
        }

        private void ComboStatus()
        {
            //SE AGREGA INFORMACION AL COMBO STATUS
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Value");
            dataTable.Columns.Add("Text");
            dataTable.Rows.Add("Activa", "Activa");
            dataTable.Rows.Add("Inactiva", "Inactiva");

            comboStatus.DataSource = dataTable;
            comboStatus.DisplayMember = "Text";
            comboStatus.ValueMember = "Value";

        }

        private void inhabilitarControl() {
            comboTipo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtDescuento.Enabled = false;
            comboTipoDescuento.Enabled = false;
            comboStatus.Enabled = false;
            checkLunes.Enabled = false;
            checkMartes.Enabled = false;
            checkMiercoles.Enabled = false;
            checkJueves.Enabled = false;
            checkViernes.Enabled = false;
            checkSabado.Enabled = false;
            checkDomingo.Enabled = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            txtDescripcion.Enabled = true;
            comboStatus.Enabled = true;
            comboTipo.Enabled = true;
            comboTipoDescuento.Enabled = true;
            GridViewProducto.Enabled = true;
            checkLunes.Enabled = true;
            checkMartes.Enabled = true;
            checkMiercoles.Enabled = true;
            checkJueves.Enabled = true;
            checkViernes.Enabled = true;
            checkSabado.Enabled = true;
            checkDomingo.Enabled = true;
            comboStatus.Enabled = true;
            comboTipo.Enabled = true;
            comboTipoDescuento.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDPromocion.Text != "" || txtIDProducto.Text == "")
                {
                    if (txtIDPromocion.Text != "")
                    {
                        MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
                    }
                    else
                    {
                        MessageBox.Show("PARA CREAR UNA PROMOCION DEBE SELECCIONAR UN PRODUCTO");
                    }
                }
                else
                {

                    Promociones.IDMenu = Convert.ToInt32(txtIDProducto.Text);
                    Promociones.descripcion = txtDescripcion.Text;
                    Promociones.status = comboStatus.SelectedValue.ToString();
                    Promociones.IDTipoDescuento = Convert.ToInt32(comboTipoDescuento.SelectedValue.ToString());
                    Promociones.tipopromocion = comboTipo.SelectedValue.ToString();
                    Promociones.descuento = Convert.ToDecimal(txtDescuento.Text);

                    Promociones.lunesinicio = datePickerLunesInicio.Text;
                    Promociones.lunesfin = datePickerLunesFin.Text;
                    Promociones.martesinicio = datePickerMartesInicio.Text;
                    Promociones.martesfin = datePickerMartesFin.Text;
                    Promociones.miercolesinicio = datePickerMiercolesInicio.Text;
                    Promociones.miercolesfin = datePickerMiercolesFin.Text;
                    Promociones.juevesinicio = datePickerJuevesInicio.Text;
                    Promociones.juevesfin = datePickerJuevesFin.Text;
                    Promociones.viernesinicio = datePickerViernesInicio.Text;
                    Promociones.viernesfin = datePickerViernesFin.Text;
                    Promociones.sabadoinicio = datePickerSabadoInicio.Text;
                    Promociones.sabadofin = datePickerSabadoFin.Text;
                    Promociones.domingoinicio = datePickerDomingoInicio.Text;
                    Promociones.domingofin = datePickerDomingoFin.Text;


                    Promociones.lunesdiasalida = comboLunesSalida.SelectedText.ToString() == null ? "" : comboLunesSalida.SelectedText.ToString();
                    Promociones.martesdiasalida = comboMartesSalida.SelectedText.ToString() == null ? "" : comboMartesSalida.SelectedText.ToString();
                    Promociones.miercolesdiasalida = comboMiercolesSalida.SelectedText.ToString() == null ? "" : comboMiercolesSalida.SelectedText.ToString();
                    Promociones.juevesdiasalida = comboJuevesSalida.SelectedText.ToString() == null ? "" : comboJuevesSalida.SelectedText.ToString();
                    Promociones.viernesdiasalida = comboViernesSalida.SelectedText.ToString() == null ? "" : comboViernesSalida.SelectedText.ToString();
                    Promociones.sabadodiasalida = comboSabadoSalida.SelectedText.ToString() == null ? "" : comboSabadoSalida.SelectedText.ToString();
                    Promociones.domingodiasalida = comboDomingoSalida.SelectedText.ToString() == null ? "" : comboDomingoSalida.SelectedText.ToString();


                    Promociones.aplicalunes = checkLunes.Checked ? true : false;
                    Promociones.aplicamartes = checkMartes.Checked ? true : false;
                    Promociones.aplicamiercoles = checkMiercoles.Checked ? true : false;
                    Promociones.aplicajueves = checkJueves.Checked ? true : false;
                    Promociones.aplicaviernes = checkViernes.Checked ? true : false;
                    Promociones.aplicasabado = checkSabado.Checked ? true : false;
                    Promociones.aplicadomingo = checkDomingo.Checked ? true : false;



                    int validar = CRUDPromocion.InsertarPromocion(Promociones);

                    if (validar == 1)
                    {
                        MessageBox.Show("Registro agregado");
                        BindGridPromociones();
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDPromocion.Text != "")
            {
                GridViewProducto.Enabled = true;
                Promociones.IDPromociones =Convert.ToInt32(txtIDPromocion.Text);
                Promociones.descripcion = txtDescripcion.Text;
                Promociones.status = comboStatus.SelectedValue.ToString();
                Promociones.IDTipoDescuento = Convert.ToInt32(comboTipoDescuento.SelectedValue.ToString());
                Promociones.tipopromocion = comboTipo.SelectedValue.ToString();

                Promociones.lunesinicio = datePickerLunesInicio.Text;
                Promociones.lunesfin = datePickerLunesFin.Text;
                Promociones.martesinicio = datePickerMartesInicio.Text;
                Promociones.martesfin = datePickerMartesFin.Text;
                Promociones.miercolesinicio = datePickerMiercolesInicio.Text;
                Promociones.miercolesfin = datePickerMiercolesFin.Text;
                Promociones.juevesinicio = datePickerJuevesInicio.Text;
                Promociones.juevesfin = datePickerJuevesFin.Text;
                Promociones.viernesinicio = datePickerViernesInicio.Text;
                Promociones.viernesfin = datePickerViernesFin.Text;
                Promociones.sabadoinicio = datePickerSabadoInicio.Text;
                Promociones.sabadofin = datePickerSabadoFin.Text;
                Promociones.domingoinicio = datePickerDomingoInicio.Text;
                Promociones.domingofin = datePickerDomingoFin.Text;


                Promociones.lunesdiasalida = comboLunesSalida.SelectedValue.ToString();
                Promociones.martesdiasalida = comboMartesSalida.SelectedValue.ToString();
                Promociones.miercolesdiasalida = comboMiercolesSalida.SelectedValue.ToString();
                Promociones.juevesdiasalida = comboJuevesSalida.SelectedValue.ToString();
                Promociones.viernesdiasalida = comboViernesSalida.SelectedValue.ToString();
                Promociones.sabadodiasalida = comboSabadoSalida.SelectedValue.ToString();
                Promociones.domingodiasalida = comboDomingoSalida.SelectedValue.ToString();


                Promociones.aplicalunes = checkLunes.Checked ? true : false;
                Promociones.aplicamartes = checkMartes.Checked ? true : false;
                Promociones.aplicamiercoles = checkMiercoles.Checked ? true : false;
                Promociones.aplicajueves = checkJueves.Checked ? true : false;
                Promociones.aplicaviernes = checkViernes.Checked ? true : false;
                Promociones.aplicasabado = checkSabado.Checked ? true : false;
                Promociones.aplicadomingo = checkDomingo.Checked ? true : false;

                int validar = CRUDPromocion.ModificarPromocion(Promociones);

                if (validar != 0)
                {
                    BindGridPromociones();
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
                if (txtIDPromocion.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDPromocion.EliminarPromocion(txtIDPromocion.Text);

                    //string IDSubGrupo = txtIDPromociones.Text;
                    //string IDGrupo = comboVisible.SelectedValue.ToString();
                    //se elimina el masterGrupo
                    //CRUDPromociones.EliminarSubGrupoMaster(IDSubGrupo);
                    limpiarControles();
                    BindGridPromociones();
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

            checkLunes.Enabled = false;
            checkMartes.Enabled = false;
            checkMiercoles.Enabled = false;
            checkJueves.Enabled = false;
            checkViernes.Enabled = false;
            checkSabado.Enabled = false;
            checkDomingo.Enabled = false;

            comboStatus.Enabled = false;
            comboTipo.Enabled = false;
            comboTipoDescuento.Enabled = false;

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
            txtIDProducto.Text = "";
            txtIDPromocion.Text = "";
            txtPrecio.Text = "";
            txtProductoDescripcion.Text = "";
            comboStatus.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;
            comboTipoDescuento.SelectedIndex = 0;
            checkDomingo.Checked = false;
            checkSabado.Checked = false;
            checkViernes.Checked = false;
            checkJueves.Checked = false;
            checkMiercoles.Checked = false;
            checkMartes.Checked = false;
            checkLunes.Checked = false;
            datePickerDomingoFin.Text = "";
            datePickerDomingoInicio.Text = "";
            datePickerJuevesFin.Text = "";
            datePickerJuevesInicio.Text = "";
            datePickerLunesFin.Text = "";
            datePickerLunesInicio.Text = "";
            datePickerMartesFin.Text = "";
            datePickerMartesInicio.Text = "";
            datePickerMiercolesFin.Text = "";
            datePickerMiercolesInicio.Text = "";
            datePickerSabadoFin.Text = "";
            datePickerSabadoInicio.Text = "";
            datePickerViernesFin.Text = "";
            datePickerViernesInicio.Text = "";
        }

        private void HorasMinutos() {
            // LE DAMOS EL FORMATO A LOS DATA PICKER
            datePickerLunesInicio.Format = DateTimePickerFormat.Time;
            datePickerLunesInicio.ShowUpDown = true;
            datePickerLunesFin.Format = DateTimePickerFormat.Time;
            datePickerLunesFin.ShowUpDown = true;

            datePickerMartesInicio.Format = DateTimePickerFormat.Time;
            datePickerMartesInicio.ShowUpDown = true;
            datePickerMartesFin.Format = DateTimePickerFormat.Time;
            datePickerMartesFin.ShowUpDown = true;

            datePickerMiercolesInicio.Format = DateTimePickerFormat.Time;
            datePickerMiercolesInicio.ShowUpDown = true;
            datePickerMiercolesFin.Format = DateTimePickerFormat.Time;
            datePickerMiercolesFin.ShowUpDown = true;

            datePickerJuevesInicio.Format = DateTimePickerFormat.Time;
            datePickerJuevesInicio.ShowUpDown = true;
            datePickerJuevesFin.Format = DateTimePickerFormat.Time;
            datePickerJuevesFin.ShowUpDown = true;

            datePickerViernesInicio.Format = DateTimePickerFormat.Time;
            datePickerViernesInicio.ShowUpDown = true;
            datePickerViernesFin.Format = DateTimePickerFormat.Time;
            datePickerViernesFin.ShowUpDown = true;

            datePickerSabadoInicio.Format = DateTimePickerFormat.Time;
            datePickerSabadoInicio.ShowUpDown = true;
            datePickerSabadoFin.Format = DateTimePickerFormat.Time;
            datePickerSabadoFin.ShowUpDown = true;

            datePickerDomingoInicio.Format = DateTimePickerFormat.Time;
            datePickerDomingoInicio.ShowUpDown = true;
            datePickerDomingoFin.Format = DateTimePickerFormat.Time;
            datePickerDomingoFin.ShowUpDown = true;
        }

        private void checkLunes_Click(object sender, EventArgs e)
        {
            datePickerLunesInicio.Visible = checkLunes.Checked == true ? true : false;
            datePickerLunesFin.Visible = checkLunes.Checked == true ? true : false;
            //comboLunesSalida.Visible = checkLunes.Checked == true ? true : false;
        }

        private void checkMartes_Click(object sender, EventArgs e)
        {
            datePickerMartesInicio.Visible = checkMartes.Checked == true ? true : false;
            datePickerMartesFin.Visible = checkMartes.Checked == true ? true : false;
            //comboMartesSalida.Visible = checkMartes.Checked == true ? true : false;
        }

        private void checkMiercoles_Click(object sender, EventArgs e)
        {
            datePickerMiercolesInicio.Visible = checkMiercoles.Checked == true ? true : false;
            datePickerMiercolesFin.Visible = checkMiercoles.Checked == true ? true : false;
            //comboMiercolesSalida.Visible = checkMiercoles.Checked == true ? true : false;
        }

        private void checkJueves_Click(object sender, EventArgs e)
        {
            datePickerJuevesInicio.Visible = checkJueves.Checked == true ? true : false;
            datePickerJuevesFin.Visible = checkJueves.Checked == true ? true : false;
            //comboJuevesSalida.Visible = checkJueves.Checked == true ? true : false;
        }

        private void checkViernes_Click(object sender, EventArgs e)
        {
            datePickerViernesInicio.Visible = checkViernes.Checked == true ? true : false;
            datePickerViernesFin.Visible = checkViernes.Checked == true ? true : false;
            //comboViernesSalida.Visible = checkViernes.Checked == true ? true : false;
        }

        private void checkSabado_Click(object sender, EventArgs e)
        {
            datePickerSabadoInicio.Visible = checkSabado.Checked == true ? true : false;
            datePickerSabadoFin.Visible = checkSabado.Checked == true ? true : false;
            //comboSabadoSalida.Visible = checkSabado.Checked == true ? true : false;
        }

        private void checkDomingo_Click(object sender, EventArgs e)
        {
            datePickerDomingoInicio.Visible = checkDomingo.Checked == true ? true : false;
            datePickerDomingoFin.Visible = checkDomingo.Checked == true ? true : false;
            //comboDomingoSalida.Visible = checkDomingo.Checked == true ? true : false;
        }

        private void GridViewProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewProducto.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewProducto.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewProducto.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewProducto.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    string IDMenu = GridViewProducto.Rows[e.RowIndex].Cells["IDMenu"].Value.ToString();

                    DataTable _datatable = new DataTable();
                    _datatable = CRUDPromocion.BuscarMenu(IDMenu);
                    if (_datatable.Rows.Count > 0)
                    {

                        txtIDProducto.Text = _datatable.Rows[0]["IDMenu"].ToString();
                        txtProductoDescripcion.Text = _datatable.Rows[0]["Nombre"].ToString();
                        txtPrecio.Text = _datatable.Rows[0]["Precio"].ToString();
                    }
                }
            }
        }

        private void GridViewPromociones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewPromociones.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewPromociones.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewPromociones.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewPromociones.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    string IDPromociones = GridViewPromociones.Rows[e.RowIndex].Cells["IDPromociones"].Value.ToString();

                    DataTable _datatable = new DataTable();
                    DataTable _datatableMenu = new DataTable();
                    _datatable = CRUDPromocion.BuscarPromocion(IDPromociones);
                    if (_datatable.Rows.Count > 0)
                    {

                        #region Controles
                        txtIDPromocion.Text = _datatable.Rows[0]["IDPromociones"].ToString();
                        comboTipo.SelectedValue = _datatable.Rows[0]["tipopromocion"].ToString();
                        txtDescripcion.Text = _datatable.Rows[0]["descripcion"].ToString();
                        txtDescuento.Text = _datatable.Rows[0]["Descuento"].ToString();
                        comboTipoDescuento.SelectedValue = _datatable.Rows[0]["IDTipoDescuento"].ToString();
                        comboStatus.SelectedValue = _datatable.Rows[0]["status"].ToString();
                        #endregion

                        #region CheckBox
                        checkDomingo.Checked = _datatable.Rows[0]["aplicadomingo"].ToString() == "True" ? true : false;
                        checkSabado.Checked = _datatable.Rows[0]["aplicasabado"].ToString() == "True" ? true : false;
                        checkViernes.Checked = _datatable.Rows[0]["aplicaviernes"].ToString() == "True" ? true : false;
                        checkJueves.Checked = _datatable.Rows[0]["aplicajueves"].ToString() == "True" ? true : false;
                        checkMiercoles.Checked = _datatable.Rows[0]["aplicamiercoles"].ToString() == "True" ? true : false;
                        checkMartes.Checked = _datatable.Rows[0]["aplicamartes"].ToString() == "True" ? true : false;
                        checkLunes.Checked = _datatable.Rows[0]["aplicalunes"].ToString() == "True" ? true : false;
                        #endregion

                        #region DataPicker
                        datePickerLunesInicio.Text = _datatable.Rows[0]["lunesinicio"].ToString();
                        datePickerLunesFin.Text = _datatable.Rows[0]["lunesfin"].ToString();
                        datePickerDomingoFin.Text = _datatable.Rows[0]["domingofin"].ToString();
                        datePickerDomingoInicio.Text = _datatable.Rows[0]["domingoinicio"].ToString();
                        datePickerSabadoFin.Text = _datatable.Rows[0]["sabadofin"].ToString();
                        datePickerSabadoInicio.Text = _datatable.Rows[0]["sabadoinicio"].ToString();
                        datePickerViernesFin.Text = _datatable.Rows[0]["viernesfin"].ToString();
                        datePickerViernesInicio.Text = _datatable.Rows[0]["viernesinicio"].ToString();
                        datePickerJuevesFin.Text = _datatable.Rows[0]["juevesfin"].ToString();
                        datePickerJuevesInicio.Text = _datatable.Rows[0]["juevesinicio"].ToString();
                        datePickerMiercolesFin.Text = _datatable.Rows[0]["miercolesfin"].ToString();
                        datePickerMiercolesInicio.Text = _datatable.Rows[0]["miercolesinicio"].ToString();
                        datePickerMartesFin.Text = _datatable.Rows[0]["martesfin"].ToString();
                        datePickerMartesInicio.Text = _datatable.Rows[0]["martesinicio"].ToString();
                        #endregion

                        string IDMenu = _datatable.Rows[0]["IDMenu"].ToString();
                        _datatable = CRUDPromocion.BuscarMenu(IDMenu);

                        if (_datatable.Rows.Count > 0)
                        {
                            txtIDProducto.Text = _datatable.Rows[0]["IDMenu"].ToString();
                            txtProductoDescripcion.Text = _datatable.Rows[0]["Nombre"].ToString();
                            txtPrecio.Text = _datatable.Rows[0]["Precio"].ToString();
                        }
                        BtnNuevo.Enabled = false;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                        BtnGuardar.Enabled = true;

                    }
                }
            }
        }

        private void comboTipoDescuento_SelectedValueChanged(object sender, EventArgs e)
        {
            //SE OBTIENE EL DESCUENTO CUANDO SE HACE UN CAMBIO EN EL COMBO
            DataTable dataTable = new DataTable();
            string IDTipoDescuento;
            if ((comboTipoDescuento.SelectedValue == null) || string.IsNullOrEmpty(comboTipoDescuento.SelectedValue.ToString()))
            {
                IDTipoDescuento = "System.Data.DataRowView";
            }
            else
            {
                IDTipoDescuento = comboTipoDescuento.SelectedValue.ToString();
            }

            if (IDTipoDescuento != "System.Data.DataRowView")
            {
                dataTable = CRUDTipoDescuento.BuscarTipoDescuento(IDTipoDescuento);
            }
            if (dataTable.Rows.Count > 0)
            {
                txtDescuento.Text = dataTable.Rows[0]["Descuento"].ToString();
            }
        }
    }
}
