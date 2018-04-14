using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
   public enum OrderStatus
    {

    }
    public  enum PaymentStatus
    {

    }
    public enum OrderType
    {

    }
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string InvoicNumber { get; set; }

        public int CustomerId { get; set; } // CustomerId
        public OrderStatus OrderStatus { get; set; } // OrderStatus
        public PaymentStatus PaymentStatus { get; set; } // PaymentStatus
        public string PaymentMethodSystemName { get; set; } // PaymentMethodSystemName
        public string CustomerIp { get; set; } // CustomerIp
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber
        public DateTime? MoneyReceptionDate { get; set; } // MoneyReceptionDate
        public bool Deleted { get; set; } // Deleted
        public DateTime CreatedOn { get; set; } // CreatedOn
        public OrderType OrderType { get; set; } // OrderType
        public int? RestaurantsId { get; set; } // RestaurantsId
        public string CreatorCode { get; set; } // CreatorCode
        public string AddressDetails { get; set; } // AddressDetails
        public decimal DiscountAmount { get; set; } // DiscountAmount
        public string Desc { get; set; } // Desc
        public string RecipientMobilNumber { get; set; } // RecipientMobilNumber
        public string RecipientPhoneNumber { get; set; } // RecipientPhoneNumber
        public string RecipientName { get; set; } // RecipientName
        public string PostalCode { get; set; } // PostalCode
        public bool RequiredInvoice { get; set; } // RequiredInvoice
        public decimal? AdditionalCharges { get; set; } // AdditionalCharges
        public string OrderNumber { get; set; } // OrderNumber



        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<OrderDiscount> OrderDiscounts { get; set; }
        public virtual User User { get; set; }





    }
}