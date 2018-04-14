using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class OrderItemDetails
    {
        public int Id { get; set; } // Id (Primary key)
        public int OrderItemId { get; set; } // OrderItemsId
        public string OptionKey { get; set; } // OptionKey
        public string Value { get; set; } // Value
        public decimal Price { get; set; } // Price
        public virtual OrderItem OrderItem { get; set; }
    }
}