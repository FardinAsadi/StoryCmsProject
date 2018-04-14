using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class OrderDiscount
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal DiscountPercent { get; set; }
        public virtual Order Order { get; set; }


    }
}