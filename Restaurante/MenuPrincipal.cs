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
        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            ClienteForm ClienteForm = new ClienteForm();
            ClienteForm.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
        }

        private void btnMenuPedido_Click(object sender, EventArgs e)
        {
            MenuPedido MenuPedido = new MenuPedido();
            MenuPedido.ShowDialog();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            InsumosForm insumos = new InsumosForm();
            insumos.ShowDialog();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            GruposForm grupos = new GruposForm();
            grupos.ShowDialog();
        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            UnidadMedidaForm UnidadMedida = new UnidadMedidaForm();
            UnidadMedida.ShowDialog();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            MesasForm mesas = new MesasForm();
            mesas.ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            ComandaForm comanda = new ComandaForm();
            comanda.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
