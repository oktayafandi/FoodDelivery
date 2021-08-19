using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<Slider> sliders = _context.Sliders.Where(x => x.IsDeleted == false).Skip((page - 1) * 3).Take(3).ToList();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            string rootPath = _env.WebRootPath;
            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Mime type yanlisdir!");
                    return View();
                }

                if (slider.ImageFile.Length > (1024 * 1024) * 2)
                {
                    ModelState.AddModelError("ImageFile", "Faly olcusu 2MB-dan cox ola bilmez!");
                    return View();
                }

                var filename = Guid.NewGuid().ToString() + slider.ImageFile.FileName;
                var path = Path.Combine(rootPath, "uploads\\img", filename);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    slider.ImageFile.CopyTo(stream);
                }

                slider.Image = filename;
            }


            if (!ModelState.IsValid)
            {
                return View();
            }

            slider.IsDeleted = false;
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
            {
                return RedirectToAction("index");
            }

            return View(slider);
        }

        [HttpPost]
        public IActionResult Edit(int id, Slider slider)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (existSlider == null)
            {
                return RedirectToAction("index");
            }

            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Mime type yanlisdir!");
                    return View();
                }

                if (slider.ImageFile.Length > (1024 * 1024) * 2)
                {
                    ModelState.AddModelError("ImageFile", "Faly olcusu 2MB-dan cox ola bilmez!");
                    return View();
                }

                string filename = Guid.NewGuid().ToString() + slider.ImageFile.FileName;
                string path = Path.Combine(_env.WebRootPath, "uploads", filename);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    slider.ImageFile.CopyTo(stream);
                }

                if (existSlider.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads", existSlider.Image);
                    if (System.IO.File.Exists(existPath))
                    {
                        System.IO.File.Delete(existPath);
                    }
                }

                existSlider.Image = filename;
            }
            else if (slider.Image == null)
            {
                if (existSlider.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads", existSlider.Image);
                    if (System.IO.File.Exists(existPath))
                    {
                        System.IO.File.Delete(existPath);
                    }

                    existSlider.Image = null;
                }
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existSlider.Order = slider.Order;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null) return RedirectToAction("index");

            slider.IsDeleted = true;
            _context.SaveChanges();

            return Json(new { isSuccedded = true });
        }
    }
}
