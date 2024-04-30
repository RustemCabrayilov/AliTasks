namespace SyncAsyncThread
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Cen1();
			//Cen2();
			var date1 = DateTime.Now;
			Thread thread = new Thread(Cen1);
			thread.Start();


			Cen2();
			var date2 = DateTime.Now;

			Console.WriteLine((date2 - date1).TotalSeconds);

			//Thread thread = new Thread(Print);

			//thread.Start();
			////Print();

			//for (int i = 0; i < 10; i++)
			//{
			//	Console.WriteLine("Main Method " + i);
			//	Thread.Sleep(200);
			//}

		}

		public static void Print()
		{
			for(int i = 11; i <20; i++)
			{
                Console.WriteLine("Print Method "+ i);
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
