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
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        public SettingController(AppDbContext context)
        {
            _context = context;
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
            existSetting.WorkTime = setting.WorkTime;
            existSetting.InstagramUrl = setting.InstagramUrl;
            existSetting.FacebookUrl = setting.FacebookUrl;
            existSetting.TwitterUrl = setting.TwitterUrl;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
