using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Utilidades
{
    public class Utilidades
    {
        public Utilidades() {

        }
        public void ValidarSoloNumeros(object sender, KeyPressEventArgs e, TextBox texbox) {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                //PERMITE BORRAR LO QUE SE ESCRIBE

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
        }
        public void ValidarSoloNumerosDecimales(object sender, KeyPressEventArgs e, TextBox texbox)
        {
            if (texbox.Text.Contains(','))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
        public void ConfiguracionGridview(DataGridView GridView) {
            // quitar triangulo negro
            GridView.RowHeadersVisible = false;
            // seleccionar desde el checkbox
            GridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            // insertar check en el grid
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Seleccionar";
            checkBoxColumn.Width = 90;

            checkBoxColumn.TrueValue = 't';
            checkBoxColumn.FalseValue = 'f';

            checkBoxColumn.Name = "check";
            GridView.Columns.Insert(0, checkBoxColumn);
        }
        public void ConfiguracionGridviewSinSeleccionar(DataGridView GridView)
        {
            // quitar triangulo negro
            GridView.RowHeadersVisible = false;

        }
        public void ConfiguracionFormulario(Form formulario) {
            //inicia en el centro de la pantalla
            formulario.StartPosition = FormStartPosition.CenterScreen;
            //se oculta el boton de minimizar
            formulario.MinimizeBox = false;
            //se oculta el boton de maximizar
            formulario.MaximizeBox = false;
            //evitamos que el usuario pueda modificar el tamaño de los formularios
            formulario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //quitamos el boton (X) de los formularios
            formulario.ControlBox = false;
        }

    }
}
