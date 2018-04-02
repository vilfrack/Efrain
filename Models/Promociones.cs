using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Promociones
    {
        public int IDPromociones { get; set; }
        public int IDTipoDescuento { get; set; }
        public string descripcion { get; set; }
        public string status { get; set; }
        public decimal descuento { get; set; }
        public string tipo { get; set; }
        public decimal tipopromocion { get; set; }
        public string lunesinicio { get; set; }
        public string lunesfin { get; set; }
        public bool aplicalunes { get; set; }
        public decimal lunesdiasalida { get; set; }
        public string martesinicio { get; set; }
        public string martesfin { get; set; }
        public bool aplicamartes { get; set; }
        public decimal martesdiasalida { get; set; }
        public string miercolesinicio { get; set; }
        public string miercolesfin { get; set; }
        public bool aplicamiercoles { get; set; }
        public decimal miercolesdiasalida { get; set; }
        public string juevesinicio { get; set; }
        public string juevesfin { get; set; }
        public bool aplicajueves { get; set; }
        public decimal juevesdiasalida { get; set; }
        public string viernesinicio { get; set; }
        public string viernesfin { get; set; }
        public bool aplicaviernes { get; set; }
        public decimal viernesdiasalida { get; set; }
        public string sabadoinicio { get; set; }
        public string sabadofin { get; set; }
        public bool aplicasabado { get; set; }
        public string domingoinicio { get; set; }
        public decimal sabadodiasalida { get; set; }
        public string domingofin { get; set; }
        public bool aplicadomingo { get; set; }
        public decimal domingodiasalida { get; set; }
        public bool visualizar { get; set; }
        public decimal Relacionuno { get; set; }
        public decimal Relaciondos { get; set; }
        public bool forzarporproducto { get; set; }
    }
}
