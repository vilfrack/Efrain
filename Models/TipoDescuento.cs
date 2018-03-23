using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TipoDescuento
    {
        public int IDTipoDescuento { get; set; }
        public string Descripcion { get; set; }
        public decimal Descuento { get; set; }
        public bool Visible { get; set; }
    }
}
