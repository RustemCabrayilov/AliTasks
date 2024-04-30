namespace Tasks
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Print().RunSynchronously();


			//         Console.WriteLine("Salammmm");



			for (int i = 0; i < 5; i++)
			{
				
				for (int j = 0; j < 5; j++)
				{
				    if(j<i)
						Console.Write("  ");
					else
                        Console.Write("* ");

                }
				Console.WriteLine();

			}


			//Save
		}
		public static async Task Print()
		{
			for (int i = 11; i < 20; i++)
			{
				Console.WriteLine("Print Method " + i);
				Thread.Sleep(1000);
			}
		}
		public static void Cen1()
		{
			Console.WriteLine("1-ci Cenimiz dolmaga basladi");

			Thread.Sleep(4000);

			Console.WriteLine("1-ci doldu");
		}
		public static void Cen2()
		{
			Console.WriteLine("2-ci Cenimiz dolmaga basladi");

			Thread.Sleep(7000);

			Console.WriteLine("2-ci doldu");
		}
	}
}
