using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MojahCo.Models;

namespace MojahCo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceImage> ServiceImages { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopImage> ShopImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
 
    }
}