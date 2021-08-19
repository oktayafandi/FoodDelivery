using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using neyeyim.DAL;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class PlaceMenuController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public PlaceMenuController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.PlaceMenus.Count() / 3d);

            List<PlaceMenu> placeMenus = _context.PlaceMenus.Include(x => x.Place).Include(x => x.MenuCategory).Where(x => x.IsDeleted == false).Skip((page - 1) * 3).Take(3).ToList();
            return View(placeMenus);
        }

        public IActionResult Create()
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            ViewBag.MenuCategories = _context.MenuCategories.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(PlaceMenu placeMenu)
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            ViewBag.MenuCategories = _context.MenuCategories.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }

            placeMenu.IsDeleted = false;
            _context.PlaceMenus.Add(placeMenu);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            ViewBag.MenuCategories = _context.MenuCategories.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            PlaceMenu placeMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == id);

            if (placeMenu == null)
            {
                return RedirectToAction("index");
            }

            return View(placeMenu);
        }

        [HttpPost]
        public IActionResult Edit(int id, PlaceMenu placeMenu)
        {
            PlaceMenu existPlaceMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == id);

            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            ViewBag.MenuCategories = _context.MenuCategories.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            if (existPlaceMenu == null)
            {
                return RedirectToAction("index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existPlaceMenu.FoodName = placeMenu.FoodName;
            existPlaceMenu.FoodContent = placeMenu.FoodContent;
            existPlaceMenu.FoodPrice = placeMenu.FoodPrice;
            existPlaceMenu.Place = placeMenu.Place;
            existPlaceMenu.MenuCategory = placeMenu.MenuCategory;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            PlaceMenu placeMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == id);

            if (placeMenu == null) return RedirectToAction("index");

            placeMenu.IsDeleted = true;
            _context.SaveChanges();
            return Json(new { isSuccedded = true });
        }

        public IActionResult Restore(int id)
        {
            PlaceMenu placeMenu = _context.PlaceMenus.FirstOrDefault(x => x.Id == id);

            if (placeMenu == null) return RedirectToAction("index");

            placeMenu.IsDeleted = false;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}