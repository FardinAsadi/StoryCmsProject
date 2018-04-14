using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class Country
    {
        public int Id { get; set; } // Id (Primary key)
        public string ThreeLetterIsoCode { get; set; } // ThreeLetterIsoCode
        public int DisplayOrder { get; set; } // DisplayOrder
        public string MapPath { get; set; } // MapPath
        //localize                                    
        public string Name { get; set; } // Name
        public virtual ICollection<Address> Address { get; set; }

    }
}