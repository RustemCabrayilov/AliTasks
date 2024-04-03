using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
	internal class Student : Person
	{
		public override void Running()
		{
            Console.WriteLine("Student is Running");
        }
		public override void Eating()
		{
			Console.WriteLine("Student is eating");
		}
	}
}
