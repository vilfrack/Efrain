using Datos;
using Datos.EF;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        CRUDTurno CRUDTurno = new CRUDTurno();
        private Utilidades.Status status = new Utilidades.Status();
        Utilidades.Permisos permisos = new Utilidades.Permisos();
        Login login = new Login();

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            ClienteForm ClienteForm = new ClienteForm();
            ClienteForm.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            #region OBTENER PERMISOS POR ROLES

            List<MaestroRolUsuario> list = new List<MaestroRolUsuario>();
            list.AddRange(login.ObtenerIDRol(DatosLogin.IDUsuario));
            foreach (var itemPermisos in list)
            {
                btnAbrirTurno.Enabled = permisos.permisoFormulario(permisos.AbrirTurnoForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                btnCerrarTurno.Enabled = permisos.permisoFormulario(permisos.CerrarCajaForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                BtnCliente.Enabled = permisos.permisoFormulario(permisos.ClienteForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                btnComanda.Enabled = permisos.permisoFormulario(permisos.ComandaForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                btnCuenta.Enabled = permisos.permisoFormulario(permisos.CuentaForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                gruposToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.GruposForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                btnInsumos.Enabled = permisos.permisoFormulario(permisos.InsumosForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                btnMenuPedido.Enabled = permisos.permisoFormulario(permisos.MenuPedido, itemPermisos.IDRol, DatosLogin.IDUsuario);
                mesasToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.MesasForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                meserosToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.MesonerosForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                //bool bPagarCuentaForm = permisos.permisoFormulario(permisos.PagarCuentaForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                promocionesToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.PromocionesForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                //bool bPropinas = permisos.permisoFormulario(permisos.Propinas, itemPermisos.IDRol, DatosLogin.IDUsuario);
                rolToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.RolForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                subGruposToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.SubGrupoForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                tipoDeDescuentoToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.TipoDescuentoForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                unidadDeMedidaToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.UnidadMedidaForm, itemPermisos.IDRol, DatosLogin.IDUsuario);
                usuarioToolStripMenuItem.Enabled = permisos.permisoFormulario(permisos.UsuarioForm, itemPermisos.IDRol, DatosLogin.IDUsuario);

                //if (!bAbrirTurnoForm)
                //{
                //    btnAbrirTurno.Enabled = false;
                //}
                //if (!bCerrarCajaForm)
                //{
                //    btnCerrarTurno.Enabled = false;
                //}
                //if (!bClienteForm)
                //{
                //    BtnCliente.Enabled = false;
                //}
                //if (!bComandaForm)
                //{
                //    btnComanda.Enabled = false;
                //}
                //if (!bCuentaForm)
                //{
                //    btnCuenta.Enabled = false;
                //}
                //if (!bGruposForm)
                //{
                //    gruposToolStripMenuItem.Enabled = false;
                //}
                //if (!bInsumosForm)
                //{
                //    btnInsumos.Enabled = false;
                //}
                //if (!bMenuPedido)
                //{
                //    btnMenuPedido.Enabled = false;
                //}
                //if (!bMesasForm)
                //{
                //    mesasToolStripMenuItem.Enabled = false;
                //}
                //if (!bMesonerosForm)
                //{
                //    meserosToolStripMenuItem.Enabled = false;
                //}
                //if (!bPromocionesForm)
                //{
                //    promocionesToolStripMenuItem.Enabled = false;
                //}

                //if (!bRolForm)
                //{
                //    rolToolStripMenuItem.Enabled = false;
                //}
                //if (!bSubGrupoForm)
                //{
                //    subGruposToolStripMenuItem.Enabled = false;
                //}
                //if (!bTipoDescuentoForm)
                //{
                //    tipoDeDescuentoToolStripMenuItem.Enabled = false;
                //}
                //if (!bUnidadMedidaForm)
                //{
                //    unidadDeMedidaToolStripMenuItem.Enabled = false;
                //}
                //if (!bUsuarioForm)
                //{
                //    usuarioToolStripMenuItem.Enabled = false;
                //}

            }
            #endregion


            utilidades.ConfiguracionFormulario(this);
            //bool validarPermiso = permisos.permisoFormulario(permisos.AbrirTurnoForm, 1);

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

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolForm rol = new RolForm();
            rol.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioForm usuario = new UsuarioForm();
            usuario.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void btnAbrirTurno_Click(object sender, EventArgs e)
        {
            AbrirTurnoForm AbrirTurnoForm = new AbrirTurnoForm();
            AbrirTurnoForm.ShowDialog();
        }

        private void permisosPorRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisoRolForm permisosRol = new PermisoRolForm();
            permisosRol.ShowDialog();
        }
    }
}
