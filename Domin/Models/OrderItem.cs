using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class OrderItem
    {
        public int Id { get; set; } // Id (Primary key)
        public int OrderId { get; set; } // OrderId
        public int? ProductId { get; set; } // ProductId
        public decimal Quantity { get; set; } // Quantity
        public decimal DiscountAmount { get; set; } // DiscountAmount
        public decimal OriginalProductCost { get; set; } // OriginalProductCost
        public decimal TaxAmount { get; set; } // TaxAmount
        public string Desc { get; set; } // Desc
        public string CountUnitSymbol { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<OrderItemDetails> OrderItemDetails { get; set; }

    }
}