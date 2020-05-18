using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models.Interface
{
   public interface IGenreRepository
    {
        IEnumerable<Genre> AllGenres { get; }
    }
}
