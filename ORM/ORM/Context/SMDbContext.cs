using Microsoft.EntityFrameworkCore;
using ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Context
{
	public class SMDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-NIJAT;Database=StudentManagement;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");
		}
	}
}
