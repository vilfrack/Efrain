using Datos.EF;
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
    public partial class PermisoRolForm : Form
    {
        BDRestauranteEntities EF = new BDRestauranteEntities();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        private List<Modulo> listModulo = new List<Modulo>();
        public PermisoRolForm()
        {
            InitializeComponent();
        }

        private void PermisoRolForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewPermisoRol);
            utilidades.ConfiguracionGridview(GridViewModulos);
            LoadCombo();
            BindGridPermisoRol();
            BindGridModulos();

        }
        private void BindGridPermisoRol() {
            var query = (from mRol in EF.MaestroModuloRol
                           join rol in EF.Rol on mRol.IDRol equals rol.IDRol
                           join modulo in EF.Modulo on mRol.IDModulo equals modulo.IDModulo
                           select new {
                               IDMaestro =  mRol.IDModulosRol,
                               IDModulo = modulo.IDModulo,
                               IDRol = rol.IDRol,
                               Rol = rol.Descripcion,
                               Modu = modulo.Modulo1
                           }).ToList();

            GridViewPermisoRol.DataSource = query.ToList();
        }
        private void BindGridModulos() {
            GridViewModulos.DataSource = EF.Modulo.ToList();
        }
        private void LoadCombo() {
            comboRoles.DataSource = EF.Rol.ToList();
            comboRoles.ValueMember = "IDRol";
            comboRoles.DisplayMember = "Descripcion";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int IDRol = Convert.ToInt32(comboRoles.SelectedValue.ToString());
            var s = listModulo.Distinct().ToList();
            foreach (var item in listModulo.ToList().Distinct())
            {

            }
        }

        private void GridViewModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in GridViewModulos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["check"];
                if (chk.Selected == true)
                {

                    listModulo.Add(new Modulo
                    {
                        IDModulo = Convert.ToInt32(GridViewModulos.Rows[e.RowIndex].Cells["IDModulo"].Value),
                        Modulo1 = GridViewModulos.Rows[e.RowIndex].Cells["Modulo1"].Value.ToString()
                    });


                    int IDModulo = Convert.ToInt32(GridViewModulos.Rows[e.RowIndex].Cells["IDModulo"].Value);
                    if (listModulo.Where(w=>w.IDModulo== IDModulo).Count()>1)
                    {
                        var itemToRemove = listModulo.FirstOrDefault(r => r.IDModulo == IDModulo);
                        listModulo.Remove(itemToRemove);
                    }

                }
            }
            //if (GridViewModulos.Rows.Count > 0 && e.RowIndex != -1)
            //{
            //    if (GridViewModulos.Rows[e.RowIndex].Cells[0].Selected)
            //    {
            //        int row_index = e.RowIndex;
            //        for (int i = 0; i < GridViewModulos.Rows.Count; i++)
            //        {
            //            string check = GridViewModulos.Rows[i].Cells["check"].Value.ToString();

            //            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
            //            if (chk.Value == chk.TrueValue)
            //            {
            //                chk.Value = chk.FalseValue;
            //            }
            //            else
            //            {
            //                chk.Value = chk.TrueValue;
            //            }
            //            //if (check == true)
            //            //{
            //            //    listModulo.Add(new Modulo
            //            //    {
            //            //        IDModulo = Convert.ToInt32(GridViewModulos.Rows[e.RowIndex].Cells["IDModulo"].Value),
            //            //        Modulo1 = GridViewModulos.Rows[e.RowIndex].Cells["Modulo1"].Value.ToString()
            //            //    });
            //            //}

            //            //GridViewCuenta.Rows[e.RowIndex].Cells["IDComanda"].Value.ToString();
            //        }

            //    }
            //}
        }
    }
}
