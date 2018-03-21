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
    public partial class MesonerosForm : Form
    {
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
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            BindGrid();
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDMesonero.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
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
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            BtnNuevo.Enabled = true;
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
                    string IDMesoneros = griViewMesoneros.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDMesoneros.BuscarMesoneros(IDMesoneros);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDMesonero.Text = _datatable.Rows[0]["IDMesoneros"].ToString();
                        txtNombre.Text = _datatable.Rows[0]["Nombre"].ToString();
                        txtApellido.Text = _datatable.Rows[0]["Apellido"].ToString();
                    }
                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    BtnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
