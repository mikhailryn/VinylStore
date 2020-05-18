using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;
using VinylStore.Models.Interface;
using VinylStore.ViewModels;

namespace VinylStore.Controllers
{
    public class ArtistController:Controller
    {
        private readonly IArtistRepository artistRepository;
        private readonly IAlbumRepository albumRepository;




        public ArtistController(IArtistRepository artistRepository, IAlbumRepository albumRepository)
        {
            this.artistRepository = artistRepository;
            this.albumRepository = albumRepository;
        }


        public IActionResult Index()
        {
            return View(artistRepository.AllArtists);
        }

        public IActionResult Details(int id)
        {
            IEnumerable<Album> albums;

            var artist = artistRepository.GetArtistById(id);   //vinylRepository.GetVinylById(id);


            //var album = albumRepository.AllAlbums.FirstOrDefault(a => a.AlbumId == id); // it's work 


            albums = albumRepository.AllAlbums.Where(a => a.ArtistId == id);

            if (artist == null)
            {
                return NotFound();
            }

            return View(new ArtistViewModel { AllArtists = artist, AllAlbums = albums});
        }


    }
}
