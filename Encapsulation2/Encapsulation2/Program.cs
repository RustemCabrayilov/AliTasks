namespace Encapsulation2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();

			car.Marka = "F10";

			Console.WriteLine(car.Marka);


			//car.Marka = "    ";

			// **Task 7**. Bir Person sinifi yaradın. Bu sinifin içində, ad və yaş kimi məlumatları saxlayan private dəyişənlər olsun. Daha sonra, bu dəyişənlərə müraciət etmək üçün public metodlar əlavə edin.


			Person person = new Person();

			person.SetName("Ali");
            Console.WriteLine(person.GetName());

        }
	}
}
