using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Insumos
    {
        public int IDInsumos { get; set; }
        public int IDGrupos { get; set; }
        public string Descripcion { get; set; }
        public double UnidadMedida { get; set; }
        public double UltimoCosto { get; set; }
        public double CostoPromedio { get; set; }
        public double CostoImpuesto { get; set; }
        public double IVA { get; set; }
        public bool Inventariable { get; set; }
    }
}
