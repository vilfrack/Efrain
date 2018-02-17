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
    public partial class MesasForm : Form
    {
        public Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public CRUDMesas CRUDMesas = new CRUDMesas();
        public Mesas Mesas = new Mesas();


        public MesasForm()
        {
            InitializeComponent();
        }

        private void txtNumeroMesas_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumeros(sender,e,txtNumeroMesas);
        }

        private void txtCantidadPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumeros(sender, e, txtNumeroMesas);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            txtNumeroMesas.Enabled = true;
            txtCantidadPersonas.Enabled = true;
        }

        private void MesasForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionGridview(griViewMesas);
            utilidades.ConfiguracionFormulario(this);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtNumeroMesas.Enabled = false;
            txtCantidadPersonas.Enabled = false;
        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDMesas.ListarMesas();
            if (_ds.Tables.Count > 0)
            {
                griViewMesas.DataSource = _ds.Tables[0];
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDMesas.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                Mesas.NumeroMesa =Convert.ToInt32(txtNumeroMesas.Text);
                Mesas.CantidadPersona = Convert.ToInt32(txtCantidadPersonas.Text);
                int validar = CRUDMesas.InsertarMesas(Mesas);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDMesas.Text != "")
            {
                Mesas.NumeroMesa = Convert.ToInt32(txtNumeroMesas.Text);
                Mesas.CantidadPersona = Convert.ToInt32(txtCantidadPersonas.Text);
                Mesas.IDMesas = Convert.ToInt32(txtIDMesas.Text);
                int validar = CRUDMesas.ModificarMesas(Mesas);
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
                if (txtIDMesas.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDMesas.EliminarMesas(txtIDMesas.Text);
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
            txtCantidadPersonas.Enabled = false;
            txtNumeroMesas.Enabled = false;
            BtnNuevo.Enabled = true;
            limpiarControles();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Close();
        }
        private void limpiarControles()
        {
            txtIDMesas.Text = "";
            txtCantidadPersonas.Text = "";
            txtNumeroMesas.Text = "";
        }

        private void griViewMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (griViewMesas.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (griViewMesas.Rows[e.RowIndex].Cells[0].Selected)
                {
                    string IDMesa = griViewMesas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DataTable _datatable = new DataTable();
                    _datatable = CRUDMesas.BuscarMesas(IDMesa);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtIDMesas.Text = _datatable.Rows[0]["IDMesas"].ToString();
                        txtNumeroMesas.Text = _datatable.Rows[0]["NumeroMesa"].ToString();
                        txtCantidadPersonas.Text= _datatable.Rows[0]["CantidadPersona"].ToString();
                    }
                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    BtnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    txtNumeroMesas.Enabled = true;
                    txtCantidadPersonas.Enabled = true;
                }
            }
        }
    }
}
