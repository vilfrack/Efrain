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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private static string _User = "";
        private static string _Password = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _User = txtUsuario.Text;
            _Password = txtPassword.Text;
            Login login = new Login(_User, _Password);
            if (login.IsLoggedIn(_User, _Password))
            {
                MessageBox.Show("Usuario logeado");
                MenuPrincipal MenuPrincipal = new MenuPrincipal();
                MenuPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                //show default login error message
                MessageBox.Show("Login Error!");
            }
        }
    }
}
