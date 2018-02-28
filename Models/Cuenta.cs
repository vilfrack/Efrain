using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cuenta
    {
        public int IDCuenta { get; set; }
        public int IDMesas { get; set; }
        public int IDMesoneros { get; set; }
        public int IDCliente { get; set; }
        public string Reserva { get; set; }
        public DateTime Apertura { get; set; }
        public DateTime Cierre { get; set; }
        public string Orden { get; set; }
        public string Comisionista { get; set; }
        public string Folio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Propina { get; set; }
        public string Status { get; set; }
    }
}
