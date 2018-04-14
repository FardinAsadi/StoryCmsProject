using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class ProductSpec
    {
        public int Id { get; set; }
        public int ProductSpecCategoryId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }     
        public virtual ProductSpecCategory ProductSpecCategory { get; set; }
    }
}