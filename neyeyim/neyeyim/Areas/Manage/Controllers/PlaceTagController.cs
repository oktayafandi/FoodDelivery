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
    public class PlaceTagController : Controller
    {
        private readonly AppDbContext _context;
        public PlaceTagController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PlaceTag> placetags = _context.PlaceTags.Include(x => x.Place).Include(x => x.Tag).ToList();
            return View(placetags);
        }
    }
}
