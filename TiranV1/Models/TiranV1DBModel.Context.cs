﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiranV1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TiranV1DBEntities : DbContext
    {
        public TiranV1DBEntities()
            : base("name=TiranV1DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Candidate_Tbl> Candidate_Tbl { get; set; }
        public DbSet<Category_Tbl> Category_Tbl { get; set; }
        public DbSet<Skills_Tbl> Skills_Tbl { get; set; }
    }
}
