﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2016_17_S_CC6001NI_14046931_Kiran_Shahi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UniversalSportsHubEntities : DbContext
    {
        public UniversalSportsHubEntities()
            : base("name=UniversalSportsHubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACTIVITy> ACTIVITIES { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERS { get; set; }
        public virtual DbSet<EQUIP_SESS> EQUIP_SESS { get; set; }
        public virtual DbSet<EQUIPMENT> EQUIPMENTS { get; set; }
        public virtual DbSet<ROOM> ROOMS { get; set; }
        public virtual DbSet<SESSION_STAFF> SESSION_STAFF { get; set; }
        public virtual DbSet<SESSION> SESSIONS { get; set; }
        public virtual DbSet<STAFF> STAFFS { get; set; }
    }
}
