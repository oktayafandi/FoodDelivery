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
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class TagController : Controller
    {
        private readonly AppDbContext _context;
        public TagController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<Tag> tags = _context.Tags.Include(x => x.PlaceTags).Skip((page - 1) * 3).Take(3).ToList();
            return View(tags);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            tag.IsDeleted = false;
            _context.Tags.Add(tag);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Tag tag = _context.Tags.FirstOrDefault(x => x.Id == id);

            if (tag == null) return RedirectToAction("index");

            return View(tag);
        }

        [HttpPost]
        public IActionResult Edit(int id, Tag tag)
        {
            if (!ModelState.IsValid) return View();
            Tag existTag = _context.Tags.FirstOrDefault(x => x.Id == id);
            if (existTag == null) return RedirectToAction("index");

            existTag.Name = tag.Name;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Tag tag = _context.Tags.FirstOrDefault(x => x.Id == id);

            if (tag == null) return RedirectToAction("index");

            tag.IsDeleted = true;
            _context.SaveChanges();
            return Json(new { isSuccedded = true });
        }

        public IActionResult Restore(int id)
        {
            Tag tag = _context.Tags.FirstOrDefault(x => x.Id == id);

            if (tag == null) return RedirectToAction("index");

            tag.IsDeleted = false;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}