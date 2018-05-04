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
    public partial class PermisosPorUsuario : Form
    {
        BDRestauranteEntities EF = new BDRestauranteEntities();
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        private List<Modulo> listModulo = new List<Modulo>();

        public PermisosPorUsuario()
        {
            InitializeComponent();
        }

        private void PermisosPorUsuario_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewPermisoUsuario);
            utilidades.ConfiguracionGridview(GridViewModulos);
            LoadCombo();
            BindGridPermisoUsuario();
            BindGridModulos();
            //invisible();
        }
        private void BindGridPermisoUsuario()
        {
            int IDUsuario = Convert.ToInt32(comboUsuarios.SelectedValue);
            var query = (from mUsuario in EF.MaestroModuloUsuario
                         join usuario in EF.Usuario on mUsuario.IDUsuario equals usuario.IDUsuario
                         join modulo in EF.Modulo on mUsuario.IDModulo equals modulo.IDModulo
                         where usuario.IDUsuario == IDUsuario
                         select new
                         {
                             IDMaestro = mUsuario.IDModulosUsuario,
                             IDModulo = modulo.IDModulo,
                             IDUsuario = usuario.IDUsuario,
                             NombreUsuario = usuario.Nombre,
                             ApellidoUsuario = usuario.Apellido,
                             Modulo = modulo.Modulo1
                         }).ToList();

            GridViewPermisoUsuario.DataSource = query.ToList();
            this.GridViewPermisoUsuario.Columns["IDMaestro"].Visible = false;
            this.GridViewPermisoUsuario.Columns["IDModulo"].Visible = false;
            this.GridViewPermisoUsuario.Columns["IDUsuario"].Visible = false;
        }

        private void BindGridModulos()
        {
            GridViewModulos.DataSource = EF.Modulo.ToList();
        }
        private void LoadCombo()
        {
            var varUsuario = (from usu in EF.Usuario
                              select new {
                                  IDUsuario = usu.IDUsuario,
                                  FullName = usu.Nombre + " " + usu.Apellido
                              }).ToList();
            comboUsuarios.DataSource = varUsuario;
            comboUsuarios.ValueMember = "IDUsuario";
            comboUsuarios.DisplayMember = "FullName";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int IDUsuario = Convert.ToInt32(comboUsuarios.SelectedValue.ToString());
            var s = listModulo.Distinct().ToList();
            foreach (var item in listModulo.ToList())
            {
                MaestroModuloUsuario ModuloUsuario = new MaestroModuloUsuario();
                bool varModuloUsuario = EF.MaestroModuloUsuario.Where(w => w.IDModulo == item.IDModulo && w.IDUsuario == IDUsuario).Any();
                if (varModuloUsuario != true)
                {
                    ModuloUsuario.IDModulo = item.IDModulo;
                    ModuloUsuario.IDUsuario = IDUsuario;
                    EF.MaestroModuloUsuario.Add(ModuloUsuario);
                    EF.SaveChanges();
                }

            }
            BindGridPermisoUsuario();
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
                    if (listModulo.Where(w => w.IDModulo == IDModulo).Count() > 1)
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

        private void invisible()
        {
            lblID.Visible = false;
            lblFullName.Visible = false;
            lblModulo.Visible = false;
            txtID.Visible = false;
            txtFullName.Visible = false;
            txtModulo.Visible = false;
        }

        private void visible()
        {
            lblID.Visible = true;
            lblFullName.Visible = true;
            lblModulo.Visible = true;
            txtID.Visible = true;
            txtFullName.Visible = true;
            txtModulo.Visible = true;
        }

        private void comboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string validar = comboUsuarios.SelectedValue.ToString();
            if (validar == "{ IDUsuario = 6, FullName = usuario usuario }")
            {
                return;
            }
            BindGridPermisoUsuario();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                int IDMaestro = Convert.ToInt32(txtID.Text);
                var maestro = EF.MaestroModuloUsuario.Find(IDMaestro);
                if (maestro != null)
                {
                    EF.MaestroModuloUsuario.Remove(maestro);
                    EF.SaveChanges();
                    BindGridPermisoUsuario();
                    txtID.Text = "";
                    txtFullName.Text = "";
                    txtModulo.Text = "";
                    invisible();
                    MessageBox.Show("Permiso eliminado");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un permiso");
            }
        }

        private void GridViewPermisoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewPermisoUsuario.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewPermisoUsuario.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewPermisoUsuario.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewPermisoUsuario.Rows[i].Cells["check"].Value = false;
                        }
                    }

                    visible();
                    txtID.Text = GridViewPermisoUsuario.Rows[e.RowIndex].Cells["IDMaestro"].Value.ToString();
                    txtModulo.Text = GridViewPermisoUsuario.Rows[e.RowIndex].Cells["Modulo"].Value.ToString();
                    txtFullName.Text = GridViewPermisoUsuario.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString() +
                                        " "+ GridViewPermisoUsuario.Rows[e.RowIndex].Cells["ApellidoUsuario"].Value.ToString();
                    btnEliminar.Enabled = true;
                }
            }
        }
    }
}
