﻿using Microsoft.AspNetCore.Mvc;
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
    public class JobadController : Controller
    {
        private readonly AppDbContext _context;
        public JobadController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Categories.Count() / 3d);

            List<Jobad> jobads = _context.Jobads.Include(x => x.Place).ToList();
            return View(jobads);
        }
    }
}
