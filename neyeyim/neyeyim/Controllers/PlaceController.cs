﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neyeyim.DAL;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class PlaceController : Controller
    {
        private readonly AppDbContext _context;
        public PlaceController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            PlaceViewModel placeVM = new PlaceViewModel
            {
                Places = _context.Places.Include(x => x.PlaceTags).Include(x => x.PlaceImages).Include(x => x.PlaceMenus).Include(x => x.Jobads).Include(x => x.Campaigns).Take(6).ToList(),
                Settings = _context.Settings.ToList()
            };

            return View(placeVM);
        }
    }
}
