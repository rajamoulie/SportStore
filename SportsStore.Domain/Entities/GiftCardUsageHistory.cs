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
    
    public partial class GiftCardUsageHistory
    {
        public int GiftCardUsageHistoryID { get; set; }
        public int GiftCardID { get; set; }
        public int UsedWithOrderID { get; set; }
        public decimal UsedValue { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
    
        public virtual GiftCard GiftCard { get; set; }
        public virtual Order Order { get; set; }
    }
}
