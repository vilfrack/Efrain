//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoDescuento
    {
        public int IDTipoDescuento { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<bool> Visible { get; set; }
    }
}