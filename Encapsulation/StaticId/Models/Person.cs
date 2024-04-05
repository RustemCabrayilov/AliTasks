using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticId.Models
{
	public class Person
	{
		//readonly - Menasi odurki bu propertinin deyerinin classdan kenarda deyismek olmur, yalniz constructorlarda deyer vermek olur
		// Bu propertinin deyerinin yalniz oxumaq olur basqa classdan.
		public readonly int Id;
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		//Private - cunki bu propertini yalniz bu classin daxilinde istifade edecik
		//Static - static ona gore verdimki her defe yeni instance alanda sifirlanmasin
		private static int _count ;

        public Person(string Name,string Surname,int Age)
        {
			_count++;
            Id = _count;
			this.Name = Name;
			this.Surname = Surname;
			this.Age = Age;
        }

		public override string ToString()
		{
			return "Id: " + this.Id + " Name: " + this.Name + " Surname: " + this.Surname + " Age: " + this.Age;
		}
	}
}
