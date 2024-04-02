using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
	public class Teacher : Person
	{
		public float Salary { get; set; }
		public override void Eating()
		{
            Console.WriteLine("Teacher yemek yeyir");
        }

		public override void Running()
		{
            Console.WriteLine("Teacher isnot running");
        }
	}
}
