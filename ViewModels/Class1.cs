using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domin.Models;
namespace ViewModels
{

    public class MenuCrudModel
    {
        public Menu Menu { get; set; }
    }
    public class MenuJsonModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }
    }
    public class MenuDataTableModel : MenuJsonModel
    {
        public int Row { get; set; }
    }
}