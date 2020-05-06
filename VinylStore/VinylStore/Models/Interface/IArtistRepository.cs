using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models.Interface
{
  public interface IArtistRepository
    {
        IEnumerable<Artist> AllArtists { get; }
        void SaveArtist(Artist artist);
        Artist GetArtistById(int artistId);
        Artist DeleteArtist(int artistId);

    }
}
