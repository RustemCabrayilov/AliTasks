using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal class Dog : IDog, IAnimal
	{
		public void Eating()
		{
			Console.WriteLine("It yeyir");
		}

		public void Fly()
		{
			Console.WriteLine("It ucur");
		}

		public void Running()
		{
			Console.WriteLine("It qacir");
		}
	}

}
