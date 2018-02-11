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
    public partial class InsumosForm : Form
    {
        public InsumosForm()
        {
            InitializeComponent();
        }

        private void InsumosForm_Load(object sender, EventArgs e)
        {

        }
        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (this.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                       {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar =='.' || e.KeyChar =='\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtUltimoCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender,e);
        }

        private void txtCostoPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
        }

        private void txtCostoImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
        }
    }
}
