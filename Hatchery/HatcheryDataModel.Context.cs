﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hatchery
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HatcheryEntities : DbContext
    {
        public HatcheryEntities()
            : base("name=HatcheryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BroodStockMonitoring> BroodStockMonitorings { get; set; }
        public DbSet<DailyMonitoringPostLarvaLengkap> DailyMonitoringPostLarvaLengkaps { get; set; }
        public DbSet<MasterBatch> MasterBatches { get; set; }
        public DbSet<MasterModule> MasterModules { get; set; }
        public DbSet<MasterStage> MasterStages { get; set; }
        public DbSet<ProductionCycle> ProductionCycles { get; set; }
        public DbSet<DailyMonitoringPostLarva> DailyMonitoringPostLarvas { get; set; }
        public DbSet<WaterParameterPostLarva> WaterParameterPostLarvas { get; set; }
        public DbSet<Harvest> Harvests { get; set; }
    }
}
