using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<Category> categories = _context.Categories.Include(x => x.Places).Include(x => x.Jobads).Skip((page - 1) * 3).Take(3).ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            category.IsDeleted = false;
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Category category = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null)
            {
                return RedirectToAction("index");
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(int id, Category category)
        {
            Category existCategory = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (existCategory == null)
            {
                return RedirectToAction("index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existCategory.Name = category.Name;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Category category = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null) return RedirectToAction("index");

            category.IsDeleted = true;
            _context.SaveChanges();

            return Json(new { isSuccedded = true });
        }

        public IActionResult Restore(int id)
        {
            Category category = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null) return RedirectToAction("index");

            category.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
