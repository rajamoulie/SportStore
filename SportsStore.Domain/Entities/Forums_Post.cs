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
    
    public partial class Forums_Post
    {
        public int ForumsPostID { get; set; }
        public int TopicID { get; set; }
        public int CustomerID { get; set; }
        public string Text { get; set; }
        public string IPAddress { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
        public System.DateTime UpdatedOnUtc { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Forums_Topic Forums_Topic { get; set; }
    }
}
