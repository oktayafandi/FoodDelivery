using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neyeyim.DAL;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class JobadController : Controller
    {
        private readonly AppDbContext _context;
        public JobadController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            JobadViewModel jobadVM = new JobadViewModel
            {
                Jobads = _context.Jobads.Take(8).ToList(),
                Promotions = _context.Promotions.ToList(),
            };
            return View(jobadVM);
        }
    }
}
