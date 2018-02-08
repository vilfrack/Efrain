using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class EnvioDomicilio
    {
        public int IDDomicilio { get; set; }
        public int IDCliente { get; set; }
        public string Calle { get; set; }
        public string Direccion { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Cruzamientos { get; set; }
        public string Cruzamientos2 { get; set; }
        public string Colonia { get; set; }// Se debe seleccionar una colonia, creadas en el catálogo de colonias
        public string Zona { get; set; }//La zona está ligada a la colonia, al seleccionar la colonia muestra la zona a la que pertenece
        public string Referencia { get; set; }
        public string Ciudad { get; set; }
        public string Delegación { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CP { get; set; }

    }
}
