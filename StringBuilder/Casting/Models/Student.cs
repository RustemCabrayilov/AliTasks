using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
	public class Student : Person
	{

		public void Learning() {
            Console.WriteLine("Student learns");
        }
		public void Run()
		{
			Console.WriteLine("Student Run");
		}
	}
}
