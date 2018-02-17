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
        public static int SetIDMesas = 0;
        public static int SetNumeroMesa = 0;
        public static int SetCantidadPersona = 0;

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
            string s1 = "ss";
            string s2 = "ww";
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
                panel.BackColor = Color.LightGray;
                //CREAMOS LOS PictureBox
                PictureBox PictureBox = new PictureBox();
                PictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\mesa.png"));
                PictureBox.Width = 162;
                PictureBox.Height = 100;
                PictureBox.BackColor = Color.Bisque;
                panel.Controls.Add(PictureBox);
                //CREAMOS LOS LABELS PARA LAS DIFERENTES MESAS
                Label LabelNumeroMesa = new Label();
                LabelNumeroMesa.Name = "label" + item.IDMesas;
                LabelNumeroMesa.Location = new Point(5,104);
                LabelNumeroMesa.Width = 150;
                LabelNumeroMesa.Height = 13;
                LabelNumeroMesa.Text = "Numero de mesa: "+ Convert.ToString(item.NumeroMesa);
                //CANTIDAD DE COMENSALES
                Label LabelCantidad = new Label();
                LabelCantidad.Location = new Point(5, 120);
                LabelCantidad.Width = 150;
                LabelNumeroMesa.Height = 13;
                LabelCantidad.Text = "Cantidad de comensales: " + Convert.ToString(item.CantidadPersona);
                // DISPONIBILIDAD
                Label LabelDisponible = new Label();
                LabelDisponible.Location = new Point(5, 140);
                LabelDisponible.TextAlign = ContentAlignment.MiddleCenter;
                LabelDisponible.Width = 150;
                LabelDisponible.ForeColor = Color.Green;
                LabelDisponible.Font = new Font("Arial", 8, FontStyle.Bold);
                LabelDisponible.Text = "DISPONIBLE";
                //se crea el boton de seleccionar
                Button btnSeleccionar = new Button();
                btnSeleccionar.Name = "btn" + item.IDMesas;
                btnSeleccionar.Width = 150;
                btnSeleccionar.Text = "SELECCIONAR";
                btnSeleccionar.Location = new Point(5, 160);
                btnSeleccionar.Height = 30;
                btnSeleccionar.BackColor = Color.WhiteSmoke;
                //btnSeleccionar.Click += new EventHandler(panel_Click);
                btnSeleccionar.Click += delegate(object senderButton, EventArgs eButton) { btnSeleccionarHandler(senderButton, eButton, item.IDMesas, item.NumeroMesa,item.CantidadPersona); };

                //agremos los labels al panel
                panel.Controls.Add(LabelDisponible);
                panel.Controls.Add(LabelNumeroMesa);
                panel.Controls.Add(LabelCantidad);
                //se agrega el boton
                panel.Controls.Add(btnSeleccionar);
                //panel.Click += new EventHandler(panel_Click);
                panelContenedor.Controls.Add(panel);

            }
        }


        private void btnSeleccionarHandler(object sender, EventArgs e, int IDMesas, int NumeroMesa,int CantidadPersona)
        {
            SetIDMesas = IDMesas;
            SetNumeroMesa = NumeroMesa;
            SetCantidadPersona = CantidadPersona;

            ComandaDetalleForm ComandaDetalleForm = new ComandaDetalleForm();
            ComandaDetalleForm.Show();
        }
    }
}
