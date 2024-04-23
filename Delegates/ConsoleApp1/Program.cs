namespace ConsoleApp1
{
	internal class Program
	{
		public delegate T SumDelegate<T>(T number1, T number2);
		public delegate float DelegateFloat(float number1, float number2);
		public delegate void Delegate(string message);
		public delegate void FreeDelegate();
		static void Main(string[] args)
		{
			#region DelegateIntro

			//DelegateFloat delegateFloat = new DelegateFloat(AddNumbersFloat);
			//float result = delegateFloat.Invoke(1,2);
			//Console.WriteLine(result);

			// SumDelegate sumDelegate = new SumDelegate(AddNumbers);
			//SumDelegate sumDelegate = AddNumbers;

			//int sum = sumDelegate.Invoke(20, 30);
			// Console.WriteLine(sum);

			//PrintA("SalamA");
			//PrintB("SalamB");
			//PrintC("SalamC");

			//delegateAll += PrintB;

			//delegateAll += PrintC;
			//delegateAll.Invoke("SalamAll");

			//Delegate delegateA = new Delegate(PrintA);
			//Delegate delegateB= new Delegate(PrintB);


			//Delegate delegateAB = delegateA+delegateB;

			//RunDelegate(delegateAB, "asdasd");
			#endregion
			#region Generic Delegate
			//SumDelegate<int> sumDelegateint = new SumDelegate<int>(AddNumbersInt);
			//SumDelegate<float> sumDelegatefloat = new SumDelegate<float>(AddNumbersFloat);


			//         Console.WriteLine(sumDelegateint.Invoke(10,15));
			//         Console.WriteLine(sumDelegatefloat.Invoke((float)14.5,(float)12.9));

			#endregion
			#region Func Delegate
			//Func<int,int,int> func1 = AddNumbersInt;

			//         Console.WriteLine(func1.Invoke(10, 15));


			//Func<float, float, float> func2 = AddNumbersFloat;
			//         Console.WriteLine(func2.Invoke((float)14.5,(float)12.2));

			#endregion
			#region Action

			//Action<string> action1 = new Action<string>(PrintA);
			//action1 += PrintB;

			//action1.Invoke("Hello, World!");

			#endregion
			#region Predicate

			//Func<int, int, bool> func = new Func<int, int, bool>(EqualsNumber);

   //         Console.WriteLine(func.Invoke(5,5));

			//Predicate<int> predicate = new Predicate<int>(IsEven);

   //         Console.WriteLine(predicate.Invoke(6));

			#endregion
			#region Anonymous Methods

			//Delegate newDelegate = PrintA;


			//Delegate anonymousDelegate = (string message) =>
			//{
			//	int number = 0;
			//	number++;
			//	Console.WriteLine(number);
			//	Console.WriteLine(message);
			//};

			//anonymousDelegate.Invoke("Anonymous ise dusdu");

			//newDelegate.Invoke("PrintA isledi");



			FreeDelegate freeDelegate = MethodA;
			freeDelegate.Invoke();


			freeDelegate = () =>
			{
			     Console.WriteLine("A");
			};
			freeDelegate.Invoke();


			DelegateFloat delegateFloat = (float number1, float number2) =>
			{
				return number1 + number2;
			};

            Console.WriteLine(delegateFloat.Invoke(5,10));



            #endregion

        }

		static bool EqualsNumber(int number1, int number2)  
			=> number1 == number2;

		static bool IsEven(int number)
			=> number % 2 == 0;

		//static bool IsEven(int number)
		//{
		//	if(number % 2 == 0)
		//	{
		//		return true;
		//	}
		//	else
		//	{
		//		return false;
		//	}
		//}

		static int AddNumbersInt(int number1, int number2)
		{
			return number1 + number2;
		}
		static float AddNumbersFloat(float number1, float number2)
		{
			return number1 + number2;
		}

		static void RunDelegate(Delegate testDelegate, string message)
		{
			testDelegate.Invoke(message);
		}
		public static void PrintA(string message)
		{
			Console.WriteLine(message);
		}
		public static void PrintB(string message)
		  => Console.WriteLine(message);
		public static void PrintC(string message)
		{
			Console.WriteLine(message);
		}

		public static void MethodA()
		{
			int number = 10;
			number++;
			Console.WriteLine(number);
		}

	}
}
