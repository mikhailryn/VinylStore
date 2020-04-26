using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;

namespace VinylStore.ViewModels
{
    public class VinylViewModel
    {
        public IEnumerable<Vinyl> Vinyls { get; set; }
        public string CurrentCategory { get; set; }
    }
}
