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
    
    public partial class BasicTaxRate
    {
        public int BasicTaxRateID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> StateID { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public decimal Rate { get; set; }
        public bool IsActive { get; set; }
        public string Group { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
