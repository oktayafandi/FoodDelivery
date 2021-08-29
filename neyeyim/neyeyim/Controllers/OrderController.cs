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
            BasketItemOrderVm productorder = new BasketItemOrderVm();
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            int i = cookieBasketItems.Count;
            
             foreach (var item in cookieBasketItems)
             {
                if (i!=0)
                {
                    PlaceMenu placeMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == item.Id);
                    BasketItemViewModel basketItem = new BasketItemViewModel
                    {
                        Id = placeMenu.Id,
                        FoodName = placeMenu.FoodName,
                        FoodPrice = placeMenu.FoodPrice,
                        Count = item.Count,
                        TotalPrice = placeMenu.FoodPrice * item.Count,
                    };

                    basketItems.Add(basketItem);
                    i--;
                }
             }

            productorder.basket = basketItems;
            ViewBag.IsAuthenticated = false;
            if (User.Identity.IsAuthenticated)
            {
                if (_userManager.Users.Any(x => x.UserName == User.Identity.Name && !x.IsAdmin))
                {
                    ViewBag.IsAuthenticated = true;
                }
            }
            return View(productorder);
        }

        [HttpPost]
        public IActionResult Checkout(BasketItemOrderVm order)
        {
            AppUser user = null;
            if (User.Identity.IsAuthenticated)
            {
                user = _userManager?.Users?.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
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
                order.AppUserId = user.Id;
                if (user.Address != null)
                {
                    order.Address = user.Address;
                }
                order.Name = user.Name;
                order.Surname = user.Surname;
                if (user.ContactPhone!=null)
                {
                    order.ContactPhone = user.ContactPhone;
                }
            }
            Order ord = new Order()
            {
                AppUserId = user.Id,
                Address = order.Address,
                Name = order.Name,
                Surname = order.Surname,
                ContactPhone = order.ContactPhone,
                Note = order.Note,
                TotalPrice = 0,
                CreatedAt = DateTime.Now,
            };
            _context.Orderz.Add(ord);
            _context.SaveChanges();

            List<BasketItemViewModel> cookieBasketItems = new List<BasketItemViewModel>();
            cookieBasketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(HttpContext.Request.Cookies["basket"]);

            //var totalPriceC = 0;
            //foreach (var product in cookieBasketItems)
            //{
            //    totalPriceC =  product.FoodPrice * product.Count;
            //}

            order.AppUserId = user != null ? user.Id : null;

            foreach (var item in cookieBasketItems)
            {
                PlaceMenu placeMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == item.Id);
                OrderItem basketItem = new OrderItem
                {
                    OrderId = _context.Orderz.FirstOrDefault(x => x.Note == order.Note).Id,
                    PlaceMenuId = placeMenu.Id,
                    Name = placeMenu.FoodName,
                    Price = placeMenu.FoodPrice,
                    Count = item.Count,
                    TotalPrice = placeMenu.FoodPrice * item.Count,
                };
                _context.OrderItems.Add(basketItem);
            }
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