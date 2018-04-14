using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class ProductCategory
    {
        public int Id { get; set; } // Id (Primary key)
        public bool ShowOnHomePage { get; set; } // ShowOnHomePage
        public bool HasDiscountsApplied { get; set; } // HasDiscountsApplied
        public DateTime CreatedOn { get; set; } // CreatedOn
        public DateTime UpdatedOn { get; set; } // UpdatedOn
        public string Image { get; set; } // Image
        public int? ProductsCategoriesId { get; set; } // ProductsCategoriesId
        public int DisplayOrder { get; set; } // DisplayOrder
        public bool Type { get; set; } // Type
        public bool Deleted { get; set; } // Deleted
        public int? EntitiesId { get; set; } // EntitiesId
        public string CreatorCode { get; set; } // CreatorCode
        public string BackgroundColor { get; set; } // BackgroundColor
        public ICollection<ProductSpecCategory> ProductSpecCategories { get; set; }
        public virtual ICollection<Product> Products{ get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }
 


    }
}