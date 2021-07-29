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
    public class PlaceController : Controller
    {
        private readonly AppDbContext _context;
        public PlaceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Place> places = _context.Places.Include(x => x.Campaigns).Include(x => x.Jobads).Include(x => x.PlaceTags).Include(x => x.PlaceMenus).ToList();
            return View(places);
        }
    }
}
