using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public enum PostType
    {

    }
    public class PostCategory
    {
        public int Id { get; set; } // Id (Primary key)
        public int? PostsCategoriesId { get; set; } // PostsCategoriesId
        public int EntitiesId { get; set; } // EntitiesId
        public int DisplayOrder { get; set; } // DisplayOrder
        public DateTime CreateDateTime { get; set; } // CreateDateTime
        public DateTime UpdateDateTime { get; set; } // UpdateDateTime
        public PostType Type { get; set; } // Type
        public string Color { get; set; }

        //localize
  
        public string Title { get; set; } // Title
        public string Description { get; set; } // Description
        public int LanguagesId { get; set; } // LanguagesId
        public string MetaKeywords { get; set; } // MetaKeywords
        public string MetaDescription { get; set; } // MetaDescription
        public string UrlCategory1 { get; set; } // UrlCategory1
        public string UrlCategory2 { get; set; } // UrlCategory2
        public string UrlCategory3 { get; set; } // UrlCategory3

        public string Image { get; set; } // Image
        public virtual ICollection<Post> Posts{ get; set; }


        


    }
}