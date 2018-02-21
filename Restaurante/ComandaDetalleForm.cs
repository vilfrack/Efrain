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
        public ComandaDetalleForm()
        {
            InitializeComponent();
        }

        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public CRUDMenu CRUDMenu = new CRUDMenu();
        public CRUDInsumos CRUDInsumos = new CRUDInsumos();

        private int IDMesas = 0;
        private int NumeroMesa = 0;
        private int CantidadPersona = 0;

        private void ComandaDetalleForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewMenu);
            utilidades.ConfiguracionGridview(GridViewPlatos);

            ComandaForm ComandaForm = new ComandaForm();
            ComboGrupos();
            string IDGrupos = comboGrupoBusqueda.SelectedValue.ToString();
            BindGrid(IDGrupos);
            IDMesas = ComandaForm.SetIDMesas;
            NumeroMesa = ComandaForm.SetNumeroMesa;
            CantidadPersona = ComandaForm.SetCantidadPersona;


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

        }
        private void ComboGrupos()
        {
            DataTable dtGrupos = new DataTable();
            dtGrupos = CRUDInsumos.GruposComboBox();
            comboGrupoBusqueda.ValueMember = "IDGrupo";
            comboGrupoBusqueda.DisplayMember = "Descripcion";
            comboGrupoBusqueda.DataSource = dtGrupos;
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

                    //ComandaView.Add(new Models.ComandaView
                    //{
                    //    ID = Guid.NewGuid(),
                    //    IDMenu = Convert.ToInt32(IDMenu),
                    //    IDMesas = IDMesas,
                    //    Precio = Convert.ToDecimal(Precio),
                    //    NombreMenu = NombreMenu,
                    //});


                    BindGridPlatos();

                }
            }
        }

        private void GridViewPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewPlatos.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewPlatos.Rows[e.RowIndex].Cells[0].Selected)
                {
                    decimal totalPrecio = 0;
                    Guid ID = new Guid(GridViewPlatos.Rows[e.RowIndex].Cells[1].Value.ToString());
                    var itemToRemove = ComandaView.SingleOrDefault(r => r.ID == ID);
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewPlatos.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewPlatos.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    if (itemToRemove != null) {
                        totalPrecio = totalPrecio - itemToRemove.Precio;
                        ComandaView.Remove(itemToRemove);
                    }
                    else
                    {

                    }

                    BindGridPlatos();

                }
            }






        }
    }
}
