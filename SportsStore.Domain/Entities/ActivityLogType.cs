//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsStore.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivityLogType
    {
        public ActivityLogType()
        {
            this.ActivityLog = new HashSet<ActivityLog>();
        }
    
        public int ActivityLogTypeID { get; set; }
        public string SystemKeyword { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    
        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
    }
}
