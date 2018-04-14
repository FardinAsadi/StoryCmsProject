using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class Payment
    {
        public int Id { get; set; } // Id (Primary key)
        public int? AccountsId { get; set; } // AccountsId
        public long OrderNumber { get; set; } // OrderNumber
        public string LastFourDigit { get; set; } // LastFourDigit
        public DateTime RequestDateTime { get; set; } // RequestDateTime
        public DateTime? PaymentDateTime { get; set; } // PaymentDateTime
        public DateTime? ApprovalDateTime { get; set; } // ApprovalDateTime
        public string Ip { get; set; } // Ip
        public string Amount { get; set; } // Amount
        public PaymentStatus Status { get; set; } // Status
        public string BankName { get; set; } // BankName
        public string TrackingNumber { get; set; } // TrackingNumber
        public string AccountOwner { get; set; } // AccountOwner
        public string Desc { get; set; } // Desc
        public string Exp { get; set; } // Exp
        public int? OrdersId { get; set; } // OrdersId
        public long? BankOrderNumber { get; set; } // BankOrderNumber
        public string ExtraParam1 { get; set; } // ExtraParam1
        public string ExtraParam2 { get; set; } // ExtraParam2
        public string CreatorCode { get; set; } // CreatorCode
    }
}