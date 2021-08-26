using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
         public DbSet<Slider> Sliders { get; set; }
         public DbSet<Category> Categories { get; set; }
         public DbSet<Place> Places { get; set; }
         public DbSet<Info> Information { get; set; }
         public DbSet<Promotion> Promotions { get; set; }
         public DbSet<PlaceImage> PlaceImages { get; set; }
         public DbSet<Setting> Settings { get; set; }
         public DbSet<Tag> Tags { get; set; }
         public DbSet<PlaceTag> PlaceTags { get; set; }
         public DbSet<Jobad> Jobads { get; set; }
         public DbSet<Campaign> Campaigns { get; set; }
         public DbSet<PlaceMenu> PlaceMenus { get; set; }
         public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<PlaceComment> PlaceComments { get; set; }
        public DbSet<Order> Orderz { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}