using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Domin.Models
{
    public class Menu
    {
        [DisplayName("شماره")]
        public int Id { get; set; }
        [DisplayName("نام")]
        public string Name{ get; set; }
        [DisplayName("پیوند")]
        public string Link { get; set; }
        [DisplayName("پیوند1")]
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public virtual ICollection<Menu1> MenuS{ get; set; }

        //public string GenerateSlug()
        //{
        //    string phrase = string.Format("{0}-{1}", Id, Name);

        //    //string str = RemoveAccent(phrase).ToLower();
        //    //// invalid chars           
        //    //str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
        //    //// convert multiple spaces into one space   
        //    //str = Regex.Replace(str, @"\s+", " ").Trim();
        //    //// cut and trim 
        //    //str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
        //    //str = Regex.Replace(str, @"\s", "-"); // hyphens   
        //    return phrase;
        //}

        //private string RemoveAccent(string text)
        //{
        //    byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
        //    return System.Text.Encoding.ASCII.GetString(bytes);
        //}

    }
}