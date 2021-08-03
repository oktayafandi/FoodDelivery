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
    public class PlaceMenuController : Controller
    {
        private readonly AppDbContext _context;
        public PlaceMenuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<PlaceMenu> placeMenus = _context.PlaceMenus.Where(x => x.IsDeleted == false).Include(x => x.Place).Skip((page - 1) * 3).Take(3).ToList();
            return View(placeMenus);
        }
    }
}