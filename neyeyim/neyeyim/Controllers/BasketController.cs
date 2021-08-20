using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using neyeyim.DAL;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        public BasketController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var foodName = HttpContext.Session.GetString("foodName");
            //var name = HttpContext.Request.Cookies["name"];

            var placeMenuStr = HttpContext.Request.Cookies["basket"];
            BasketViewModel basket = new BasketViewModel();
            if (placeMenuStr == null)
            {
                basket.BasketItems = null;
            }
            else
            {
                List<BasketItemViewModel> basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(placeMenuStr);
                basket.BasketItems = basketItems;
                basket.TotalPrice = basketItems.Sum(x => x.FoodPrice);
                basket.Count = basketItems.Count;
            }
            return View(basket);
        }
    }
}