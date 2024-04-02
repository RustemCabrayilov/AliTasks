namespace Interface
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Animal animal = new Animal();
			//animal.Running();

			Dog dog = new Dog();
			Cat cat = new Cat();

			dog.Fly();

			cat.Running();
		}
	}
}
