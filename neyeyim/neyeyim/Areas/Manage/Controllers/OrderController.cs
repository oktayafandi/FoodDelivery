using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neyeyim.DAL;
using neyeyim.Enums;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Orderz.Count() / 3d);

            var model = _context.Orderz.Include(x => x.OrderItems).OrderByDescending(x => x.CreatedAt).Skip((page - 1) * 3).Take(3).ToList();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            Order order = _context.Orderz.Include(x => x.OrderItems).FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return RedirectToAction("index");
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeStatus(int id, OrderStatus status)
        {
            Order order = _context.Orderz.FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return RedirectToAction("index");
            }
            order.Status = status;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
