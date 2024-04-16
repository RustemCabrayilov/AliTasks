using Extensions.Extension;

namespace Extensions
{
	internal class Program
	{
		static void Main(string[] args)
		{
         while (true)
			{
				Console.Write("Enter password:");
				string password = Console.ReadLine();

				Console.WriteLine(password.ControlPassword());
			}
        }
	}
}
