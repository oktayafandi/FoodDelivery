using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using neyeyim.DAL;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Setting> settings = _context.Settings.ToList();
            return View(settings);
        }

        public IActionResult Edit(int id)
        {
            Setting setting = _context.Settings.FirstOrDefault(x => x.Id == id);

            if (setting == null)
            {
                return RedirectToAction("index");
            }

            return View(setting);
        }

        [HttpPost]
        public IActionResult Edit(int id, Setting setting)
        {
            Setting existSetting = _context.Settings.FirstOrDefault(x => x.Id == id);

            if (existSetting == null)
            {
                return RedirectToAction("index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existSetting.ContactPhone = setting.ContactPhone;
            existSetting.InfoPhone = setting.InfoPhone;
            existSetting.ContactMail = setting.ContactMail;
            existSetting.InfoMail = setting.InfoMail;
            existSetting.Adress = setting.Adress;
            existSetting.Logo = setting.Logo;
            existSetting.WorkTime = setting.WorkTime;
            existSetting.InstagramUrl = setting.InstagramUrl;
            existSetting.FacebookUrl = setting.FacebookUrl;
            existSetting.TwitterUrl = setting.TwitterUrl;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
