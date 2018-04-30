using Datos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Utilidades
{

    public class Permisos
    {
        BDRestauranteEntities EF = new BDRestauranteEntities();

        public string AbrirTurnoForm = "AbrirTurnoForm";
        public string CerrarTurnoForm = "CerrarTurnoForm";
        public string CerrarCajaForm = "CerrarCajaForm";
        public string ClienteForm = "ClienteForm";
        public string ComandaForm = "ComandaForm";
        public string CuentaForm = "CuentaForm";
        public string GruposForm = "GruposForm";
        public string InsumosForm = "InsumosForm";
        public string MenuPedido = "MenuPedido";
        public string MesasForm = "MesasForm";
        public string MesonerosForm = "MesonerosForm";
        public string PagarCuentaForm = "PagarCuentaForm";
        public string PromocionesForm = "PromocionesForm";
        public string Propinas = "Propinas";
        public string RolForm = "RolForm";
        public string SubGrupoForm = "SubGrupoForm";
        public string TipoDescuentoForm = "TipoDescuentoForm";
        public string UnidadMedidaForm = "UnidadMedidaForm";
        public string UsuarioForm = "UsuarioForm";

        public bool permisoFormulario(string formulario, int? IDRol) {
            bool tienePermiso = false;
            tienePermiso = (from master in EF.MaestroModuloRol
                            join rol in EF.Rol on master.IDRol equals rol.IDRol
                            join modulo in EF.Modulo on master.IDModulo equals modulo.IDModulo
                            where modulo.Modulo1 == formulario && rol.IDRol == IDRol
                            select master).Any();
            return tienePermiso;
        }
    }
}
