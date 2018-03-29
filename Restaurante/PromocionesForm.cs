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
                this.GridViewPromociones.Columns["IDPromocion"].Visible = false;
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
            DataSet _ds = new DataSet();
            _ds = CRUDPromocion.ListarMenu();
            if (_ds.Tables.Count > 0)
            {
                GridViewProducto.DataSource = _ds.Tables[0];
                this.GridViewProducto.Columns["IDMenu"].Visible = false;
                this.GridViewProducto.Columns["IDGrupo"].Visible = false;
            }
        }
        private void ComboTipo()
        {
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

            DataTable dataTable = new DataTable();
            dataTable = CRUDTipoDescuento.TipoDescuentoComboBox();

            comboTipoDescuento.DataSource = dataTable;
            comboTipoDescuento.DisplayMember = "IDTipoDescuento";
            comboTipoDescuento.ValueMember = "Descripcion";

        }
        private void ComboStatus()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Value");
            dataTable.Columns.Add("Text");
            dataTable.Rows.Add("Activa", "Activa");
            dataTable.Rows.Add("Inactiva", "Inactiva");

            comboStatus.DataSource = dataTable;
            comboStatus.DisplayMember = "Text";
            comboStatus.ValueMember = "Value";

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
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDPromocion.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                Promociones.Descripcion = txtDescripcion.Text;
                Promociones.Descuento = Convert.ToDecimal(txtDescuento.Text);
                Promociones.Visible = comboVisible.SelectedValue.ToString() == "1" ? true : false;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDPromociones.Text != "")
            {
                Promociones.IDPromociones = Convert.ToInt32(txtIDPromociones.Text);
                Promociones.Descripcion = txtDescripcion.Text;
                Promociones.Descuento = Convert.ToDecimal(txtDescuento.Text);
                Promociones.Visible = comboVisible.SelectedValue.ToString() == "Si" ? true : false;
                int validar = CRUDPromociones.ModificarPromociones(Promociones);
                //string IDSubGrupo = txtIDPromociones.Text;
                //string IDGrupo = comboVisible.SelectedValue.ToString();
                //se actualiza el masterGrupo
                //CRUDPromociones.ActualizarSubGrupoMaster(IDGrupo, IDSubGrupo);
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
                if (txtIDPromociones.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDPromociones.EliminarPromociones(txtIDPromociones.Text);

                    string IDSubGrupo = txtIDPromociones.Text;
                    string IDGrupo = comboVisible.SelectedValue.ToString();
                    //se elimina el masterGrupo
                    //CRUDPromociones.EliminarSubGrupoMaster(IDSubGrupo);
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
            txtIDPromociones.Text = "";
            comboVisible.SelectedIndex = -1;
        }
    }
}
