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
    public partial class PagarCuentaForm : Form
    {
        public PagarCuentaForm()
        {
            InitializeComponent();
        }
        private Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        private Utilidades.Status status = new Utilidades.Status();

        private void PagarCuentaForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
        }
    }
}
