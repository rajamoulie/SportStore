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
    
    public partial class ProductSpecificationAttributeMapping
    {
        public int ProductSpecificationAttributeMappingID { get; set; }
        public int ProductID { get; set; }
        public int AttributeTypeID { get; set; }
        public int SpecificationAttributeOptionId { get; set; }
        public string CustomValue { get; set; }
        public bool AllowFiltering { get; set; }
        public bool ShowOnProductPage { get; set; }
        public int DisplayOrder { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SpecificationAttributeOption SpecificationAttributeOption { get; set; }
    }
}
