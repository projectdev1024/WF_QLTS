﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_QLTS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbQLTSEntities : DbContext
    {
        public dbQLTSEntities()
            : base("name=dbQLTSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<MuonTB> MuonTBs { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<ThietBi> ThietBis { get; set; }
        public DbSet<CTMuonTB> CTMuonTBs { get; set; }
    }
}
