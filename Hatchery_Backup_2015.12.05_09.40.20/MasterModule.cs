//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MasterModule
    {
        public MasterModule()
        {
            this.DailyMonitoringPostLarvaLengkaps = new HashSet<DailyMonitoringPostLarvaLengkap>();
            this.ProductionCycles = new HashSet<ProductionCycle>();
        }
    
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public Nullable<double> Tonnage { get; set; }
        public Nullable<double> Volume { get; set; }
        public Nullable<double> Area { get; set; }
        public Nullable<double> Depth { get; set; }
        public string UserID { get; set; }
    
        public virtual ICollection<DailyMonitoringPostLarvaLengkap> DailyMonitoringPostLarvaLengkaps { get; set; }
        public virtual ICollection<ProductionCycle> ProductionCycles { get; set; }
    }
}
