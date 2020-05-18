using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models.Pages;

namespace VinylStore.Models
{
    public interface IVinylRepository
    {
        IEnumerable<Vinyl> AllVinyls { get; }
        PagedList<Vinyl> GetVinyls(QueryOptions options);
        IEnumerable<Vinyl> VinylsOfTheWeek { get; }
        void SaveVinyl(Vinyl vinyl);
        Vinyl GetVinylById(int vinylId);
        Vinyl DeleteVinyl(int vinylId);

    }
}
