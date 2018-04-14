using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class UserDiscount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal DiscountPercent { get; set; }
        public virtual User User { get; set; }
    }
}