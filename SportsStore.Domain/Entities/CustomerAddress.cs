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
    
    public partial class CustomerAddress
    {
        public int CustomerAddressID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
        public string PostalCode { get; set; }
        public int CountryID { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> IsBillingAddress { get; set; }
        public Nullable<bool> IsShippingAddress { get; set; }
    }
}
