using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class Address
    {
        public int Id { get; set; } // Id (Primary key)
        public string FirstName { get; set; } // FirstName
        public string LastName { get; set; } // LastName
        public string Email { get; set; } // Email
        public string Company { get; set; } // Company
        public string Address1Fa { get; set; } // Address1Fa
        public string Address2 { get; set; } // Address2
        public string PhoneNumber { get; set; } // PhoneNumber
        public string FaxNumber { get; set; } // FaxNumber
        public DateTime CreatedOn { get; set; } // CreatedOn
        public string Address1En { get; set; } // Address1En
        public int? RegionsId { get; set; } // RegionsId
        public int? NeighborhoodsId { get; set; } // NeighborhoodsId
        public int? CustomersId { get; set; } // CustomersId
        public int? ProvinceId { get; set; } // ProvincesId
        public int? CityId { get; set; } // CittiesId
        public int? CountryId { get; set; } // CountriesId
        public bool? IsDefault { get; set; } // IsDefault
        public string PostalCode { get; set; } // PastalCode
        public string MobileNumber { get; set; } // PastalCode
        public string NationalCode { get; set; } // NationalCode
        public virtual City City { get; set; }
        public virtual Province Province { get; set; }
        public virtual Country Country { get; set; }

    }
}