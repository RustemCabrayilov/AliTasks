using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
	public class Person
	{
		public readonly int Id;
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		private static int _count;

        public Person()
        {
			_count++;
			Id = _count;
        }

		public void Run()
		{
            Console.WriteLine("Person Run");
        }

    }
}
