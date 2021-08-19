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
    public class CampaignController : Controller
    {
        private readonly AppDbContext _context;
        public CampaignController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Campaigns.Count() / 3d);

            List<Campaign> campaigns = _context.Campaigns.Include(x => x.Place).Skip((page - 1) * 3).Take(3).ToList();
            return View(campaigns);
        }

        public IActionResult Create()
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Campaign campaign)
        {
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

            campaign.IsDeleted = false;
            _context.Campaigns.Add(campaign);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Campaign campaign = _context.Campaigns.FirstOrDefault(x => x.Id == id);

            if (campaign == null)
            {
                return RedirectToAction("index");
            }

            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            return View(campaign);
        }

        [HttpPost]
        public IActionResult Edit(int id, Campaign campaign)
        {
            ViewBag.Places = _context.Places.Where(x => x.IsDeleted == false).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name,
                Selected = true
            }).ToList();

            Campaign existCampaign = _context.Campaigns.FirstOrDefault(x => x.Id == id);

            if (existCampaign == null)
            {
                return RedirectToAction("index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existCampaign.Name = campaign.Name;
            existCampaign.Content = campaign.Content;
            existCampaign.Price = campaign.Price;
            existCampaign.Place = campaign.Place;
            existCampaign.RedirectUrl = campaign.RedirectUrl;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Campaign campaign = _context.Campaigns.FirstOrDefault(x => x.Id == id);

            if (campaign == null) return RedirectToAction("index");

            campaign.IsDeleted = true;
            _context.SaveChanges();

            return Json(new { isSuccedded = true });
        }

        public IActionResult Restore(int id)
        {
            Campaign campaign = _context.Campaigns.FirstOrDefault(x => x.Id == id);

            if (campaign == null) return RedirectToAction("index");

            campaign.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
