using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
	public class Teacher : Person
	{
		public double Salary { get; set; }

		public void Teaching()
		{
			Console.WriteLine("Teacher teachs");
		}
		public void Run()
		{
			Console.WriteLine("Teacher Run");
		}
	}
}
