using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public enum GalleryType
    {

    }
    public class GalleryCategory
    {


        public int Id { get; set; } // Id (Primary key)
        public int? ProductId { get; set; } // ProductsId
        public GalleryType GalleryType { get; set; } // Type
        public int? PortfolioAndNewDecorationId { get; set; } // PortfolioAndNewDecorationId
        public int? SuggestionsId { get; set; } // SuggestionsId
        public int EntitiesId { get; set; } // EntitiesId
        public int? RestaurantsId { get; set; } // RestaurantsId
        public int? EatingsId { get; set; } // EatingsId
        public string CreatorCode { get; set; } // CreatorCode
        public int? GalleriesCategoriesId { get; set; } // GalleriesCategoriesId
        public int? PartnersId { get; set; } // PartnersId
        public int? CustomersId { get; set; } // CustomersId


        //localize
        public string Title { get; set; } // Title
        public string UrlCategory1 { get; set; } // UrlCategory1
        public string UrlCategory2 { get; set; } // UrlCategory2
        public string UrlCategory3 { get; set; } // UrlCategory3
        public virtual ICollection<Gallery> Galleries{ get; set; }
        public virtual Product Product { get; set; }

    }
}