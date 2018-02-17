using Datos;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //180
            int x = 12;
            int y = 12;
            int contador = 0;
            foreach (var item in ListMesas)
            {
                if (contador!=0)
                {
                    x = x + 168;
                }
                if (contador ==4)
                {
                    contador = 0;
                    y = y + 200;
                    x = 12;
                }
                contador++;
                Panel panel = new Panel();
                panel.Width = 162;
                panel.Height = 191;
                panel.Location = new Point(x, y);
                panel.BackColor = Color.Aqua;
                //CREAMOS LOS PictureBox
                PictureBox PictureBox = new PictureBox();
                PictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\mesa.png"));
                PictureBox.Width = 162;
                PictureBox.Height = 100;
                PictureBox.BackColor = Color.Bisque;
                panel.Controls.Add(PictureBox);
                //CREAMOS LOS LABELS PARA LAS DIFERENTES MESAS
                Label LabelNumeroMesa = new Label();
                LabelNumeroMesa.Location = new Point(5,105);
                LabelNumeroMesa.Width = 150;
                //LabelNumeroMesa.BackColor = Color.Black;
                LabelNumeroMesa.Text = "Numero de mesa: "+ Convert.ToString(item.NumeroMesa);

                Label LabelCantidad = new Label();
                LabelCantidad.Location = new Point(5, 128);
                LabelCantidad.Width = 150;
                LabelCantidad.Text = "Cantidad de comensales: " + Convert.ToString(item.CantidadPersona);
                //agremos los labels al panel
                panel.Controls.Add(LabelNumeroMesa);
                panel.Controls.Add(LabelCantidad);

                panelContenedor.Controls.Add(panel);
            }
        }

    }
}
