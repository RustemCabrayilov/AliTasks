namespace DelegateTasks
{
	internal class Program
	{
		public delegate double AritmeticOperation(double value1, double value2);
		static void Main(string[] args)
		{
			AritmeticOperation aritmeticOperation = null;
            string menu = "1.Addition\n" +
				"2.Subtraction\n" +
				"3.Multiplication\n" +
				"4.Devide\n" +
				"5.Exit";
			bool isContinue = true;

			while (isContinue)
			{
				try
				{

					Console.WriteLine(menu);

					Console.Write("Enter operation number:");
					int operation = int.Parse(Console.ReadLine());

					if (operation == 5)
					{
						isContinue = false;
						Console.WriteLine("Exiting program...");
						break;
					}
					Console.Write("Enter first number: ");
					double firstNumber = double.Parse(Console.ReadLine());

					Console.Write("Enter second number: ");
					double secondNumber = double.Parse(Console.ReadLine());

					switch (operation)
					{
						case 1:
							aritmeticOperation = Addition;
							break;
						case 2:
							aritmeticOperation = Subtraction;
							break;
						case 3:
							aritmeticOperation = Multiplication;
							break;
						case 4:
							aritmeticOperation = Divide;
							break;
						default:
							Console.WriteLine("Enter valid operation number");
							break;
					}
					if (aritmeticOperation != null)
					{
						double result = aritmeticOperation.Invoke(firstNumber, secondNumber);
						Console.WriteLine("Result : " + result);
					}

				}
				catch (FormatException ex)
				{
					Console.WriteLine("Error!!! Daxil etdiyiniz deyere diqqet edin");
				}
				catch (DivideByZeroException ex)
				{
					Console.WriteLine("0-a bolmek olmaz");
				}
			}
		}

		public static double Addition(double value1, double value2)
			=> value1 + value2;
		public static double Subtraction(double value1, double value2)
			=> value1 - value2;
		public static double Multiplication(double value1, double value2)
			=> value1 * value2;
		public static double Divide(double value1, double value2)
		{
			if (value2 == 0)
				throw new DivideByZeroException();

			return value1 / value2;
		}
	}
}
