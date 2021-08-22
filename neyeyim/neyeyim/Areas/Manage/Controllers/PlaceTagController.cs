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
    public class PlaceTagController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public PlaceTagController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.PlaceTags.Count() / 3d);

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

            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
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
            ViewBag.Tags = _context.Tags.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }

            placeTag.IsDeleted = false;
            _context.PlaceTags.Add(placeTag);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Tags = _context.Tags.Where(x => x.IsDeleted == false).ToList();
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).ToList();

            PlaceTag placeTag = _context.PlaceTags.FirstOrDefault(x => x.Id == id);

            if (placeTag == null)
            {
                return RedirectToAction("index");
            }
            return View(placeTag);
        }

        [HttpPost]
        public IActionResult Edit(int id, PlaceTag placeTag)
        {
            PlaceTag existPlaceTag = _context.PlaceTags.FirstOrDefault(x => x.Id == id);

            ViewBag.Tags = _context.Tags.Where(x => x.IsDeleted == false).ToList();
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).ToList();

            if (existPlaceTag == null)
            {
                return RedirectToAction("index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existPlaceTag.TagId = placeTag.TagId;
            existPlaceTag.PlaceId = placeTag.PlaceId;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            PlaceTag placeTag = _context.PlaceTags.FirstOrDefault(x => x.Id == id);

            if (placeTag == null) return RedirectToAction("index");

            placeTag.IsDeleted = true;
            _context.SaveChanges();
            return Json(new { isSuccedded = true });
        }

        public IActionResult Restore(int id)
        {
            PlaceTag placeTag = _context.PlaceTags.FirstOrDefault(x => x.Id == id);

            if (placeTag == null) return RedirectToAction("index");

            placeTag.IsDeleted = false;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}