using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Turno
    {
        public int IDTurno { get; set; }
        public DateTime? Apertura { get; set; }
        public DateTime? Cerrar { get; set; }
        public string StatusTurno { get; set; }
        public decimal FondoInicial { get; set; }
        public decimal FondoFinal { get; set; }

    }
}
