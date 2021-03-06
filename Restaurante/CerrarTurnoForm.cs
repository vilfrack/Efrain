﻿using Datos;
using Models;
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
    public partial class CerrarTurnoForm : Form
    {
        public CerrarTurnoForm()
        {
            InitializeComponent();
        }

        public Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public Utilidades.Status Status = new Utilidades.Status();
        public CRUDTurno CRUDTurno = new CRUDTurno();
        public CRUDCuenta CRUDCuenta = new CRUDCuenta();
        public Models.Turno Turno = new Models.Turno();
        private static int IDTurno = 0;

        private void CerrarTurnoForm_Load(object sender, EventArgs e)
        {
            IDTurno = CRUDTurno.ObtenerIDTurnoAbierto(Status.Abierta);
            utilidades.ConfiguracionFormulario(this);
            BindGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindGrid() {

            DataSet _ds = new DataSet();
            _ds = CRUDTurno.ListarCuentasPagadas(Convert.ToString(IDTurno));
            if (_ds.Tables.Count > 0)
            {
                griViewTurno.DataSource = _ds.Tables[0];
                //this.griViewTurno.Columns[""].Visible = false;
                //this.griViewTurno.Columns[""].Visible = false;
                //this.griViewTurno.Columns[""].Visible = false;
                //this.griViewTurno.Columns[""].Visible = false;
                //this.griViewTurno.Columns[""].Visible = false;
            }
        }
        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                bool cuentaAbierta = CRUDTurno.CuentaAbierta(Status.Abierta);
                if (cuentaAbierta)
                {
                    MessageBox.Show("Para cerrar turno se deben cerrar las cuentas");
                }
                else
                {
                    if (MessageBox.Show("Seguro desea cerrar el turno?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Turno.Cerrar = DateTime.Now;
                        Turno.StatusTurno = Status.Cerrado;
                        //Turno.FondoFinal = 0;
                        Turno.IDTurno = CRUDTurno.ObtenerIDTurnoAbierto(Status.Abierta);
                        CRUDTurno.Cierre(Turno);

                        MessageBox.Show("Turno Cerrado");
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
