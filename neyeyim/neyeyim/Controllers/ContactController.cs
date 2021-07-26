using Microsoft.AspNetCore.Mvc;
using neyeyim.DAL;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ContactViewModel contactVM = new ContactViewModel
            {
                Promotions = _context.Promotions.ToList(),
            };

            return View(contactVM);
        }
    }
}
