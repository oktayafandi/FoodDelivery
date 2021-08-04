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

        public IActionResult Index()
        {
            PlaceViewModel placeVM = new PlaceViewModel
            {
                Places = _context.Places.Include(x => x.PlaceTags).Include(x => x.Jobads).Include(x => x.PlaceImages).Include(x => x.PlaceMenus).Include(x => x.Campaigns).Include(x => x.Category).Where(x => x.IsDeleted == false).ToList(),
            };
            return View(placeVM);
        }

        public IActionResult Detail(int Id)
        {
            ViewBag.Tags = _context.PlaceTags.Include(x => x.Tag).Where(x => x.IsDeleted == false).ToList();
            Place place = _context.Places.Include(x => x.PlaceMenus).FirstOrDefault(x => x.Id == Id);
            return View(place);
        }
    }
}