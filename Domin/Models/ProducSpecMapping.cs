using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class ProducSpecMapping
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductSpecId { get; set; }
        public string Value { get; set; }
        public decimal Price { get; set; }
        public Product Product{ get; set; }
        public ProductSpec ProductSpec { get; set; }
    }
}