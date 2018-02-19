﻿using Datos;
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
    public partial class ComandaDetalleForm : Form
    {
        public ComandaDetalleForm()
        {
            InitializeComponent();
        }

        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public CRUDInsumos CRUDInsumos = new CRUDInsumos();

        private int IDMesas = 0;
        private int NumeroMesa = 0;
        private int CantidadPersona = 0;

        private void ComandaDetalleForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);

            ComandaForm ComandaForm = new ComandaForm();

            IDMesas = ComandaForm.SetIDMesas;
            NumeroMesa = ComandaForm.SetNumeroMesa;
            CantidadPersona = ComandaForm.SetCantidadPersona;

            ComboGrupos();
        }

        private void ComboGrupos()
        {
            DataTable dtGrupos = new DataTable();
            dtGrupos = CRUDInsumos.GruposComboBox();
            comboGrupoBusqueda.ValueMember = "IDGrupo";
            comboGrupoBusqueda.DisplayMember = "Descripcion";
            comboGrupoBusqueda.DataSource = dtGrupos;
        }
    }
}