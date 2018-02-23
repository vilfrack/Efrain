using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Comanda
    {
        public int IDComanda { get; set; }
        public int IDMesas { get; set; }
        public decimal TotalPrecio { get; set; }
        public string Status { get; set; }
        public DateTime Fecha { get; set; }
        public int IDMesoneros { get; set; }
    }
}
