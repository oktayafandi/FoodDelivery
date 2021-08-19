using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class MenuCategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public MenuCategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.MenuCategories.Count() / 3d);

            List<MenuCategory> menuCategories = _context.MenuCategories.Include(x => x.PlaceMenus).Where(x => x.IsDeleted == false).Skip((page - 1) * 3).Take(3).ToList();
            return View(menuCategories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MenuCategory menuCategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            menuCategory.IsDeleted = false;
            _context.MenuCategories.Add(menuCategory);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            MenuCategory menuCategory = _context.MenuCategories.FirstOrDefault(x => x.Id == id);

            if (menuCategory == null) return RedirectToAction("index");

            return View(menuCategory);
        }

        [HttpPost]
        public IActionResult Edit(int id, MenuCategory menuCategory)
        {
            if (!ModelState.IsValid) return View();
            MenuCategory existMenuCategory = _context.MenuCategories.FirstOrDefault(x => x.Id == id);
            if (existMenuCategory == null) return RedirectToAction("index");

            existMenuCategory.Name = menuCategory.Name;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            MenuCategory menuCategory = _context.MenuCategories.FirstOrDefault(x => x.Id == id);

            if (menuCategory == null) return RedirectToAction("index");

            menuCategory.IsDeleted = true;
            _context.SaveChanges();
            return Json(new { isSuccedded = true });
        }

        public IActionResult Restore(int id)
        {
            MenuCategory menuCategory = _context.MenuCategories.FirstOrDefault(x => x.Id == id);

            if (menuCategory == null) return RedirectToAction("index");

            menuCategory.IsDeleted = false;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
