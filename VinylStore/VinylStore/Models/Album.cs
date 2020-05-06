using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
        public List<Vinyl> Vinyls { get; set; }
    }
}
