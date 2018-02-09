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
using System.Data.SqlServerCe;
using System.IO;
using System.Configuration;

namespace Restaurante
{
    public partial class ClienteForm : Form
    {
        //public Conexion conexion = new Conexion();
        private Cliente cliente = new Cliente();
        private EnvioDomicilio envioDomicilio = new EnvioDomicilio();
        private CRUDCliente CRUD = new CRUDCliente();
        private CRUDEnvioDomicilio CRUDDomicilio = new CRUDEnvioDomicilio();
        public ClienteForm()
        {

            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            txtIDDomicilio.Enabled = false;
            btnEliminar.Enabled = false;
            BindGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text != "")
            {
                MessageBox.Show("DEBE BORRAR LOS REGISTROS PARA AGREGAR UNO NUEVO");
            }
            else
            {
                cliente.Contacto = txtContacto.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Tipo_facturacion = "sdsd";//ComboTipofacturacion.SelectedValue.ToString();
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

                int validar = CRUD.InsertarCliente(cliente);

                DataTable _datatable = new DataTable();
                _datatable = CRUD.UltimoIDCliente();
                string IDCliente = _datatable.Rows[0]["IDCliente"].ToString();

                envioDomicilio.IDCliente = Convert.ToInt32(IDCliente);
                envioDomicilio.Calle = txtCalle.Text;
                envioDomicilio.Direccion = txtDireccion.Text;
                envioDomicilio.NumExterior = txtNum.Text;
                envioDomicilio.NumInterior = txtNumInterior.Text;
                envioDomicilio.Cruzamientos = txtCruzamientos.Text;
                envioDomicilio.Cruzamientos2 = txtCruzamientos2.Text;
                envioDomicilio.Colonia = txtColonia.Text;
                envioDomicilio.Zona = txtZona.Text;
                envioDomicilio.Referencia = txtReferencia.Text;
                envioDomicilio.Ciudad = txtCiudadDomicilio.Text;
                envioDomicilio.Delegación = txtDelegacion.Text;
                envioDomicilio.Estado = txtEstadoDireccion.Text;
                envioDomicilio.Pais = txtPaisDireccion.Text;
                envioDomicilio.CP = txtCP.Text;

                int validarDomicilio = CRUDDomicilio.InsertarEnvioDomicilio(envioDomicilio);

                if (validar == 1 && validarDomicilio == 1)
                {
                    MessageBox.Show("Registro agregado");
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }

        }
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            _ds = CRUD.ListarCliente();
            if (_ds.Tables.Count > 0)
            {
                griViewCliente.DataSource = _ds.Tables[0];
            }
        }
        private void griViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (griViewCliente.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (griViewCliente.Rows[e.RowIndex].Cells[0].Selected)
                {
                    string IDCLiente = griViewCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DataTable _datatable = new DataTable();
                    DataTable _datatableDomicilio = new DataTable();
                    _datatableDomicilio = CRUDDomicilio.BuscarEnvioDomicilio(IDCLiente);
                    _datatable = CRUD.BuscarCliente(IDCLiente);
                    if (_datatable.Rows.Count > 0)
                    {
                        txtNombre.Text = _datatable.Rows[0]["Nombre"].ToString();
                        txtEstados.Text = _datatable.Rows[0]["Estado"].ToString();
                        txtPoblacion.Text = _datatable.Rows[0]["Poblacion"].ToString();
                        txtDireccion.Text = _datatable.Rows[0]["Direccion"].ToString();
                        txtIDCliente.Text = _datatable.Rows[0]["IDCliente"].ToString();
                        txtCodPostals.Text = _datatable.Rows[0]["CodPostal"].ToString();
                        txtPais.Text = _datatable.Rows[0]["Pais"].ToString();
                        txtFolioFiscal.Text = _datatable.Rows[0]["FolioFiscal"].ToString();
                        txtRFC.Text = _datatable.Rows[0]["Rfc"].ToString();
                        txtGiro.Text = _datatable.Rows[0]["Giro"].ToString();
                        txtCurp.Text = _datatable.Rows[0]["Curp"].ToString();
                        txtTelefono5.Text = _datatable.Rows[0]["Telefono5"].ToString();
                        txtTelefono4.Text = _datatable.Rows[0]["Telefono4"].ToString();
                        txtTelefono3.Text = _datatable.Rows[0]["Telefono3"].ToString();
                        txtTelefono2.Text = _datatable.Rows[0]["Telefono2"].ToString();
                        txtContacto.Text = _datatable.Rows[0]["Contacto"].ToString();
                        txtTelefono1.Text = _datatable.Rows[0]["Telefono1"].ToString();

                    }
                    if (_datatableDomicilio.Rows.Count > 0)
                    {
                        txtCruzamientos.Text = _datatableDomicilio.Rows[0]["Cruzamientos"].ToString();
                        txtCruzamientos2.Text= _datatableDomicilio.Rows[0]["Cruzamientos2"].ToString();
                        txtCalle.Text = _datatableDomicilio.Rows[0]["Calle"].ToString();
                        txtIDDomicilio.Text = _datatableDomicilio.Rows[0]["IDDomilicilio"].ToString();
                        txtCP.Text = _datatableDomicilio.Rows[0]["CP"].ToString();
                        txtNum.Text = _datatableDomicilio.Rows[0]["NumExterior"].ToString();
                        txtNumInterior.Text = _datatableDomicilio.Rows[0]["NumInterior"].ToString();
                        txtZona.Text = _datatableDomicilio.Rows[0]["Zona"].ToString();
                        txtColonia.Text = _datatableDomicilio.Rows[0]["Colonia"].ToString();
                        txtPaisDireccion.Text = _datatableDomicilio.Rows[0]["Pais"].ToString();
                        txtEstadoDireccion.Text = _datatableDomicilio.Rows[0]["Estado"].ToString();
                        txtDelegacion.Text = _datatableDomicilio.Rows[0]["Delegación"].ToString();
                        txtReferencia.Text = _datatableDomicilio.Rows[0]["Referencia"].ToString();
                    }
                    else
                    {
                        txtCruzamientos.Text = "";
                        txtCruzamientos2.Text = "";
                        txtCalle.Text = "";
                        txtIDDomicilio.Text = "";
                        txtCP.Text = "";
                        txtNum.Text = "";
                        txtNumInterior.Text = "";
                        txtZona.Text = "";
                        txtColonia.Text = "";
                        txtPaisDireccion.Text = "";
                        txtEstadoDireccion.Text = "";
                        txtDelegacion.Text = "";
                        txtReferencia.Text = "";
                        txtCiudadDomicilio.Text = "";
                    }
                    btnEditar.Enabled = true;
                    BtnNuevo.Enabled = false;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text!="")
            {
                cliente.IDCliente = Convert.ToInt32(txtIDCliente.Text);
                cliente.Contacto = txtContacto.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Tipo_facturacion = "sdsd";//ComboTipofacturacion.SelectedValue.ToString();
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

                envioDomicilio.IDCliente = Convert.ToInt32(txtIDCliente.Text);
                envioDomicilio.Calle = txtCalle.Text;
                envioDomicilio.Direccion = txtDireccion.Text;
                envioDomicilio.NumExterior = txtNum.Text;
                envioDomicilio.NumInterior = txtNumInterior.Text;
                envioDomicilio.Cruzamientos = txtCruzamientos.Text;
                envioDomicilio.Cruzamientos2 = txtCruzamientos2.Text;
                envioDomicilio.Colonia = txtColonia.Text;
                envioDomicilio.Zona = txtZona.Text;
                envioDomicilio.Referencia = txtReferencia.Text;
                envioDomicilio.Ciudad = txtCiudadDomicilio.Text;
                envioDomicilio.Delegación = txtDelegacion.Text;
                envioDomicilio.Estado = txtEstadoDireccion.Text;
                envioDomicilio.Pais = txtPaisDireccion.Text;
                envioDomicilio.CP = txtCP.Text;

                DataTable _datatableValidar = new DataTable();
                _datatableValidar = CRUDDomicilio.ValidarEnvioDomicilio(txtIDCliente.Text);
                int validar = 0;
                if (_datatableValidar.Rows.Count > 0)
                {
                    validar =Convert.ToInt32(_datatableValidar.Rows[0]["validar"].ToString());
                }


                int validarCliente = CRUD.ModificarCliente(cliente);
                int validarDomicilio = 0;
                if (validar > 0)
                {
                    validarDomicilio = CRUDDomicilio.ModificarEnvioDomicilio(envioDomicilio);
                }
                else
                {
                    validarDomicilio = CRUDDomicilio.InsertarEnvioDomicilio(envioDomicilio);
                }

                if (validarCliente != 0 && validarDomicilio != 0)
                {
                    BindGrid();
                    MessageBox.Show("REGISTRO MODIFICADO");

                }
                else {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la grilla");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtIDCliente.Text=="")
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }
                else
                {
                    CRUD.EliminarCliente(txtIDCliente.Text);
                    CRUDDomicilio.EliminarEnvioDomicilio(txtIDCliente.Text);
                    BindGrid();
                    MessageBox.Show("REGISTRO ELIMINADO");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnNuevo.Enabled = true;
            txtCruzamientos.Text = "";
            txtCruzamientos2.Text = "";
            txtCalle.Text = "";
            txtIDDomicilio.Text = "";
            txtCP.Text = "";
            txtNum.Text = "";
            txtNumInterior.Text = "";
            txtZona.Text = "";
            txtColonia.Text = "";
            txtPaisDireccion.Text = "";
            txtEstadoDireccion.Text = "";
            txtDelegacion.Text = "";
            txtReferencia.Text = "";
            txtCiudadDomicilio.Text = "";
            txtNombre.Text = "";
            txtEstados.Text = "";
            txtPoblacion.Text = "";
            txtDireccion.Text = "";
            txtIDCliente.Text = "";
            txtCodPostals.Text = "";
            txtPais.Text = "";
            txtFolioFiscal.Text = "";
            txtRFC.Text = "";
            txtGiro.Text = "";
            txtCurp.Text = "";
            txtTelefono5.Text = "";
            txtTelefono4.Text = "";
            txtTelefono3.Text = "";
            txtTelefono2.Text = "";
            txtContacto.Text = "";
            txtTelefono1.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Hide();
            menuPrincipal.Show();
        }
    }
}
