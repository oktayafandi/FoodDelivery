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
                Jobads = _context.Jobads.Include(x => x.Category).Where(x => x.IsDeleted == false && !x.Place.IsDeleted).Include(x => x.Place).Take(8).ToList(),
                Promotions = _context.Promotions.ToList(),
            };

            foreach (var item in jobadVM.Jobads)
            {
                if (DateTime.Now > item.Deadline)
                {
                    item.IsDeleted = true;
                }
                else
                {
                    item.IsDeleted = false;
                }
            }

            _context.SaveChanges();
            return View(jobadVM);
        }

        public IActionResult Detail(int Id)
        {
            Jobad jobad = _context.Jobads.Include(x => x.Place).FirstOrDefault(x => x.Id == Id);
            return View(jobad);
        }
    }
}