using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Domin.Models
{
    public class Menu1
    {
        [DisplayName("شماره")]
        public int Id { get; set; }
        public int MenuId { get; set; }
        [DisplayName("نام")]
        public string Name{ get; set; }
        [DisplayName("پیوند")]
        public string Link { get; set; }
        [DisplayName("پیوند1")]
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public virtual Menu Menu { get; set; }



    }
}