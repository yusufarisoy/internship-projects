//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArticleForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.ArticleCategoryRelations = new HashSet<ArticleCategoryRelation>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string TitleUrl { get; set; }
        public string ContentSummary { get; set; }
        public bool VisitCheck { get; set; }
        public string FullContent { get; set; }
        public string ImageSrc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleCategoryRelation> ArticleCategoryRelations { get; set; }
    }
}