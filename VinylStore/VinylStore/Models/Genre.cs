using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}
