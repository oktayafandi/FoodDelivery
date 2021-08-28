using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class PlaceController : Controller
    {
        private readonly AppDbContext _context;
        public PlaceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string search)
        {
            PlaceViewModel placeVM = new PlaceViewModel
            {
                Places = _context.Places.Include(x => x.PlaceTags).Include(x => x.Jobads).Include(x => x.PlaceImages).Include(x => x.PlaceMenus).Include(x => x.Campaigns).Include(x => x.Category).Where(x => x.IsDeleted == false).Where(x => string.IsNullOrWhiteSpace(search) ? true : (x.Name.ToLower().Contains(search.ToLower()))).ToList(),
                PlaceTags = _context.PlaceTags.Include(x => x.Tag).ToList()
            };

            return View(placeVM);
        }

        public IActionResult Detail(int Id)
        {
            ViewBag.Tags = _context.PlaceTags.Include(x => x.Tag).Where(x => x.IsDeleted == false).ToList();

            PlaceDetailViewModel placeDetailVM = new PlaceDetailViewModel
            {
                Place = _context.Places.Include(x => x.PlaceMenus).ThenInclude(x => x.MenuCategory).Include(x => x.PlaceTags).Include(x => x.PlaceComments).ThenInclude(x => x.AppUser).FirstOrDefault(x => x.Id == Id),
            };

            if (DateTime.Now.Hour > placeDetailVM?.Place?.OpenTime.Hour && DateTime.Now.Hour < placeDetailVM?.Place?.CloseTime.Hour)
            {
                placeDetailVM.Place.Status = "Açıq";
            }
            else
            {
                placeDetailVM.Place.Status = "Qapalı";
            }

            return View(placeDetailVM);
        }

        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(PlaceComment comment)
        {
            if (!ModelState.IsValid) return RedirectToAction("index");

            Place place = _context.Places.Include(x => x.PlaceComments).FirstOrDefault(x => x.Id == comment.PlaceId);

            if (place == null) return RedirectToAction("index");

            var user = _context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
            comment.AppUserId = user.Id;

            if (_context.PlaceComments.Any(x => x.PlaceId == comment.PlaceId && x.AppUserId == user.Id))
            {
                return RedirectToAction("index");
            }

            double commentCount = place.PlaceComments.Count() + 1;
            comment.CreatedAt = DateTime.UtcNow;
            _context.PlaceComments.Add(comment);
            place.Rate = place.Rate != 0 ? Math.Ceiling((place.Rate + comment.Rate) / 2) : (place.Rate + comment.Rate);
            _context.SaveChanges();
            return RedirectToAction("detail", new { id = comment.PlaceId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilterSearch(string Category, string PlaceTag, string Status)
        {
            PlaceViewModel placeVM = new PlaceViewModel
            {
                Places = _context.Places.Include(x => x.PlaceTags).Include(x => x.Jobads).Include(x => x.PlaceImages).Include(x => x.PlaceMenus).Include(x => x.Campaigns).Include(x => x.Category).ToList(),
                FilterPlaces = _context.Places
                .Include(x => x.PlaceTags).Include(x => x.Jobads).Include(x => x.PlaceImages).Include(x => x.PlaceMenus).Include(x => x.Campaigns).Include(x => x.Category)
                .Where(x => x.Category.Name == Category || x.Status == Status || x.PlaceTags.Where(x => x.Tag.Name == PlaceTag).Count() != 0).ToList(),
                PlaceTags = _context.PlaceTags.Include(x => x.Tag).ToList()
            };

            return View(placeVM);
        }

        public IActionResult Random()
        {
            Random random = new Random();
            int number;
            Place place;

            do
            {
                number = random.Next(_context.Places.OrderByDescending(x => x.Id).FirstOrDefault().Id);
                place = _context.Places.FirstOrDefault(x => x.Id == number);
            } while (place == null);

            return RedirectToAction("detail", new { id = number });
        }

        [Authorize(Roles = "Member")]
        public IActionResult AddBasket(int id)
        {
            //HttpContext.Session.SetString("foodName", "Burger");
            //HttpContext.Response.Cookies.Append("name", "Burger");

            PlaceMenu placeMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == id);
            var placeId = placeMenu?.PlaceId;
            if (placeMenu == null) return RedirectToAction("index", "home");

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            BasketItemViewModel placeVM = new BasketItemViewModel
            {
                Id = placeMenu.Id,
                FoodName = placeMenu.FoodName,
                FoodPrice = placeMenu.FoodPrice,
                Count = 1,
                TotalPrice = placeMenu.FoodPrice
            };

            if (HttpContext.Request.Cookies["basket"] == null)
            {
                basketItems.Add(placeVM);
            }
            else
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(HttpContext.Request.Cookies["basket"]);

                var existBasketItem = basketItems.FirstOrDefault(x => x.Id == placeVM.Id);

                if (existBasketItem != null)
                {
                    existBasketItem.Count += 1;
                    existBasketItem.TotalPrice += existBasketItem.TotalPrice;
                }
                else
                {
                    basketItems.Add(placeVM);
                }
            }

            HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketItems, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));

            return RedirectToAction("Detail", new { id = placeId});
        }

        public IActionResult ShowBasket()
        {
            //var foodName = HttpContext.Session.GetString("foodName");
            //var name = HttpContext.Request.Cookies["name"];

            var placeMenuStr = HttpContext.Request.Cookies["basket"];
            List<BasketItemViewModel> placeMenu = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(placeMenuStr);

            return Ok(placeMenu);
        }

        public IActionResult RemoveBasket(int id)
        {
            var baskets = HttpContext.Request.Cookies["basket"];
            var basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(HttpContext.Request.Cookies["basket"]);

            basketItems.Remove(basketItems.FirstOrDefault(x => x.Id == id));
            
            HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketItems, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));

            return RedirectToAction("index", "basket");
        }
    }
}