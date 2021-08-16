using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using neyeyim.DAL;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.Where(x => x.IsDeleted == false).OrderBy(x => x.Order).ToList(),
                Places = _context.Places.Include(x => x.PlaceTags).Include(x => x.PlaceImages).Include(x => x.PlaceMenus).Include(x => x.Jobads).Include(x => x.Campaigns).Include(x => x.Category).Where(x => x.IsDeleted == false).ToList(),
            };
            return View(homeVM);
        }
    }
}