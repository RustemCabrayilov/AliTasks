using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	public class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public int Age { get; set; }
		//public Person()
		//{
		//    //Methoddur amma return type yoxdur
		//    //Classnan eyni addadir
		//    //Eger biz gelib constructoru ozumuz yazmasaq default olaraq c# bos constructor ise salir

		//    Console.WriteLine("Constructor ise dusdu");
		//}


		//Constructorlarimiz 3 formada olur
		//1. Indi yazdigimiz public 
		//2. Private olur
		//3. Static constuctorlar olur
		public Person()
        {
            Console.WriteLine("Parametrsiz constuctor");
        }

        public Person(string Name)
        {
            this.Name = Name;
			Console.WriteLine("1 parametrli constuctor");
		}
		//Constuctor Overloading adlanir
		public Person(string Name,string Surname)
		{
			this.Name = Name;
			this.Surname = Surname;
			Console.WriteLine("2 parametrli constuctor");
		}
        public Person(string Name,string Surname,string Address,int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Address = Address;
            this.Age = Age;
			Console.WriteLine("4 parametrli constuctor");
		}
        //Static Constructor
		//1 defe ise dusur,2 ci sefer ise dusmur
		//Classi ilk defe cagiranda
        static Person()
        {
            Console.WriteLine("Static Constuctor isledi");
        }

    }
}
