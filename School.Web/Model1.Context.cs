﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.Web
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BW_6PMEntities : DbContext
    {
        public BW_6PMEntities()
            : base("name=BW_6PMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentParent> StudentParents { get; set; }
        public virtual DbSet<Student_Backup> Student_Backup { get; set; }
        public virtual DbSet<Student_Backup1> Student_Backup1 { get; set; }
    }
}
