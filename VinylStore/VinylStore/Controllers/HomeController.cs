using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;
using VinylStore.Models.Interface;
using VinylStore.ViewModels;

namespace VinylStore.Controllers
{
    public class HomeController:Controller
    {
        private readonly IVinylRepository vinylRepository;
        private readonly IArtistRepository artistRepository;

        public HomeController(IVinylRepository vinylRepository, IArtistRepository artistRepository)
        {
            this.vinylRepository = vinylRepository;
            this.artistRepository = artistRepository;
        }


        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                VinylsOfTheWeek = vinylRepository.VinylsOfTheWeek
            };
            return View(homeViewModel);
        }

        public IActionResult Search(string name)
        {
            IEnumerable<Artist> artists;



            if (!String.IsNullOrEmpty(name))
            {
                artists = artistRepository.AllArtists.Where(a => a.ArtistName.Contains(name, StringComparison.OrdinalIgnoreCase));

                if (artists.Count() == 0)
                {
                    return View(new SearchViewModel { Information = $"{name} doesn't exist ¯/_(ツ)_/¯" });
                }

            }
            else
            {
                return View();
            }

            return View(new SearchViewModel { GetArtists = artists });

        }


    }
}
