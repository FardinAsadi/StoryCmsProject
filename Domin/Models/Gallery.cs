using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domin.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public int GalleryCategoryId { get; set; }
        public string Path { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Avalible { get; set; }
        public bool? Deleted { get; set; } // Deleted
        public decimal? CostDownload { get; set; } // CostDownload
        public string Title { get; set; } // Title
        public string Desc { get; set; } // Desc
        public GalleryCategory GalleryCategory { get; set; }



    }
}