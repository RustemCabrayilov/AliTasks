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
    }
}
