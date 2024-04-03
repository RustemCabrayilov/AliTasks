using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
	public abstract class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }

		public virtual void Eating()
		{
            Console.WriteLine("Person is eating");
        }
		public abstract void Running();
	}
}
