using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using neyeyim.DAL;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Controllers
{
    [Area("manage")]
    public class PlaceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public PlaceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<Place> places = _context.Places.Include(x => x.Category).Include(x => x.Campaigns).Include(x => x.Jobads).Include(x => x.PlaceTags).Include(x => x.PlaceMenus).Skip((page - 1) * 3).Take(3).ToList();
            return View(places);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(x => x.IsDeleted == false).ToList();

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Place place)
        {
            ViewBag.Categories = _context.Categories.Where(x => x.IsDeleted == false).ToList();

            if (place.ImageFile != null)
            {
                if (place.ImageFile.ContentType != "image/png" && place.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Mime type yanlisdir!");
                    return View();
                }

                if (place.ImageFile.Length > (1024 * 1024) * 2)
                {
                    ModelState.AddModelError("ImageFile", "Faly olcusu 2MB-dan cox ola bilmez!");
                    return View();
                }

                string rootPath = _env.WebRootPath;
                var filename = Guid.NewGuid().ToString() + place.ImageFile.FileName;
                var path = Path.Combine(rootPath, "img", filename);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    place.ImageFile.CopyTo(stream);
                }

                place.Image = filename;
            }

            if (place.LogoFile != null)
            {
                if (place.LogoFile.ContentType != "image/png" && place.LogoFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("LogoFile", "Mime type yanlisdir!");
                    return View();
                }

                if (place.LogoFile.Length > (1024 * 1024) * 2)
                {
                    ModelState.AddModelError("LogoFile", "Faly olcusu 2MB-dan cox ola bilmez!");
                    return View();
                }

                string rootPath = _env.WebRootPath;
                var filename = Guid.NewGuid().ToString() + place.LogoFile.FileName;
                var path = Path.Combine(rootPath, "img", filename);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    place.LogoFile.CopyTo(stream);
                }

                place.Logo = filename;
            }

            ViewBag.Categories = _context.Categories.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Places.Add(place);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.Where(x => x.IsDeleted == false).ToList();

            Place place = _context.Places.FirstOrDefault(x => x.Id == id);

            if (place == null)
            {
                return RedirectToAction("index");
            }

            return View(place);
        }

        public IActionResult Edit(int id, Place place)
        {
            ViewBag.Categories = _context.Categories.Where(x => x.IsDeleted == false).ToList();

            Place existPlace = _context.Places.FirstOrDefault(x => x.Id == id);

            if (existPlace == null)
            {
                return RedirectToAction("index");
            }

            if (place.ImageFile != null)
            {
                if (place.ImageFile.ContentType != "image/png" && place.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Mime type yanlisdir!");
                    return View();
                }

                if (place.ImageFile.Length > (1024 * 1024) * 2)
                {
                    ModelState.AddModelError("ImageFile", "Faly olcusu 2MB-dan cox ola bilmez!");
                    return View();
                }

                string filename = Guid.NewGuid().ToString() + place.ImageFile.FileName;
                string path = Path.Combine(_env.WebRootPath, "uploads", filename);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    place.ImageFile.CopyTo(stream);
                }

                if (existPlace.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads", existPlace.Image);
                    if (System.IO.File.Exists(existPath))
                    {
                        System.IO.File.Delete(existPath);
                    }
                }

                existPlace.Image = filename;
            }
            else if (place.Image == null)
            {
                if (existPlace.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads", existPlace.Image);
                    if (System.IO.File.Exists(existPath))
                    {
                        System.IO.File.Delete(existPath);
                    }

                    existPlace.Image = null;
                }
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existPlace.Name = place.Name;
            existPlace.Adress = place.Adress;
            existPlace.OpenCloseTime = place.OpenCloseTime;
            existPlace.Status = place.Status;
            existPlace.Servisfee = place.Servisfee;
            existPlace.Image = place.Image;
            existPlace.Logo = place.Logo;
            existPlace.IsSelected = place.IsSelected;
            existPlace.Deposit = place.Deposit;
            existPlace.ContactPhone = place.ContactPhone;
            existPlace.Rate = place.Rate;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Place place = _context.Places.FirstOrDefault(x => x.Id == id);

            if (place == null) return RedirectToAction("index");

            place.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Restore(int id)
        {
            Place place = _context.Places.FirstOrDefault(x => x.Id == id);

            if (place == null) return RedirectToAction("index");

            place.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
