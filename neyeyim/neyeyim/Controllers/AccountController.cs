using Microsoft.AspNetCore.Authorization;
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
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
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

            await _userManager.AddToRoleAsync(user, "Member");
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

        //public async Task<IActionResult> CreateSuperAdmin()
        //{
        //    AppUser admin = new AppUser
        //    {
        //        UserName = "Superadmin",
        //        Name = "Oktay Afandi",
        //        IsAdmin = true,
        //    };

        //    //passsword: superadmin123
        //    await _userManager.CreateAsync(admin, "superadmin123");
        //    await _userManager.AddToRoleAsync(admin, "Superadmin");

        //    return Ok();
        //}

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Edit()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AppUser member)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (_userManager.Users.Any(x => x.UserName == member.UserName && x.Id != user.Id))
            {
                ModelState.AddModelError("UserName", "Bu istifadəçi adı artıq istifadə olunur!");
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            user.UserName = member.UserName;
            user.Name = member.Name;
            user.Surname = member.Surname;
            user.Email = member.Email;

            if (!string.IsNullOrWhiteSpace(member.Password))
            {
                if (string.IsNullOrWhiteSpace(member.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Cari şifrə boş ola bilməz!");
                    return View();
                }

                var result = await _userManager.ChangePasswordAsync(user, member.CurrentPassword, member.Password);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View();
                }
            }
            await _userManager.UpdateAsync(user);

            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("index", "home");
        }
    }
}