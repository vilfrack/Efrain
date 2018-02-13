using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Utilidades
{
    public class Utilidades
    {
        public Utilidades() {

        }
        public void ValidarSoloNumeros(object sender, KeyPressEventArgs e, TextBox texbox) {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                //PERMITE BORRAR LO QUE SE ESCRIBE

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
        }
    }
}
