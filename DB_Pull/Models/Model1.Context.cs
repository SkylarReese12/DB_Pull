﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Pull.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuestEntities : DbContext
    {
        public QuestEntities()
            : base("name=QuestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<CompetitionLevel> CompetitionLevels { get; set; }
        public virtual DbSet<ComputerProgram> ComputerPrograms { get; set; }
        public virtual DbSet<LiabilityForm> LiabilityForms { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<SchoolList> SchoolLists { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
