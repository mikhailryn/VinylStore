using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylStore.Models;

namespace VinylStore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController:Controller
    {
        private readonly IVinylRepository vinylRepository;

        public AdminController(IVinylRepository vinylRepository)
        {
            this.vinylRepository = vinylRepository;
        }

        public ViewResult Index() => View(vinylRepository.AllVinyls);

        public ViewResult Edit(int vinylId) => View(vinylRepository.AllVinyls.FirstOrDefault(v => v.VinylId == vinylId));

        [HttpPost]
        public IActionResult Edit(Vinyl vinyl)
        {
            if (ModelState.IsValid)
            {
                vinylRepository.SaveVinyl(vinyl);
                TempData["message"] = $"{vinyl.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                return View(vinyl);
            }
        }

        public ViewResult Create() => View("Edit", new Vinyl());

        [HttpPost]
        public IActionResult Delete(int vinylId)
        {
            Vinyl deletedVinyl = vinylRepository.DeleteVinyl(vinylId);
            if(deletedVinyl != null)
            {
                TempData["message"] = $"{deletedVinyl} was deleted";
            }
            return RedirectToAction("Index");

        }
    }
}
