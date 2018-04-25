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
        }
        private void BindGridRoles()
        {
            GridViewRol.DataSource = EF.Rol.ToList();
        }
        private void BindGridRolesPorUsuarios()
        {
            GridViewRol.DataSource = EF.Rol.ToList();
        }
        private void BindGridRolesUsuarios()
        {
            GridViewUsuario.DataSource = EF.Rol.ToList();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Usuario.Login = txtUsuario.Text;
            Usuario.Nombre = txtNombre.Text;
            Usuario.Apellido = txtApellido.Text;
            Usuario.Password = txtPassword.Text;
            EF.Usuario.Add(Usuario);
            EF.SaveChanges();
            BindGridRolesUsuarios();
            MessageBox.Show("Usuario agregado");
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (txtIDUsuario.Text != "")
            {
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
                    BindGridRolesUsuarios();
                    MessageBox.Show("Regitro modificado");
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
                        BindGridRolesUsuarios();
                        MessageBox.Show("Regitro eliminado");
                    }

                }
            }
        }
    }
}
