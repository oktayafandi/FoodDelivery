using Microsoft.AspNetCore.Authorization;
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
    public class JobadController : Controller
    {
        private readonly AppDbContext _context;
        public JobadController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Jobads.Count() / 3d);

            List<Jobad> jobads = _context.Jobads.Include(x => x.Place).Include(x => x.Category).Where(x => x.IsDeleted == false).Skip((page - 1) * 3).Take(3).ToList();
            return View(jobads);
        }

        public IActionResult Create()
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).ToList();
            ViewBag.Categories = _context.Categories.Where(x => x.IsDeleted == false).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Jobad jobad)
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).ToList();
            ViewBag.Categories = _context.Categories.Where(x => x.IsDeleted == false).ToList();

            if (!_context.Places.Any(x => x.Id == jobad.PlaceId))
            {
                ModelState.AddModelError("PlaceId", "Xeta var!");
            }

            if (!_context.Categories.Any(x => x.Id == jobad.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Xeta var!");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            jobad.IsDeleted = false;
            _context.Jobads.Add(jobad);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Jobad jobad = _context.Jobads.FirstOrDefault(x => x.Id == id);

            if (jobad == null)
            {
                return RedirectToAction("index");
            }

            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).ToList();
            ViewBag.Categories = _context.Categories.ToList();

            return View(jobad);
        }

        [HttpPost]
        public IActionResult Edit(int id, Jobad jobad)
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).ToList();
            ViewBag.Categories = _context.Categories.ToList();

            Jobad existJobad = _context.Jobads.FirstOrDefault(x => x.Id == id);

            if (existJobad == null)
            {
                return RedirectToAction("index");
            }


            if (!_context.Places.Any(x => x.Id == jobad.PlaceId)) return RedirectToAction("index");

            if (!_context.Categories.Any(x => x.Id == jobad.CategoryId)) return RedirectToAction("index");

            existJobad.PlaceId = jobad.PlaceId;
            existJobad.CategoryId = jobad.CategoryId;
            existJobad.Position = jobad.Position;
            existJobad.Age = jobad.Age;
            existJobad.Experience = jobad.Experience;
            existJobad.Education = jobad.Education;
            existJobad.GeneralInfo = jobad.GeneralInfo;
            existJobad.City = jobad.City;
            existJobad.ContactMail = jobad.ContactMail;
            existJobad.ContactPhone = jobad.ContactPhone;
            existJobad.Deadline = jobad.Deadline;
            existJobad.Salary = jobad.Salary;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Jobad jobad = _context.Jobads.FirstOrDefault(x => x.Id == id);

            if (jobad == null) return RedirectToAction("index");

            jobad.IsDeleted = true;
            _context.SaveChanges();

            return Json(new { isSuccedded = true });
        }

    }
}
