using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public interface IVinylRepository
    {
        IEnumerable<Vinyl> AllVinyls { get; }
        IEnumerable<Vinyl> VinylsOfTheWeek { get; }
        void SaveVinyl(Vinyl vinyl);
        Vinyl GetVinylById(int vinylId);
        Vinyl DeleteVinyl(int vinylId);

    }
}
