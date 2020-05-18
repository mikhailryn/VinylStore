using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models.Interface;

namespace VinylStore.Models.Repository
{
    public class GenreRepository:IGenreRepository
    {
        private readonly AppDbContext appDbContext;

        public GenreRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Genre> AllGenres => appDbContext.Genres;
    }
}
