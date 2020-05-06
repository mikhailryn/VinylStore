using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class Vinyl
    {
        public int VinylId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Label { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsVinylOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }

    }
}
