using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using neyeyim.DAL;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Services
{
    public class DashboardLayoutViewModelService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        public DashboardLayoutViewModelService(AppDbContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        public List<AppUser> GetName()
        {
            return _context.Users.Where(x => x.IsAdmin).ToList();
        }
    }
}
