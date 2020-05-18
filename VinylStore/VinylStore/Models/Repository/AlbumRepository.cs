using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models.Interface;

namespace VinylStore.Models.Repository
{
    public class AlbumRepository:IAlbumRepository
    {
        private readonly AppDbContext appDbContext;

        public AlbumRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


       public IEnumerable<Album> AllAlbums => appDbContext.Albums;

        public Album GetAlbumById(int albumId)
        {
            return appDbContext.Albums.FirstOrDefault(a => a.AlbumId == albumId);
        }

    }
}
