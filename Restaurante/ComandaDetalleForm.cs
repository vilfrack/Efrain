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

        private int IDMesas = 0;
        private int NumeroMesa = 0;
        private int CantidadPersona = 0;

        private void ComandaDetalleForm_Load(object sender, EventArgs e)
        {
            ComandaDetalleForm ComandaDetalleForm = new ComandaDetalleForm();
            utilidades.ConfiguracionFormulario(ComandaDetalleForm);

            ComandaForm ComandaForm = new ComandaForm();

            IDMesas = ComandaForm.SetIDMesas;
            NumeroMesa = ComandaForm.SetNumeroMesa;
            CantidadPersona = ComandaForm.SetCantidadPersona;
        }
    }
}
