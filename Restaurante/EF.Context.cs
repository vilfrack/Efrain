﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurante
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDResEntities : DbContext
    {
        public BDResEntities()
            : base("name=BDResEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Comanda> Comanda { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Insumos> Insumos { get; set; }
        public virtual DbSet<MasterCierreCuenta> MasterCierreCuenta { get; set; }
        public virtual DbSet<MasterComanda> MasterComanda { get; set; }
        public virtual DbSet<MasterInsumos> MasterInsumos { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Mesas> Mesas { get; set; }
        public virtual DbSet<Mesoneros> Mesoneros { get; set; }
        public virtual DbSet<ServicioDomicilio> ServicioDomicilio { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }
        public virtual DbSet<Prueba> Prueba { get; set; }
    }
}
