using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;
using VinylStore.ViewModels;

namespace VinylStore.Controllers
{
    public class HomeController:Controller
    {
        private readonly IVinylRepository vinylRepository;

        public HomeController(IVinylRepository vinylRepository)
        {
            this.vinylRepository = vinylRepository;
        }


        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                VinylsOfTheWeek = vinylRepository.VinylsOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
