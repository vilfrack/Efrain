using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MasterInsumos
    {
        public int IDMasterInsumos { get; set; }
        public int IDInsumos { get; set; }
        public int IDMenu { get; set; }
        public decimal Cantidad { get; set; }
    }
}
