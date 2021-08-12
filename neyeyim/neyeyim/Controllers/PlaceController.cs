using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neyeyim.DAL;
using neyeyim.Models;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class PlaceController : Controller
    {
        private readonly AppDbContext _context;
        public PlaceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string search)
        {
            PlaceViewModel placeVM = new PlaceViewModel
            {
                Places = _context.Places.Include(x => x.PlaceTags).Include(x => x.Jobads).Include(x => x.PlaceImages).Include(x => x.PlaceMenus).Include(x => x.Campaigns).Include(x => x.Category).Where(x => x.IsDeleted == false).Where(x => string.IsNullOrWhiteSpace(search) ? true : (x.Name.ToLower().Contains(search.ToLower()))).ToList(),
            };
            return View(placeVM);
        }

        public IActionResult Detail(int Id)
        {
            ViewBag.Tags = _context.PlaceTags.Include(x => x.Tag).Where(x => x.IsDeleted == false).ToList();

            PlaceDetailViewModel placeDetailVM = new PlaceDetailViewModel
            {
                Place = _context.Places.Include(x => x.PlaceMenus).ThenInclude(x => x.MenuCategory).Include(x => x.PlaceTags).Include(x => x.PlaceComments).ThenInclude(x => x.AppUser).FirstOrDefault(x => x.Id == Id),
            };
            return View(placeDetailVM);
        }

        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(PlaceComment comment)
        {
            if (!ModelState.IsValid) return RedirectToAction("index");

            Place place = _context.Places.Include(x => x.PlaceComments).FirstOrDefault(x => x.Id == comment.PlaceId);

            if (place == null) return RedirectToAction("index");

            var user = _context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
            comment.AppUserId = user.Id;

            if (_context.PlaceComments.Any(x => x.PlaceId == comment.PlaceId && x.AppUserId == user.Id))
            {
                return RedirectToAction("index");
            }

            double commentCount = place.PlaceComments.Count() + 1;
            comment.CreatedAt = DateTime.UtcNow;
            _context.PlaceComments.Add(comment);
            place.Rate = Math.Ceiling((place.PlaceComments.Sum(x => x.Rate) + comment.Rate) / commentCount);
            _context.SaveChanges();
            return RedirectToAction("detail", new { id = comment.PlaceId });
        }
    }
}