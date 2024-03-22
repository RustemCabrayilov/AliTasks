using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
	internal class Teacher : Person //Teacher is Person
	{
		public double Salary { get; set; }
		public string StudyField { get; set; }

		//overriding
		public void Eating()
		{
            Console.WriteLine("Muellim yemek yeyir");
        }
	}
}
