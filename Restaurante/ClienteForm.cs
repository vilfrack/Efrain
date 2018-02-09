using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Models;
namespace Restaurante
{
    public partial class ClienteForm : Form
    {
        public Conexion conexion = new Conexion();
        private Cliente cliente = new Cliente();
        private EnvioDomicilio envioDomicilio = new EnvioDomicilio();
        public ClienteForm()
        {

            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            cliente.Contacto = txtContacto.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Tipo_facturacion = ComboTipofacturacion.SelectedValue.ToString();
            cliente.Poblacion = txtPoblacion.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Pais = txtPais.Text;
            cliente.CodPostal = txtCodPostals.Text;
            cliente.FolioFiscal = txtFolioFiscal.Text;
            cliente.Rfc = txtRFC.Text;
            cliente.Curp = txtCurp.Text;
            cliente.Giro = txtGiro.Text;
            cliente.Telefono1 = txtTelefono1.Text;
            cliente.Telefono2 = txtTelefono2.Text;
            cliente.Telefono3 = txtTelefono3.Text;
            cliente.Telefono4 = txtTelefono4.Text;
            cliente.Telefono5 = txtTelefono5.Text;


    }
    }
}
