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
    
    public partial class News
    {
        public News()
        {
            this.NewsComment = new HashSet<NewsComment>();
        }
    
        public int NewsID { get; set; }
        public int LanguageID { get; set; }
        public string Title { get; set; }
        public string Short { get; set; }
        public string Full { get; set; }
        public bool Published { get; set; }
        public Nullable<System.DateTime> StartDateUtc { get; set; }
        public Nullable<System.DateTime> EndDateUtc { get; set; }
        public bool AllowComments { get; set; }
        public int CommentCount { get; set; }
        public bool LimitedToStores { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual ICollection<NewsComment> NewsComment { get; set; }
    }
}
