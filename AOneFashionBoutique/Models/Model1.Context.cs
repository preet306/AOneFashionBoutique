﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AOneFashionBoutique.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FashionBoutiqueEntities : DbContext
    {
        public FashionBoutiqueEntities()
            : base("name=FashionBoutiqueEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Design> Designs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
    }
}