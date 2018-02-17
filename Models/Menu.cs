using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Menu
    {
        public int IDMenu { get; set; }
        public int IDGrupo { get; set; }
        public int IDMasterInsumos { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
