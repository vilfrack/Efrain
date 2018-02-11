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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            ClienteForm ClienteForm = new ClienteForm();
            ClienteForm.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuPedido_Click(object sender, EventArgs e)
        {
            MenuPedido MenuPedido = new MenuPedido();
            MenuPedido.Show();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            InsumosForm insumos = new InsumosForm();
            insumos.Show();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            GruposForm grupos = new GruposForm();
            grupos.Show();
        }
    }
}
