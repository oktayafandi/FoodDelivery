using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class InfoController : Controller
    {
        private readonly AppDbContext _context;
        public InfoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Information.Count() / 3d);

            List<Info> inform = _context.Information.Where(x => x.IsDeleted == false).Skip((page - 1) * 3).Take(3).ToList();
            return View(inform);
        }

        public IActionResult Edit(int id)
        {
            Info ınfo = _context.Information.FirstOrDefault(x => x.Id == id);

            if (ınfo == null)
            {
                return RedirectToAction("index");
            }

            return View(ınfo);
        }

        [HttpPost]
        public IActionResult Edit(int id, Info ınfo)
        {
            Info existInfo = _context.Information.FirstOrDefault(x => x.Id == id);

            if (existInfo == null)
            {
                return RedirectToAction("index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existInfo.Team = ınfo.Team;
            existInfo.WhatFor = ınfo.WhatFor;
            existInfo.HowUsed = ınfo.HowUsed;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
