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
    public partial class UsuarioForm : Form
    {
        BDRestauranteEntities EF = new BDRestauranteEntities();
        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        Datos.EF.Usuario Usuario = new Usuario();
        public int _IDUsuario = 0;
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            utilidades.ConfiguracionGridview(GridViewRol);
            utilidades.ConfiguracionGridview(GridViewUsuario);
            BindGridRoles();
            BindGridUsuarios();
        }
        private void BindGridRoles()
        {
            GridViewRol.DataSource = EF.Rol.ToList();
        }
        private void BindGridRolesPorUsuarios()
        {
            GridViewRol.DataSource = EF.Rol.ToList();
        }
        private void BindGridUsuarios()
        {
            GridViewUsuario.DataSource = EF.Usuario.ToList();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text =="" || txtApellido.Text =="" || txtUsuario.Text=="" || txtPassword.Text=="")
            {
                MessageBox.Show("Todos los campos sin obligatorios");
                return;
            }
            bool roles = false;
            foreach (DataGridViewRow row in GridViewRol.Rows)
            {
                if (Convert.ToBoolean(row.Cells["check"].Value) == true)
                {
                    roles = true;
                }
            }
            if (!roles)
            {
                MessageBox.Show("Debe seleccionar un rol");
                return;
            }
            Usuario.Login = txtUsuario.Text;
            Usuario.Nombre = txtNombre.Text;
            Usuario.Apellido = txtApellido.Text;
            Usuario.Password = txtPassword.Text;
            EF.Usuario.Add(Usuario);
            EF.SaveChanges();
            //SE OBTIENE EL ID DEL USUARIO CREADO
            int IDUsuario = Usuario.IDUsuario;
            //SE GUARDAN LOS ROLES DE ESE USUARIO
            InsertarRoles(IDUsuario);

            BindGridUsuarios();
            MessageBox.Show("Usuario agregado");
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (txtIDUsuario.Text != "")
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtUsuario.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Todos los campos sin obligatorios");
                    return;
                }
                bool trueRol = false;
                foreach (DataGridViewRow row in GridViewRol.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["check"].Value) == true)
                    {
                        trueRol = true;
                    }
                }
                if (trueRol == false)
                {
                    MessageBox.Show("Debe seleccionar un rol");
                    return;
                }
                int IDUsuario = Convert.ToInt32(txtIDUsuario.Text);
                Usuario usuario = EF.Usuario.Find(IDUsuario);
                if (usuario != null)
                {
                    Usuario.Login = txtUsuario.Text;
                    Usuario.Nombre = txtNombre.Text;
                    Usuario.Apellido = txtApellido.Text;
                    Usuario.Password = txtPassword.Text;
                    //usuario.IDUsuario = Convert.ToInt32(txtIDUsuario.Text);
                    EF.SaveChanges();
                    ActualizarRoles(Convert.ToInt32(txtIDUsuario.Text));
                    BindGridUsuarios();
                    MessageBox.Show("Regitro modificado");
                    RestablecerControles();
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtIDUsuario.Text != "")
                {
                    int IDUsuario = Convert.ToInt32(txtIDUsuario.Text);
                    Usuario usuario = EF.Usuario.Find(IDUsuario);
                    if (usuario != null)
                    {
                        EF.Usuario.Remove(usuario);
                        EF.SaveChanges();
                        BindGridUsuarios();
                        EliminarRol(IDUsuario);
                        MessageBox.Show("Regitro eliminado");
                        RestablecerControles();
                    }

                }
            }
        }

        private void InsertarRoles(int IDUsuario) {
            //https://stackoverflow.com/questions/1237829/datagridview-checkbox-column-value-and-functionality

            List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in GridViewRol.Rows)
            {
                if (Convert.ToBoolean(row.Cells["check"].Value) == true)
                {
                    MaestroRolUsuario MaestroRolUsuario = new MaestroRolUsuario();
                    //rows_with_checked_column.Add(row);

                    MaestroRolUsuario.IDRol =Convert.ToInt32(row.Cells["IDRol"].Value);
                    MaestroRolUsuario.IDUsuario = IDUsuario;
                    EF.MaestroRolUsuario.Add(MaestroRolUsuario);
                    EF.SaveChanges();
                }
            }
        }
        private void ActualizarRoles(int IDUsuario) {
            MaestroRolUsuario MaestroRolUsuario = new MaestroRolUsuario();
            var validar = EF.MaestroRolUsuario.Where(w => w.IDUsuario == IDUsuario).Any();
            if (validar)
            {
                var EliminarRoles = EF.MaestroRolUsuario.Where(w => w.IDUsuario == IDUsuario).ToList();
                foreach (var item in EliminarRoles)
                {
                    EF.MaestroRolUsuario.Remove(item);
                }
                InsertarRoles(IDUsuario);
            }
            else
            {
                InsertarRoles(IDUsuario);
            }
        }
        private void EliminarRol(int IDUsuario) {
            var validar = EF.MaestroRolUsuario.Where(w => w.IDUsuario == IDUsuario).Any();
            if (validar)
            {
                var EliminarRoles = EF.MaestroRolUsuario.Where(w => w.IDUsuario == IDUsuario).ToList();
                foreach (var item in EliminarRoles)
                {
                    EF.MaestroRolUsuario.Remove(item);
                    EF.SaveChanges();
                }
                foreach (DataGridViewRow row in GridViewRol.Rows)
                {
                    row.Cells["check"].Value = false;
                }
            }
        }
        private void CheckRoles(int IDUsuario) {

            //MaestroRolUsuario MaestroRolUsuario = new MaestroRolUsuario();
            List<MaestroRolUsuario> list = new List<MaestroRolUsuario>();
            list = EF.MaestroRolUsuario.Where(w => w.IDUsuario == IDUsuario).ToList(); ;

            foreach (DataGridViewRow row in GridViewRol.Rows)
            {
                foreach (var item in list)
                {
                    if (item.IDRol == Convert.ToInt32(row.Cells["IDRol"].Value))
                    {
                        row.Cells["check"].Value = true;
                    }
                }
                if (list.Count == 0)
                {
                    row.Cells["check"].Value = false;
                }
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewUsuario.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (GridViewUsuario.Rows[e.RowIndex].Cells[0].Selected)
                {
                    int row_index = e.RowIndex;
                    for (int i = 0; i < GridViewUsuario.Rows.Count; i++)
                    {
                        if (row_index != i)
                        {
                            GridViewUsuario.Rows[i].Cells["check"].Value = false;
                        }
                    }
                    txtIDUsuario.Text = GridViewUsuario.Rows[e.RowIndex].Cells["IDUsuario"].Value.ToString();
                    txtUsuario.Text = GridViewUsuario.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                    txtNombre.Text = GridViewUsuario.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = GridViewUsuario.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    txtPassword.Text = GridViewUsuario.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    CheckRoles(Convert.ToInt32(txtIDUsuario.Text));


                    btnCrearUsuario.Enabled = false;
                    btnEditarUsuario.Enabled = true;
                    btnEliminarUsuario.Enabled = true;
                    btnAtras.Enabled = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerControles();
        }
        private void RestablecerControles() {
            btnCrearUsuario.Enabled = true;
            btnEditarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            txtIDUsuario.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}
