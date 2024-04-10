using Casting.Models;

namespace Casting
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Person p1 = new Person();
			p1.Name = "p1";

			Person p2 = new Student();
			p2.Name = "s1";

			Person p3 = new Teacher();
			p3.Name = "t1";

			List<Person> people = new List<Person>();	
			people.Add(p1);
			people.Add(p2);
			people.Add(p3);


			List<Student> people2 = new List<Student>();
			people2.Add((Student)p1);
			people2.Add((Student)p2);
			people2.Add((Student)p3);




			foreach (Person person in people)
			{
				Console.WriteLine(person.Name);
				person.Run();
				if(person is Student)
				{
					((Student)person).Learning();
					(person as Student ).Run();
				}
				if(person is Teacher)
				{
					((Teacher)person).Teaching();
				}
			}


		}
	}
}
