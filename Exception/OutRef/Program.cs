namespace OutRef
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = 5;
			int number2 = 10;
			number2 =AddingNumber(ref number1, number2);
			Console.WriteLine(number1);
			Console.WriteLine(number2);
		}


		public static int AddingNumber(ref int number,int number2)
		{
			number++;
			return number2+10;
		}
	}
}
