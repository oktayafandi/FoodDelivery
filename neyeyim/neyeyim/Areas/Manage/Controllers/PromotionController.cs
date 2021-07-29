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

        public IActionResult Index()
        {
            List<Promotion> promotions = _context.Promotions.ToList();
            return View(promotions);
        }
    }
}
