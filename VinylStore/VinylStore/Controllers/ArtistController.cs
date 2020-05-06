using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models.Interface;

namespace VinylStore.Controllers
{
    public class ArtistController:Controller
    {
        private readonly IArtistRepository artistRepository;




        public ArtistController(IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }


        public IActionResult Index()
        {
            return View(artistRepository.AllArtists);
        }

        public IActionResult Details(int id)
        {
            var artist = artistRepository.GetArtistById(id);   //vinylRepository.GetVinylById(id);

            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }


    }
}
