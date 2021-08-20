using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using neyeyim.DAL;
using neyeyim.Models;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public OrderController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Checkout()
        {
            List<BasketItemViewModel> cookieBasketItems = new List<BasketItemViewModel>();
            cookieBasketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(HttpContext.Request.Cookies["basket"]);

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            foreach (var item in cookieBasketItems)
            {
                PlaceMenu placeMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == item.Id);
                BasketItemViewModel basketItem = new BasketItemViewModel
                {
                    Id = placeMenu.Id,
                    FoodName = placeMenu.FoodName,
                    FoodPrice = placeMenu.FoodPrice,
                    TotalPrice = placeMenu.FoodPrice,
                    Count = item.Count
                };
                basketItem.TotalPrice = basketItem.FoodPrice * basketItem.Count;

                basketItems.Add(basketItem);
            }

            ViewBag.IsAuthenticated = false;
            if (User.Identity.IsAuthenticated)
            {
                if (_userManager.Users.Any(x => x.UserName == User.Identity.Name && !x.IsAdmin))
                {
                    ViewBag.IsAuthenticated = true;
                }
            }

            return View(basketItems);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
