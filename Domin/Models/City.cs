using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class City
    {
        public int Id { get; set; } // Id (Primary key)
        public bool Show { get; set; } // Show
        public int ProvincesId { get; set; } // ProvincesId
        public int DisplayOrder { get; set; } // DisplayOrder
        public string MapPath { get; set; } // MapPath
        public string Coords { get; set; } // Coords
        public string CreatorCode { get; set; } // CreatorCode
                                                //localize
        public string Name { get; set; }


        public virtual ICollection<Address> Address { get; set; }
    }
}