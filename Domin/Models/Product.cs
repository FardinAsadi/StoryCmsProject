using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Domin.Models
{
    public enum ProductStatus
    {

    }

    public class Product
    {

        public int Id { get; set; } // Id (Primary key)
        public bool IsShipEnabled { get; set; } // IsShipEnabled
        public decimal StockQuantity { get; set; } // StockQuantity
        [DisplayName("قیمت")]
        public decimal Price { get; set; } // Price
        public decimal? SpecialPrice { get; set; } // SpecialPrice
        public bool? Deleted { get; set; } // Deleted
        public DateTime CreatedOn { get; set; } // CreatedOn
        public DateTime UpdatedOn { get; set; } // UpdatedOn
        public int ProductCategoryId { get; set; } // ProductCategoryId
        public string Image { get; set; } // Image
        public ProductStatus Status { get; set; } // Status
        public int DisplayOrder { get; set; } // DisplayOrder
        public double? AdminRating { get; set; } // AdminRating
        public string Code { get; set; } // Code
        public bool Special { get; set; } // Special
        public string CreatorCode { get; set; } // CreatorCode
        public int? CustomersId { get; set; } // CustomersId
        public bool Publish { get; set; } // Publish
        public bool ShowOnHomePage { get; set; } // ShowOnHomePage
        public bool ComingSoon { get; set; } // ComingSoon
        public int? StockQuantityAlert { get; set; } // StockQuantityAlert
        public int? PurchaseAmountLimit { get; set; } // PurchaseAmountLimit
        public bool New { get; set; } // New
        public decimal? ValueRatio { get; set; } // ValueRatio

        public virtual ICollection<ProductSpec> ProductSpecs { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }
        public virtual ICollection<GalleryCategory> GalleryCategories { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }





    }
}