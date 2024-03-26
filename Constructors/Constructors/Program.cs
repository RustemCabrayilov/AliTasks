namespace Constructors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			////1 parametrli constructor
			//Person person1 = new Person("Ali"); //Gedir default constructor ise dusur

			//Person person2 = new Person("Nijat"); //Her defe instance alanda gedir constructor ise dusur
			////2 parametrli constructor
			//Person person3 = new Person("Ali","Agayev");
			//Person person4 = new Person("Nijat","Soltanov","Baku",20);
			//Person person5 = new Person();
			//Student student = new Student("Nijat","Soltanov",20,"Baku","ADNSU");
			//         Console.WriteLine();
			FindSimples(10, 40);
        }

		public static void FindSimples(int from,int to)
		{
			for (int i = from; i <= to; i++)
			{
				if (CheckSimple(i))
				{
                    Console.WriteLine(i);
                }
			}
		} 
		public static bool CheckSimple(int number)
		{
			//Simple ededler hem ozune hemde 1 e bolunur
			for(int i = 2; i < number; i++)
			// 2 ...... number-1
			{
				if(number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
