using Microsoft.AspNetCore.Mvc;
using neyeyim.DAL;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class InfoController : Controller
    {
        private readonly AppDbContext _context;
        public InfoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            InfoViewModel infoVM = new InfoViewModel
            {
                Information = _context.Information.ToList(),
                Promotions = _context.Promotions.ToList(),
            };
            return View(infoVM);
        }
    }
}
