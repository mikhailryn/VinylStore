using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;

namespace VinylStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Vinyl> VinylsOfTheWeek { get; set; }

    }
}
