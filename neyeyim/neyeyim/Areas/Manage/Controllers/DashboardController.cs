using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using neyeyim.Areas.Manage.ViewModels;
using neyeyim.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            dashboardViewModel.OrderCount = _context.Orderz.Count();
            dashboardViewModel.PendingCount = _context.Orderz.Where(x => x.Status == Enums.OrderStatus.Pending).Count();
            dashboardViewModel.PendingPercent = (dashboardViewModel.PendingCount * 100) / dashboardViewModel.OrderCount;
            dashboardViewModel.TotalProfit = _context.Orderz.Where(x => x.Status == Enums.OrderStatus.Accepted).Sum(x => x.TotalPrice);
            dashboardViewModel.UserCount = _context.Users.Count();

            return View(dashboardViewModel);
        }
    }
}
