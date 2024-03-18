namespace Methods
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			string operationList = "1.Sum\n" +
				"2.Difference\n" +
				"3.Multiply\n" +
				"4.Devide\n" +
				"0.Exit Program";
			double result = 0;
			while (true)
			{
				Console.WriteLine(operationList);
				Console.Write("Enter Opertion Number:");
				int operation = int.Parse(Console.ReadLine());
				if (operation == 0)
				{
					Console.WriteLine("Exiting Program...");
					break;
				}
				Console.Write("Enter first number:");
				int number1 = int.Parse(Console.ReadLine());
				Console.Write("Enter second number:");
				int number2 = int.Parse(Console.ReadLine());
				switch (operation)
				{
					case 1:
						result = Sum(number1, number2);
                        Console.WriteLine("Sum of numbers:"+result);
                        break;
					case 2:
						result = Difference(number1, number2);
						Console.WriteLine("Difference of numbers:" + result);
						break;
					case 3:
						result = Multiply(number1, number2);
						Console.WriteLine("Multiply of numbers:" + result);
						break;
					case 4:
						result = Devide(number1, number2);
						Console.WriteLine("Deviding of numbers:" + result);
						break;
					default:
						Console.WriteLine("Enter valid operation");
						break;
				}
			}
		}
		public static int Sum(int number1, int number2)
		{
			int sum = number1 + number2;
			return sum;
		}
		public static int Difference(int number1, int number2)
		{
			int diff = number1 - number2;
			return diff;
		}
		public static int Multiply(int number1, int number2)
		{
			int multiply = number1 * number2;
			return multiply;
		}
		public static double Devide(int number1, int number2)
		{
			double result = (double)number1 / (double)number2;
			return result;
		}
	}
}
