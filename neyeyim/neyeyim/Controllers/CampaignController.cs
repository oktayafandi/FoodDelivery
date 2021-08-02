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
    public class CampaignController : Controller
    {
        private readonly AppDbContext _context;
        public CampaignController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CampaignViewModel campaignVM = new CampaignViewModel
            {
                Campaigns = _context.Campaigns.Include(x => x.Place).Where(x => x.IsDeleted == false).Take(6).ToList(),
            };
            return View(campaignVM);
        }
    }
}
