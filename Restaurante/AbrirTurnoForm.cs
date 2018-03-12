using Datos;
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
    public partial class AbrirTurnoForm : Form
    {
        public AbrirTurnoForm()
        {
            InitializeComponent();
        }
        public Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public Utilidades.Status Status = new Utilidades.Status();
        public CRUDTurno CRUDTurno = new CRUDTurno();
        public Turno Turno = new Turno();

        private void btnAbrirTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFondoInicial.Text == "")
                {
                    MessageBox.Show("DEBE INDICAR UN FONDO INICIAL");
                }
                else
                {
                    Turno.Apertura = DateTime.Now;
                    Turno.StatusTurno = Status.Abierta;
                    Turno.FondoInicial = Convert.ToDecimal(txtFondoInicial.Text);
                    CRUDTurno.Apertura(Turno);
                    MessageBox.Show("Registro agregado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ ex.Message);
            }

        }

        private void AbrirTurnoForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
        }

        private void txtFondoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.ValidarSoloNumerosDecimales(sender,e, txtFondoInicial);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
