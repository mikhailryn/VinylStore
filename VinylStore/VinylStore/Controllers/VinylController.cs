using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VinylStore.Models;
using VinylStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VinylStore.Controllers
{
    public class VinylController : Controller
    {
        private readonly IVinylRepository vinylRepository;
        private readonly ICategoryRepository categoryRepository;


        public VinylController(IVinylRepository vinylRepository, ICategoryRepository categoryRepository)
        {
            this.vinylRepository = vinylRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Vinyl> vinyls;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                vinyls = vinylRepository.AllVinyls.OrderBy(v => v.VinylId);
                currentCategory = "All vinyl record";
            }
            else
            {
                vinyls = vinylRepository.AllVinyls.Where(v => v.Category.CategoryName == category)
                    .OrderBy(v => v.VinylId);
                currentCategory = categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new VinylViewModel{
                Vinyls = vinyls,
                CurrentCategory = currentCategory
            });
            
        }

        public IActionResult Details(int id)
        {
            var vinyl = vinylRepository.GetVinylById(id);

            if (vinyl == null)
            {
                return NotFound();
            }
            
            return View(vinyl);
        }

    }
}
