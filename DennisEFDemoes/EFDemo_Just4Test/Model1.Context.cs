﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDemo_Just4Test
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class waspEntities : DbContext
    {
        public waspEntities()
            : base("name=waspEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ConfigInfo> ConfigInfoes { get; set; }
        public virtual DbSet<FilePublishInfo> FilePublishInfoes { get; set; }
        public virtual DbSet<FilePublishStrategy> FilePublishStrategies { get; set; }
        public virtual DbSet<JobInfo> JobInfoes { get; set; }
        public virtual DbSet<MetricsInfo> MetricsInfoes { get; set; }
        public virtual DbSet<MonitorInfo> MonitorInfoes { get; set; }
        public virtual DbSet<OpsRecord> OpsRecords { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<FilePublishStrategyView> FilePublishStrategyViews { get; set; }
        public virtual DbSet<JobMetricsView> JobMetricsViews { get; set; }
    }
}
