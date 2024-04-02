using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public  class Animal : IAnimal
	{
		public string Name { get; set; }

		public  void Eating()
		{
			Console.WriteLine("Heyvan yemek yeyir");
		}

		public void Running()
		{
			Console.WriteLine("Heyvan yemek yeyir");
		}
	}
}
