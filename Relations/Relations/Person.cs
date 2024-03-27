using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
	public class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		private int Age { get; set; }

		//public
		//private
		//static
		//private Person() 
		//{
		//		Console.WriteLine("Private Constructor");
		//}
		//public Person() {
  //          Console.WriteLine("Normal Constructor");
  //      }
       public Person() {}
		//public Person(string Name)
		//{
		//	this.Name= Name;
		//}

		//public Person(string Name,string Surname):this(Name)
		//{
		//	this.Surname= Surname;
		//}

		//public Person(string Name, string Surname, int Age):this(Name,Surname)
		//{
		//	this.Age = Age;
		//}


		public Person(string Name,string Surname,int Age)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.Age = Age;
		}

		static Person()
		{
            Console.WriteLine("Static Constructor");
        }
	}
}
