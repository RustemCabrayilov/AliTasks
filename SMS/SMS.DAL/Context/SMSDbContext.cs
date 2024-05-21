using Microsoft.EntityFrameworkCore;
using SMS.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Context
{
	public class SMSDbContext : DbContext
	{
		public DbSet<Group> Groups { get; set; }
		public DbSet<Student> Students { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-NIJAT;Database=SMS;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");
		}
	}
}
