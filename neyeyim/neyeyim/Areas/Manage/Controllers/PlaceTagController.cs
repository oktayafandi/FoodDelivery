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
    public class PlaceTagController : Controller
    {
        private readonly AppDbContext _context;
        public PlaceTagController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<PlaceTag> placetags = _context.PlaceTags.Include(x => x.Place).Include(x => x.Tag).Where(x => x.IsDeleted == false).Skip((page - 1) * 3).Take(3).ToList();
            return View(placetags);
        }

        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            ViewBag.Places = _context.Places.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(PlaceTag placeTag)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            placeTag.IsDeleted = false;
            _context.PlaceTags.Add(placeTag);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            PlaceTag placeTag = _context.PlaceTags.FirstOrDefault(x => x.Id == id);

            if (placeTag == null) return RedirectToAction("index");

            placeTag.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
