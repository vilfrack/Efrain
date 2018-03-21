using Restaurante;
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
    public partial class PruebaForm : Form
    {
        public PruebaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDResEntities BD = new BDResEntities();
            Restaurante.Prueba prueba = new Restaurante.Prueba();
            prueba.text = textBox1.Text;
            BD.Prueba.Add(prueba);
            BD.SaveChanges();
            this.pruebaTableAdapter.Fill(this.bDResDataSet.Prueba);
        }

        private void PruebaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDResDataSet.Prueba' table. You can move, or remove it, as needed.
            this.pruebaTableAdapter.Fill(this.bDResDataSet.Prueba);

        }
    }
}
