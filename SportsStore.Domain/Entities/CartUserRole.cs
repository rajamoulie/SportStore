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
    
    public partial class CartUserRole
    {
        public int CustomerID { get; set; }
        public int CartRoleID { get; set; }
    
        public virtual CartRole CartRole { get; set; }
    }
}
