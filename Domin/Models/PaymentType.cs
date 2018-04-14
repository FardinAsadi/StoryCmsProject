using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
  public  enum BankAccountsType
    {

    }
    public class PaymentType
    {
        public int Id { get; set; } // Id (Primary key)
        public BankAccountsType Type { get; set; } // Type
        public int EntitiesId { get; set; } // EntitiesId
        public bool Deleted { get; set; }
        public bool? UsePercentage { get; set; }
        public decimal? Wage { get; set; }
    }
}