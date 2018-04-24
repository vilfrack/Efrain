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
        Utilidades.Status status = new Utilidades.Status();

        CRUDComanda CRUDComanda = new CRUDComanda();
        CRUDTurno CRUDTurno = new CRUDTurno();

        public static int SetIDMesas = 0;
        public static int SetNumeroMesa = 0;
        public static int SetCantidadPersona = 0;
        public int _IDTurno = 0;
        public ComandaForm()
        {
            InitializeComponent();

        }
        //se crea dos contructores de ComandaForm, el vacio es cuado se llamada del menu principal, el otro cuando se llama de CuentaForm y se necesita
        //refrescar el gridview de CuentaForm al dar click en agregar cuenta
        public CuentaForm _CuentaForm;
        public ComandaForm(CuentaForm CuentaForm)
        {
            InitializeComponent();
            this._CuentaForm = CuentaForm;
        }

        private void ComandaForm_Load(object sender, EventArgs e)
        {
            utilidades.ConfiguracionFormulario(this);
            List<Models.Mesas> ListMesas = new List<Models.Mesas>();
            // se obtiene el turno
            _IDTurno = CRUDTurno.ObtenerIDTurnoAbierto(status.Abierta);

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
                LabelDisponible.Font = new Font("Arial", 8, FontStyle.Bold);

                //VALIDAMOS SI LA MESA ESTA DISPONIBLE
                string validar = CRUDComanda.DisponibilidadMesa(_IDTurno, status.Abierta,item.IDMesas);
                //FIN DE LA VALIDACION
                LabelDisponible.ForeColor = validar =="DISPONIBLE" ? Color.Green : Color.Red;
                LabelDisponible.Text = validar;

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

            //VALIDAMOS SI _CuentaForm ESTA VACIO O NO, EN CASO DE NO ESTAR VACIO SIGNIFICA QUE SE ESTA LLAMANDO AL FORMULARIO DESDE CuentaForm
            // Y ESTE SE USA PARA REFRESCAR EL GRID
            if (_CuentaForm==null)
            {
                ComandaDetalleForm ComandaDetalleForm = new ComandaDetalleForm();
                ComandaDetalleForm.ShowDialog();
            }
            else
            {
                using (var ComandaDetalleForm = new ComandaDetalleForm(_CuentaForm))
                {
                    ComandaDetalleForm.ShowDialog();
                }
            }


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
