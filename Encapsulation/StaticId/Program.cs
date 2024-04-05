using StaticId.Models;

namespace StaticId
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person( "Nijat", "Soltanov", 20);
			Person person2 = new Person( "Ali", "Agayev", 17);
			Person person3 = new Person( "Abbas", "Abbasov", 18);
			Person person4 = new Person("Abbas2", "Abbasov2", 19);



			Console.WriteLine(person.ToString());
			Console.WriteLine(person2.ToString());
			Console.WriteLine(person3.ToString());
			Console.WriteLine(person4.ToString());
		}
	}
}
