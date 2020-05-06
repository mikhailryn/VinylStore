using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }


    }
}
