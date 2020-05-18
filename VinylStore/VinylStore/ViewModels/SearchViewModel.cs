using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;

namespace VinylStore.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<Artist> GetArtists { get; set; }
        public string Information { get; set; }
    }
}
