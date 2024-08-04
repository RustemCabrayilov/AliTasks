using AvtosRestoran.Models;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Context
{
    public class AvtosDbContext : DbContext
    {
        public AvtosDbContext(DbContextOptions<AvtosDbContext> options):base(options)
        {

        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
