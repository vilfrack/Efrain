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
    public partial class ComandaForm : Form
    {
        Utilidades.Utilidades utilidades = new Utilidades.Utilidades();
        public CRUDComanda CRUDComanda = new CRUDComanda();

        public ComandaForm()
        {
            InitializeComponent();
        }

        private void ComandaForm_Load(object sender, EventArgs e)
        {
            ComandaForm ComandaForm = new ComandaForm();
            utilidades.ConfiguracionFormulario(ComandaForm);
            List<Mesas> ListMesas = new List<Mesas>();

            ListMesas.AddRange(CRUDComanda.DatosMesas());
        }

    }
}
