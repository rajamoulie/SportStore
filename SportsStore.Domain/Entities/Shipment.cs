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
    
    public partial class Shipment
    {
        public Shipment()
        {
            this.ShipmentItem = new HashSet<ShipmentItem>();
        }
    
        public int ShipmentID { get; set; }
        public int OrderID { get; set; }
        public string TrackingNumber { get; set; }
        public Nullable<decimal> TotalWeight { get; set; }
        public Nullable<System.DateTime> ShippedDateUtc { get; set; }
        public Nullable<System.DateTime> DeliveryDateUtc { get; set; }
        public string AdminComment { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItem { get; set; }
    }
}