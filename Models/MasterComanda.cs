﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MasterComanda
    {
        public int IDMasterComanda { get; set; }
        public int IDComanda { get; set; }
        public int IDMenu { get; set; }
        public decimal Precio { get; set; }
    }
}
