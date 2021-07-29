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
    public class InfoController : Controller
    {
        private readonly AppDbContext _context;
        public InfoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Info> inform = _context.Information.ToList();
            return View(inform);
        }
    }
}
