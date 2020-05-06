using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;

namespace VinylStore.ViewModels
{
    public class ArtistViewModel
    {
       public IEnumerable<Artist> AllArtists { get; set; }
    }
}
