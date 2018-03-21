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
    public partial class UnidadMedidaForm : Form
    {
        private CRUDUnidadMedida CRUDUnidadMedida = new CRUDUnidadMedida();
        private Models.UnidadMedida UnidadMedida = new Models.UnidadMedida();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public UnidadMedidaForm()
        {
            InitializeComponent();
        }

        private void UnidadMedidaForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionGridview(griViewUnidad);
            BindGrid();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUDUnidadMedida.ListarUnidadMedida();
            if (_ds.Tables.Count > 0)
            {
                griViewUnidad.DataSource = _ds.Tables[0];
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
            if (txtIDUnidad.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                UnidadMedida.Descripcion = txtDescripcion.Text;
                int validar = CRUDUnidadMedida.InsertarUnidadMedida(UnidadMedida);
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
            if (txtIDUnidad.Text != "")
            {
                UnidadMedida.IDUnidad = Convert.ToInt32(txtIDUnidad.Text);
                UnidadMedida.Descripcion = txtDescripcion.Text;

                int validar = CRUDUnidadMedida.ModificarUnidadMedida(UnidadMedida);
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
                if (txtIDUnidad.Text == "")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUDUnidadMedida.EliminarUnidadMedida(txtIDUnidad.Text);
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
        private void limpiarControles()
        {
            txtDescripcion.Text = "";
            txtIDUnidad.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Close();
        }
    }
}
