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
    public class ShoppingCartController : Controller
    {
        private readonly IVinylRepository vinylRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IVinylRepository vinylRepository, ShoppingCart shoppingCart)
        {
            this.vinylRepository = vinylRepository;
            this.shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var shopCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };
            return View(shopCartViewModel);
        }


        public RedirectToActionResult AddToShoppingCart(int vinylId)
        {
            var selectedVinyl = vinylRepository.AllVinyls.FirstOrDefault(p => p.VinylId == vinylId);

        if (selectedVinyl != null)
            {
                shoppingCart.AddToCart(selectedVinyl, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int vinylId)
        {
            var selectedVinyl = vinylRepository.AllVinyls.FirstOrDefault(p => p.VinylId == vinylId);

            if (selectedVinyl != null)
            {
                shoppingCart.RemoveFromCart(selectedVinyl);
            }
            return RedirectToAction("Index");
        }








    
    }
    }

