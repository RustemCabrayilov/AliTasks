namespace SingleNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("BAslangic qiymeti daxil edin:");
			int a = int.Parse(Console.ReadLine());//5

			Console.Write("Son qiymeti daxil edin:");
			int b = int.Parse(Console.ReadLine());//15


			for (int i = a; i <= b; i++) //5
			{
				if (i == 13)
					continue;

				bool isSingle = true;
				for (int j = 2; j < i; j++) //2 3 4
				{
					if(i % j == 0)
					{
						isSingle = false;
						break;
					}
				}
				if(isSingle)
                    Console.Write(i+" ");
            }
		}
	}
}
