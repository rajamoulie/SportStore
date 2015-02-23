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
    
    public partial class ProductAttributeValue
    {
        public int ProductAttributeValueID { get; set; }
        public int ProductAttributeMappingID { get; set; }
        public int AttributeValueTypeID { get; set; }
        public int AssociatedProductID { get; set; }
        public string Name { get; set; }
        public string ColorSquaresRgb { get; set; }
        public decimal PriceAdjustment { get; set; }
        public decimal WeightAdjustment { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
        public int PictureID { get; set; }
    
        public virtual ProductProductAttributeMapping ProductProductAttributeMapping { get; set; }
    }
}
