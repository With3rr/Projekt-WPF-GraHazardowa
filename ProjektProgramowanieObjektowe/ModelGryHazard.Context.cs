﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektProgramowanieObjektowe
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BazaGryHazardoweEntities : DbContext
    {
        public BazaGryHazardoweEntities()
            : base("name=BazaGryHazardoweEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Konto> Konto { get; set; }
        public virtual DbSet<Visa> Visa { get; set; }
        public virtual DbSet<KontaBankowe> KontaBankowe { get; set; }
        public virtual DbSet<Wyplaty> Wyplaty { get; set; }
        public virtual DbSet<Wplaty> Wplaty { get; set; }
        public virtual DbSet<PaySafe> PaySafe { get; set; }
        public virtual DbSet<RozegraneeGry> RozegraneeGry { get; set; }
        public virtual DbSet<ZasadyGry> ZasadyGry { get; set; }
    }
}
