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
    
    public partial class TierPrice
    {
        public int TierPriceID { get; set; }
        public int ProductID { get; set; }
        public int StoreID { get; set; }
        public Nullable<int> CustomerRoleID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual CartRole CartRole { get; set; }
        public virtual Product Product { get; set; }
    }
}