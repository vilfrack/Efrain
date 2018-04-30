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
            int IDRol = Convert.ToInt32(comboRoles.SelectedValue);
            var query = (from mRol in EF.MaestroModuloRol
                           join rol in EF.Rol on mRol.IDRol equals rol.IDRol
                           join modulo in EF.Modulo on mRol.IDModulo equals modulo.IDModulo
                           where rol.IDRol == IDRol
                           select new {
                               IDMaestro =  mRol.IDModulosRol,
                               IDModulo = modulo.IDModulo,
                               IDRol = rol.IDRol,
                               Rol = rol.Descripcion,
                               Modulo = modulo.Modulo1
                           }).ToList();

            GridViewPermisoRol.DataSource = query.ToList();
            this.GridViewPermisoRol.Columns["IDMaestro"].Visible = false;
            this.GridViewPermisoRol.Columns["IDModulo"].Visible = false;
            this.GridViewPermisoRol.Columns["IDRol"].Visible = false;
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
            foreach (var item in listModulo.ToList())
            {
                MaestroModuloRol moduloRol = new MaestroModuloRol();
                moduloRol.IDModulo = item.IDModulo;
                moduloRol.IDRol = IDRol;

                EF.MaestroModuloRol.Add(moduloRol);
                EF.SaveChanges();
            }
            BindGridPermisoRol();
            MessageBox.Show("Permiso agregado");

        }

        private void GridViewModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in GridViewModulos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["check"];
                var s = chk.FalseValue;
                var vc = chk.TrueValue;
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
                        var itemToRemove = listModulo.Where(r => r.IDModulo == IDModulo).ToList();
                        foreach (var removeItem in itemToRemove)
                        {
                            listModulo.Remove(removeItem);
                        }
                    }

                }
            }

        }

        private void comboRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            string validar = comboRoles.SelectedValue.ToString();
            if (validar == "Datos.EF.Rol")
            {
                return;
            }
            BindGridPermisoRol();
        }
    }
}
