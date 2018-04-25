using Datos.EF;
using Restaurante.Utilidades;
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
    public partial class RolForm : Form
    {
        BDRestauranteEntities EF = new BDRestauranteEntities();
        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        Datos.EF.Rol rol = new Rol();
        public RolForm()
        {
            InitializeComponent();
        }
        private void RolForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewRol);
            BindGrid();
        }
        private void btnBorrarComanda_Click(object sender, EventArgs e)
        {
            rol.Descripcion = txtDescripcionRol.Text;
            EF.Rol.Add(rol);
            EF.SaveChanges();
            BindGrid();
            MessageBox.Show("Rol agregado");
        }
        private void BindGrid()
        {
            GridViewRol.DataSource = EF.Rol.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewRol.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewRol.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewRol.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewRol.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    txtIDRol.Text = GridViewRol.Rows[e.RowIndex].Cells["IDRol"].Value.ToString();
                    txtDescripcionRol.Text = GridViewRol.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                    btnCrearRol.Enabled = false;
                    btnEditarRol.Enabled = true;
                    btnEliminarRol.Enabled = true;
                }
            }
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            if (txtIDRol.Text !="")
            {
                int IDRol = Convert.ToInt32(txtIDRol.Text);
                Rol rol = EF.Rol.Find(IDRol);
                if (rol !=null)
                {
                    rol.Descripcion = txtDescripcionRol.Text;
                    EF.SaveChanges();
                    BindGrid();
                    MessageBox.Show("Regitro modificado");
                }
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtIDRol.Text != "")
                {
                    int IDRol = Convert.ToInt32(txtIDRol.Text);
                    Rol rol = EF.Rol.Find(IDRol);
                    if (rol != null)
                    {
                        EF.Rol.Remove(rol);
                        EF.SaveChanges();
                        BindGrid();
                        MessageBox.Show("Regitro eliminado");
                    }

                }
            }

        }
    }
}
