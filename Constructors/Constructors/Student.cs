using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	internal class Student:Person
	{
		public string University { get; set; }
        //eger Inherit aldigimiz classin her hansi bir constuctorunu isletmesek gedib bos constuctoru ise salacaq
        //public Student(string Name,string Surname)
        //{
        //    this.Name = Name;
        //    this.Surname = Surname;
        //}

		public Student(string Name, string Surname,int Age,string Address,string University)
			:base(Name,Surname,Address,Age)
		{
			this.University = University;
		}
	}
}
