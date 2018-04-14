using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class Province
    {
        public int Id { get; set; }
        public int? CountryId { get; set; } // CountryId
        public int DisplayOrder { get; set; } // DisplayOrder
        public bool Show { get; set; } // Show
        public int EntitiesId { get; set; } // EntitiesId
        public string MapPath { get; set; } // MapPath
        public string Coords { get; set; } // Coords
        public string CreatorCode { get; set; } // CreatorCode
        //localize
        public string Name { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}