using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class ProductDiscount
    {
        public int Id { get; set; }
        public int ProductID   { get; set; }
        public decimal DiscountPercent { get; set; }
        public virtual Product Product { get; set; }



    }
}