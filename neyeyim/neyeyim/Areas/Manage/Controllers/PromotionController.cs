using Microsoft.AspNetCore.Mvc;
using neyeyim.DAL;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Controllers
{
    [Area("manage")]
    public class PromotionController : Controller
    {
        private readonly AppDbContext _context;
        public PromotionController(AppDbContext context)
        {
            _context = context;
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

            if (!ModelState.IsValid)
            {
                return View();
            }

            existPromotion.Image = promotion.Image;
            existPromotion.RedirectUrl = promotion.RedirectUrl;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
