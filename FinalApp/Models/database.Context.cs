//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CapstoneEntities : DbContext
    {
        public CapstoneEntities()
            : base("name=CapstoneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bills> bills { get; set; }
        public virtual DbSet<hospital> hospital { get; set; }
        public virtual DbSet<hospitalLogin> hospitalLogin { get; set; }
        public virtual DbSet<insuranceLogin> insuranceLogin { get; set; }
        public virtual DbSet<medicalLogin> medicalLogin { get; set; }
        public virtual DbSet<patient> patient { get; set; }
    }
}
