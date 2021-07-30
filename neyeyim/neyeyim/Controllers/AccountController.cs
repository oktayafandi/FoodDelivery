using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using neyeyim.DAL;
using neyeyim.Models;
using neyeyim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(MemberRegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("User", "Qeydiyyatdan kechmedi");
                return View(registerModel);
            }

            AppUser existUser = await _userManager.FindByNameAsync(registerModel.UserName);
            AppUser existEmail = await _userManager.FindByEmailAsync(registerModel.Email);

            if (existUser != null)
            {
                ModelState.AddModelError("UserName", "Bu username artıq istifadə olunur.");
                return View();
            }

            if (existEmail != null)
            {
                ModelState.AddModelError("Email", "Bu email daha əvvəl qeydiyyatdan keçib.");
                return View();
            }

            AppUser user = new AppUser
            {
                Name = registerModel.Name,
                Surname = registerModel.Surname,
                Email = registerModel.Email,
                UserName = registerModel.UserName,
                PasswordHash = registerModel.Password,
            };

            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Code);
                }
                return View();
            }

            await _signInManager.SignInAsync(user, true);
            _context.SaveChanges();
            return RedirectToAction("index", "home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(MemberLoginModel loginModel)
        {
            AppUser user = await _userManager.FindByNameAsync(loginModel.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya şifrə səhvdir");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya şifrə səhvdir");
                return View();
            }
            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login");
        }
    }
}