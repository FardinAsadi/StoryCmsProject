using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class Post
    {
        public int Id { get; set; } // Id (Primary key)
        public DateTime CreateDate { get; set; } // CreateDate
        public string DefaultImage { get; set; } // DefaultImage
        public int DisplayOrder { get; set; } // DisplayOrder
        public string CreatorCode { get; set; } // CreatorCode
        public int? PostsCategoriesId { get; set; } // PostsCategoriesId
        public bool Special { get; set; } // Special
        public bool Publish { get; set; } // Publish
        public DateTime UpdateDate { get; set; } // UpdateDate

        //localize
        public string Title { get; set; } // Title
        public string Source { get; set; } // Source
        public string Keywords { get; set; } // Keywords
        public string Abstract { get; set; } // Abstract
        public string Desc { get; set; } // Desc
        public string UrlCategory1 { get; set; } // UrlCategory1
        public string UrlCategory2 { get; set; } // UrlCategory2
        public string UrlKeywords { get; set; } // UrlKeywords
        public string Tags { get; set; } // Tags


    }
}