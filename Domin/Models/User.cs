using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class User
    {
        public int Id { get; set; }
     //   [Key, ForeignKey("aspnet_Users")]
     
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BirthDay { get; set; }
        public virtual ICollection<UserDiscount> UserDiscounts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

  //      public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }





    }
}