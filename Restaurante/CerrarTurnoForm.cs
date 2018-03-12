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
        public Turno Turno = new Turno();

        private void CerrarTurnoForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            BindGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindGrid() {

        }
        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtFondoInicial.Text == "")
                //{
                //    MessageBox.Show("DEBE INDICAR UN FONDO INICIAL");
                //}
                //else
                //{
                //    Turno.Apertura = DateTime.Now;
                //    Turno.StatusTurno = Status.Abierta;
                //    Turno.FondoInicial = Convert.ToDecimal(txtFondoInicial.Text);
                //    CRUDTurno.Apertura(Turno);
                //    MessageBox.Show("Registro agregado");
                //}
                if (MessageBox.Show("Seguro desea cerrar el turno?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Turno.Cerrar = DateTime.Now;
                    Turno.StatusTurno = Status.Cerrado;
                    Turno.FondoFinal = 0;
                    Turno.IDTurno = 0;
                    CRUDTurno.Apertura(Turno);

                    MessageBox.Show("Turno Cerrado");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
