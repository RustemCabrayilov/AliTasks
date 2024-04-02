using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
	public class Student : Person
	{
		public string GroupNumber { get; set; }

		public override void Eating()
		{
            Console.WriteLine("Student Yemek yeyir");
        }

		//public Student(int Id,string Name,string Surname,string Addres,int Age) :base(Id, Name, Surname, Addres,Age)
		//{
		//}
	}
}
