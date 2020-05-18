using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;
using VinylStore.Models.Interface;

namespace VinylStore.Controllers
{
    public class GenreController:Controller
    {
        private readonly IGenreRepository genreRepository;
        private readonly IAlbumRepository albumRepository;

        public GenreController(IGenreRepository genreRepository, IAlbumRepository albumRepository)
        {
            this.genreRepository = genreRepository;
            this.albumRepository = albumRepository;
        }

        public IActionResult Index()
        {
            return View(genreRepository.AllGenres);
        }

        public IActionResult Detail(int id)
        {
            IEnumerable<Album> albums;

            albums = albumRepository.AllAlbums.Where(a => a.GenreId == id);

            return View(albums);
        }


    }
}
