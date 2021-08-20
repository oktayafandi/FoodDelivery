using Microsoft.AspNetCore.Identity;
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

        [HttpPost]
        public IActionResult Create(Order order)
        {
            AppUser user = null;
            if (User.Identity.IsAuthenticated)
            {
                user = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (user == null)
            {
                ViewBag.IsAuthenticated = false;

                if (string.IsNullOrWhiteSpace(order.Name) || string.IsNullOrWhiteSpace(order.Surname) || string.IsNullOrWhiteSpace(order.ContactPhone) || string.IsNullOrWhiteSpace(order.Address))
                {
                    ModelState.AddModelError("", "Ad, Soyad, əlaqə nömrəsi və ünvan dəyərləri göndərilməlidir");
                    return View("Checkout", _getBasketItems());
                }
            }
            else
            {
                order.Name = user.Name;
                order.Surname = user.Surname;
                order.Address = user.Address;
                order.ContactPhone = user.ContactPhone;
            }

            List<BasketItemViewModel> cookieBasketItems = new List<BasketItemViewModel>();
            cookieBasketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(HttpContext.Request.Cookies["basket"]);

            order.OrderItems = new List<OrderItem>();
            order.Status = Enums.OrderStatus.Pending;
            order.CreatedAt = DateTime.UtcNow;
            order.AppUserId = user != null ? user.Id : null;
            foreach (var item in cookieBasketItems)
            {
                PlaceMenu placeMenu = _context.PlaceMenus.Include(x => x.Place).FirstOrDefault(x => x.Id == item.Id);
                OrderItem orderItem = new OrderItem
                {
                    Id = placeMenu.Id,
                    Name = placeMenu.FoodName,
                    Price = placeMenu.FoodPrice,
                    TotalPrice = placeMenu.FoodPrice,
                    Count = item.Count
                };
                orderItem.TotalPrice = orderItem.Price * orderItem.Count;
                order.OrderItems.Add(orderItem);

                order.TotalPrice += orderItem.TotalPrice;
            }

            _context.Orders.Add(order);
            _context.SaveChanges();
            HttpContext.Response.Cookies.Delete("basket");
            return RedirectToAction("index", "home");
        }

        public IActionResult Index()
        {
            return View();
        }

        private List<BasketItemViewModel> _getBasketItems()
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
            return basketItems;
        }
    }
}
