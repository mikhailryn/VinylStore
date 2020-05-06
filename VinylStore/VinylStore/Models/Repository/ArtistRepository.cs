using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models.Interface;

namespace VinylStore.Models.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDbContext appDbContext;

        public ArtistRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public IEnumerable<Artist> AllArtists => appDbContext.Artists;


        public Artist DeleteArtist(int artistId)
        {
           Artist dbEntry = appDbContext.Artists.FirstOrDefault(a => a.ArtistId == artistId);
           
            if (dbEntry != null)
            {
                appDbContext.Artists.Remove(dbEntry);
                appDbContext.SaveChanges();
            }
            return dbEntry;
        }

        public Artist GetArtistById(int artistId)
        {
            return appDbContext.Artists.FirstOrDefault(a => a.ArtistId == artistId);
        }

        public void SaveArtist(Artist artist)
        {
            if (artist.ArtistId == 0)
            {
                appDbContext.Artists.Add(artist);
            }
            else
            {
                Artist dbEntry = appDbContext.Artists.FirstOrDefault(a => a.ArtistId == artist.ArtistId);
                if (dbEntry != null)
                {
                    dbEntry.ArtistName = artist.ArtistName;
                    dbEntry.Description = artist.Description;
                    dbEntry.ImgUrl = artist.ImgUrl;
                }

            }
            appDbContext.SaveChanges();
        }
    }
}
