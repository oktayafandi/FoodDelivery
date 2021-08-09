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
    public class PromotionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public PromotionController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<Promotion> promotions = _context.Promotions.Skip((page - 1) * 3).Take(3).ToList();
            return View(promotions);
        }

        public IActionResult Edit(int id)
        {
            Promotion promotion = _context.Promotions.FirstOrDefault(x => x.Id == id);

            if (promotion == null)
            {
                return RedirectToAction("index");
            }

            return View(promotion);
        }

        [HttpPost]
        public IActionResult Edit(int id, Promotion promotion)
        {
            Promotion existPromotion = _context.Promotions.FirstOrDefault(x => x.Id == id);

            if (existPromotion == null)
            {
                return RedirectToAction("index");
            }

            if (promotion.ImageFile != null)
            {
                if (promotion.ImageFile.ContentType != "image/png" && promotion.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Mime type yanlisdir!");
                    return View();
                }

                if (promotion.ImageFile.Length > (1024 * 1024) * 2)
                {
                    ModelState.AddModelError("ImageFile", "Faly olcusu 2MB-dan cox ola bilmez!");
                    return View();
                }

                string filename = Guid.NewGuid().ToString() + promotion.ImageFile.FileName;
                string path = Path.Combine(_env.WebRootPath, "uploads\\img", filename);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    promotion.ImageFile.CopyTo(stream);
                }

                if (existPromotion.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads\\img", existPromotion.Image);
                    if (System.IO.File.Exists(existPath))
                    {
                        System.IO.File.Delete(existPath);
                    }
                }

                existPromotion.Image = filename;
            }
            //else if (promotion.Image == null)
            //{
            //    if (existPromotion.Image != null)
            //    {
            //        string existPath = Path.Combine(_env.WebRootPath, "uploads\\img", existPromotion.Image);
            //        if (System.IO.File.Exists(existPath))
            //        {
            //            System.IO.File.Delete(existPath);
            //        }

            //        existPromotion.Image = null;
            //    }
            //}

            existPromotion.RedirectUrl = promotion.RedirectUrl;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
