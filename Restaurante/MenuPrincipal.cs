using Datos;
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
        CRUDTurno CRUDTurno = new CRUDTurno();
        private Utilidades.Status status = new Utilidades.Status();

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
            int turno = CRUDTurno.ObtenerTurnoAbierto(status.Abierta);
            if (turno>0)
            {
                ComandaForm comanda = new ComandaForm();
                comanda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe haber un turno abierto");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMesoneros_Click(object sender, EventArgs e)
        {
            MesonerosForm mesoneros = new MesonerosForm();
            mesoneros.ShowDialog();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            CuentaForm cuenta = new CuentaForm();
            cuenta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirTurnoForm AbrirTurnoForm = new AbrirTurnoForm();
            AbrirTurnoForm.ShowDialog();
        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            int turno = CRUDTurno.ObtenerTurnoAbierto(status.Abierta);
            if (turno > 0)
            {
                CerrarTurnoForm CerrarTurnoForm = new CerrarTurnoForm();
                CerrarTurnoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe haber un turno abierto");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PruebaForm PruebaForm = new PruebaForm();
            PruebaForm.ShowDialog();
        }

        private void btnSubGrupo_Click(object sender, EventArgs e)
        {
            SubGrupoForm SubGrupoForm = new SubGrupoForm();
            SubGrupoForm.ShowDialog();
        }

        private void btnTipoDescuento_Click(object sender, EventArgs e)
        {
            TipoDescuentoForm TipoDescuentoForm = new TipoDescuentoForm();
            TipoDescuentoForm.ShowDialog();
        }

        private void tipoDeDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDescuentoForm TipoDescuentoForm = new TipoDescuentoForm();
            TipoDescuentoForm.ShowDialog();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesasForm mesas = new MesasForm();
            mesas.ShowDialog();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnidadMedidaForm UnidadMedida = new UnidadMedidaForm();
            UnidadMedida.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GruposForm grupos = new GruposForm();
            grupos.ShowDialog();
        }

        private void subGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubGrupoForm SubGrupoForm = new SubGrupoForm();
            SubGrupoForm.ShowDialog();
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromocionesForm PromocionesForm = new PromocionesForm();
            PromocionesForm.ShowDialog();
        }

        private void meserosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesonerosForm mesoneros = new MesonerosForm();
            mesoneros.ShowDialog();
        }
    }
}
