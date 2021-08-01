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
            ViewBag.Categories = _context.Categories.Select(a => new SelectListItem
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
        public IActionResult Create(Jobad jobad)
        {
            ViewBag.Categories = _context.Categories.Select(a => new SelectListItem
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
            ViewBag.Categories = _context.Categories.Select(a => new SelectListItem
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

            Jobad jobad = _context.Jobads.FirstOrDefault(x => x.Id == id);

            if (jobad == null)
            {
                return RedirectToAction("index");
            }

            return View(jobad);
        }

        [HttpPost]
        public IActionResult Edit(int id, Jobad jobad)
        {
            ViewBag.Categories = _context.Categories.Select(a => new SelectListItem
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

            Jobad existJobad = _context.Jobads.FirstOrDefault(x => x.Id == id);

            if (existJobad == null)
            {
                return RedirectToAction("index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

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

            return RedirectToAction("index");
        }

    }
}
