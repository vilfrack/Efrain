using Datos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Utilidades
{
    public static class DatosLogin {
        public static int IDUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Password { get; set; }
    }

    class Login
    {
        BDRestauranteEntities EF = new BDRestauranteEntities();
        //decalre properties
        public string Username { get; set; }
        public string Userpassword { get; set; }

        //intialise
        public Login(string user, string pass)
        {
            //DatosLogin DatosLogin = new DatosLogin();
            this.Username = user;
            this.Userpassword = pass;
            DatosLogin.Usuario = user;
            DatosLogin.Password = pass;
        }
        public Login() {
        }
        //validate string
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validate integer
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //clear user inputs
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        //method to check if elegible to be logged in
        internal bool IsLoggedIn(string user, string pass)
        {
            BDRestauranteEntities EF = new BDRestauranteEntities();
            var login = EF.Usuario.Where(w => w.Login == user && w.Password == pass).Any();
            if (login)
            {
                DatosLogin.IDUsuario = EF.Usuario.Where(w => w.Login == user && w.Password == pass).Select(s=>s.IDUsuario).SingleOrDefault();
            }
            return login;
        }

        public List<MaestroRolUsuario> ObtenerIDRol(int IDUsuario) {

            var getRol = EF.MaestroRolUsuario.Where(w => w.IDUsuario == IDUsuario).ToList();
            List<MaestroRolUsuario> List = new List<MaestroRolUsuario>();
            List.AddRange(getRol);
            return List;
        }
    }
}
